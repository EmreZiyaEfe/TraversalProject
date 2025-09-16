namespace TraversalProject.Areas.Member.Models
{
    public class UserEditVm
    {
        public string Name { get; set; }
        public string SurName{ get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string ImageUrl { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public IFormFile Image { get; set; }
    }
}
