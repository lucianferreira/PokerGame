namespace PokerGame.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int Id { get; set; }

        [Required]
        public string UserName { get; set; }

        public int? HandsWon { get; set; }

        public int? HandsLost { get; set; }

        public string HighestHand { get; set; }

        public int AccountBalance { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
