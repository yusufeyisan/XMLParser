using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace XMLOkuyucu.Models
{
    public class XmlOkuyucuContex : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
    }
}