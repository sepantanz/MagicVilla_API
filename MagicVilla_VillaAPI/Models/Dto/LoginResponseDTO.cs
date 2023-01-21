namespace MagicVilla_VillaAPI.Models.Dto
{
    public class LoginResponseDTO
    {
        public UsersDTO User { get; set; }
        public string Token { get; set; }
    }
}
