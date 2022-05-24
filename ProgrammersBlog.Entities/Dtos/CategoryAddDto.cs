using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adi")]
        [Required(ErrorMessage ="{0} boş geçilmemelidir")]
        [MaxLength(70,ErrorMessage = "{0}{1} karakterden büyük olamamlıdır.")]
        [MinLength(3,ErrorMessage = "{0}{1} karakterden küçük olamamlıdır")]
        public string Name { get; set; }
        [DisplayName("Kategori açıklaması")]
        [MaxLength(70, ErrorMessage = "{0}{1} karakterden büyük olamamlıdır.")]
        [MinLength(3, ErrorMessage = "{0}{1} karakterden küçük olamamlıdır")]
        public string Description { get; set; }
        [DisplayName("Kategori özel Not Alanı")]
        [MaxLength(70, ErrorMessage = "{0}{1} karakterden büyük olamamlıdır.")]
        [MinLength(3, ErrorMessage = "{0}{1} karakterden küçük olamamlıdır")]
        public string Note { get; set; }
        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} boş geçilmemelidir")]
        public bool IsActive { get; set; }
    }
}
