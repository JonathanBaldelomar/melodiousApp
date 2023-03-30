﻿using MelodiousApp.DataTrasfer.Mappers;
using MelodiousApp.DataTrasfer;
using MelodiousApp.Models;
using MelodiousApp.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiousApp.Services.Services
{
    public class CredentialService : ICredentialService
    {
        private readonly ICredentialRepository _credentialRepository;
        public UserService(ICredentialRepository credentialRepository)
        {
            _credentialRepository = credentialRepository;
        }
        public async Task<int> AddNew(UserDto userDto)
        {
            User user = UserMapper.DtoToModel(userDto);
            var userCreated = await _userRepository.Create(user);
            return userCreated.Id;
        }
        public async Task<int> Delete(int id)
        {
            var userDeleted = await _userRepository.Delete(id);
            return userDeleted.Id;
        }
        public async Task<List<UserDto>> GetAll()
        {
            var users = await _userRepository.GetAll();
            var usersDto = users.Select(UserMapper.ModelToDto).ToList();
            return usersDto;
        }

        public async Task<UserDto> GetById(int id)
        {
            var user = await _userRepository.GetOne(id);
            return UserMapper.ModelToDto(user);
        }
        public async Task<UserDto> Update(UserDto userDto)
        {
            var user = UserMapper.DtoToModel(userDto);
            var userModel = await _userRepository.Update(user);
            return UserMapper.ModelToDto(userModel);
        }
    }
}
