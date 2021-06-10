using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        //iletisim kismi. Kendi kullanıcılar değilde dışardan kullanıcı
        [Key]
        public int ConcactID { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string UserMail { get; set; }

        [StringLength(50)]

        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
