using MelodiousApp.DataTrasfer;

namespace MelodiousApp.Services.Interface
{
    public interface ICredentialService
    {
        public Task<List<CredentialDto>> GetAll();
        public Task<CredentialDto> GetById(int id);
        public Task<int> AddNew(CredentialDto credentialDto);
        public Task<CredentialDto> Update(CredentialDto credentialDto);
        public Task<int> Delete(int id);
    }
}