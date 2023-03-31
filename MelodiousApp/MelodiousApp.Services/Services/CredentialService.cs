using MelodiousApp.DataAccess.Repository.Interfaces;
using MelodiousApp.DataTrasfer;
using MelodiousApp.DataTrasfer.Mappers;
using MelodiousApp.Models;
using MelodiousApp.Services.Interface;

namespace MelodiousApp.Services.Services
{
    public class CredentialService : ICredentialService
    {
        private readonly ICredentialRepository _credentialRepository;
        public UserService(ICredentialRepository credentialRepository)
        {
            _credentialRepository = credentialRepository;
        }
        public async Task<int> AddNew(CredentialDto credentialDto)
        {
            User credential = CredentialMapper.DtoToModel(credentialDto);
            var credentialCreated = await _credentialRepository.Create(credential);
            return credentialCreated.Id;
        }
        public async Task<int> Delete(int id)
        {
            var credentialDeleted = await _credentialRepository.Delete(id);
            return credentialDeleted.Id;
        }
        public async Task<List<CredentialDto>> GetAll()
        {
            var credentials = await _credentialRepository.GetAll();
            var credentialsDto = credentials.Select(CredentialMapper.ModelToDto).ToList();
            return credentialsDto;
        }

        public async Task<CredentialDto> GetById(int id)
        {
            var credential = await _credentialRepository.GetOne(id);
            return CredentialMapper.ModelToDto(credential);
        }
        public async Task<CredentialDto> Update(CredentialDto credentialDto)
        {
            var credential = CredentialMapper.DtoToModel(credentialDto);
            var credentialModel = await _credentialRepository.Update(credential);
            return CredentialMapper.ModelToDto(credentialModel);
        }
    }
}