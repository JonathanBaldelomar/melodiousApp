using MelodiousApp.Models;

namespace MelodiousApp.DataTrasfer.Mappers
{
    public class CredentialMapper
    {
        public static Credential DtoToModel(CredentialDto credentialDto)
            => new Credential()
            {
                Id = credentialDto.Id,
                Email = credentialDto.Email,
                Password = credentialDto.Password
            };

        public static CredentialDto ModelToDto(Credential credential)
        {
            return new CredentialDto()
            {
                Id = credential.Id,
                Email = credential.Email,
                Password = credential.Password
            };
        }
    }
}
