#nullable disable

namespace shopApp_BackEnd.Models
{
    public partial class BankAccount
    {
        public long CardNumber { get; set; }
        public string Password { get; set; }
        public int? Balance { get; set; }
    }
}
