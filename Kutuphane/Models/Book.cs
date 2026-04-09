namespace KutuphaneProjesi.Models
{
    public class Book
    {
        public int Id { get; set; } // Kitabın numarası (otomatik artar)
        public string Title { get; set; } // Kitap Adı
        public string Author { get; set; } // Yazarı
        public decimal Price { get; set; } // Fiyatı
        public int Stock { get; set; } // Stok Adedi
    }
}
