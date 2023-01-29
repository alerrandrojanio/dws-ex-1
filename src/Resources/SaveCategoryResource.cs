using System.ComponentModel.DataAnnotations;

namespace dws_ex_1.src.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }

    public class SaveEmployeeResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string Birthday { get; set; }
    }
}
