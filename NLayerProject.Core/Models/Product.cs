namespace NLayerProject.Core.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public int Price { get; set; }

        public int CategoryId { get; set; }

        public bool IsDeleted { get; set; }

        public string InnerBarcode { get; set; }

        public virtual Category Category { get; set;}//Ürün Categoriye bağlı olacağından dolayı Category sınıfına referans vermemiz lazım

    }
}
