using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategoryDescription{ get; set; }
        public bool CategoryStatus { get; set; }
        //durum . Biz ilişkili tablolarda silme işlemini kullanmayacağız onun yerine aktif-pasif durumunu kullnacağız.
        //Çünkü code-first ile tablo oluşturduk. Bir kategoriyi silince hepsi silinecek.

        public ICollection<Heading> Headings;
    }
}
