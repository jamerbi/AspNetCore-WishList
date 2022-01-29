using System.ComponentModel.DataAnnotations;

namespace WishList.Models {
    public class Item {
        public int Id { get; set; }
        // attribute required and max lenght 50
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

    }
}