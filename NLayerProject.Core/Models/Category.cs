using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NLayerProject.Core.Models
{
   public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();//İlk oluşturulduğunda category boş bir collection nesnesi oluştursun.
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Product> Products { get; set; }//Her Kategori birden fazla ürüne sahip olabilir.ICollection interfacesinden bir dizi oluşturduk.
        //Code First 

    }
}
