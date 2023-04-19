using Microsoft.EntityFrameworkCore;
using Backend.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using Backend.BusinessLogic.Base;
using Backend.Common.DTOs;
using Backend.Common.Extensions;
using Backend.Entities;
using Backend.Common.Exceptions;
using System.Text.RegularExpressions;
using Backend.Entities.Enums;

namespace Backend.BusinessLogic.Account
{
    public class UserAccountService : BaseService
    {
        private readonly RegisterUserValidator RegisterUserValidator;

        public UserAccountService(ServiceDependencies dependencies)
            : base(dependencies)
        {
            RegisterUserValidator = new RegisterUserValidator(UnitOfWork);
        }

        public async Task<CurrentUserDto> Login(LoginModel model)
        {
            var user = await UnitOfWork.Users
                .Get()
                .Include(u => u.Idroles)
                .FirstOrDefaultAsync(u => u.Email == model.Email);

            if (user == null)
            {
                return new CurrentUserDto { IsAuthenticated = false };
            }

            if (user.IsDeleted == true)
            {
                return new CurrentUserDto { IsDisabled = true };
            }

            if (!user.Password.SequenceEqual(model.Password.HashPassword(user.Salt)))
            {
                return new CurrentUserDto { IsAuthenticated = false };
            }

            var roles = user.Idroles.Select(r => r.Name).ToList();

            return new CurrentUserDto
            {
                Id = user.Iduser,
                Email = user.Email,
                Name = user.Name,
                Username = user.Username,
                IsAuthenticated = true,
                IsDisabled = user.IsDeleted ?? false,
                Roles = roles,
            };
        }

        public void RegisterNewUser(RegisterModel model)
        {
            ExecuteInTransaction(uow =>
            {
                RegisterUserValidator.Validate(model).ThenThrow(model);
                var userSalt = Guid.NewGuid();

                var user = new User()
                {
                    Iduser = Guid.NewGuid(),
                    Salt = Guid.NewGuid(),
                    Email = model.Email,
                    Name = model.Name,
                    BirthDate = (DateTime)model.BirthDay,
                    Username = model.Username
                };

                user.Password = model.PasswordString.HashPassword(user.Salt);
                var userRole = uow.Roles.Get().FirstOrDefault(r => r.Idrole == (int)RoleTypes.User);
                user.UserWeightHistories.Add(new UserWeightHistory()
                {
                    Iduser = user.Iduser,
                    WeighingDate = DateTime.UtcNow,
                    Weight = (double)model.Weight,
                    IduserNavigation = user,
                });

                user.LastLoginDate = DateTime.Now;

                user.Idroles.Add(userRole);


                uow.Users.Insert(user);

                uow.SaveChanges();
            });
        }

    }
}
