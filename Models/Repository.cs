using Microsoft.AspNetCore.Http.HttpResults;

namespace ilanApp.Models
{
    public static class Repository
    {
        private static List<Category> _categories = new();
        public static List<Category> categories
        {
            get { return _categories; }
        }
        private static List<advertInfo> _advertInfo = new();
        public static List<advertInfo> AdvertInfo
        {
            get
            {
                return _advertInfo;
            }
        }
        static Repository()
        {

            _categories.Add(new Category { CategoryId = 1, Name = "Telefon" });
            _categories.Add(new Category { CategoryId = 2, Name = "Bilgisayar" });


            _categories.Add(new Category { CategoryId = 3, Name = "Emlak" });
            _categories.Add(new Category { CategoryId = 4, Name = "Vasıta" });
            _categories.Add(new Category { CategoryId = 5, Name = "Ev Eşyaları" });
            _categories.Add(new Category { CategoryId = 6, Name = "Hizmet" });
            _categories.Add(new Category { CategoryId = 7, Name = "Giyim" });


            _advertInfo.Add(new advertInfo
            {
                id = 1,
                title = "Merkezi Konumda Kiralık 3+1 Daire",
                desc = "Şehir merkezine yakın, ulaşım sorunu olmayan, geniş ve ferah 3. kat daire. Okullara ve marketlere yürüme mesafesinde.",
                image = "/image/trybanner.png",
                CategoryId = 3, // Emlak
                price = 12500
            });

            // Vasıta -> CategoryId = 4
            _advertInfo.Add(new advertInfo
            {
                id = 2,
                title = "Sahibinden Temiz Kullanılmış 2020 Model Sedan",
                desc = "Düşük kilometreli, tüm bakımları yapılmış, hasarsız, otomatik vites, yakıt cimrisi aile aracı.",
                image = "/image/trybanner.png",
                CategoryId = 4, // Vasıta
                price = 680000
            });


            _advertInfo.Add(new advertInfo
            {
                id = 3,
                title = "Sıfır Ayarında Oyuncu Bilgisayarı Satılık",
                desc = "i7 işlemci, 32 GB RAM, RTX 3070 ekran kartı. En güncel oyunları ultra ayarlarda oynatır. Fatura ve garantisi mevcuttur.",
                image = "/image/trybanner.png",
                CategoryId = 2, // Bilgisayar
                price = 32500
            });

            // Ev Eşyaları -> CategoryId = 5
            _advertInfo.Add(new advertInfo
            {
                id = 4,
                title = "El Yapımı Seramik Kahve Fincan Seti",
                desc = "6 adet, özel tasarım, el yapımı seramik fincanlar. Mutfaklara otantik bir hava katar. Hediyelik için ideal.",
                image = "/image/trybanner.png",
                CategoryId = 5, // Ev Eşyaları
                price = 850
            });

            // Hizmet -> CategoryId = 6
            _advertInfo.Add(new advertInfo
            {
                id = 5,
                title = "İngilizce Özel Ders - Her Seviye",
                desc = "Deneyimli öğretmen ile online veya yüz yüze İngilizce dersleri. Genel İngilizce, TOEFL ve IELTS hazırlık.",
                image = "/image/trybanner.png",
                CategoryId = 6, // Hizmet
                price = 400
            });

            // Ev Eşyaları -> CategoryId = 5
            _advertInfo.Add(new advertInfo
            {
                id = 6,
                title = "Antika Ahşap Sandalye Takımı (4 Adet)",
                desc = "1950'lerden kalma, orijinal ahşap oyma detaylara sahip, restore edilmiş 4 adet sandalye. Koleksiyonluk.",
                image = "/image/trybanner.png",
                CategoryId = 5, // Ev Eşyaları
                price = 9000
            });

            // Hizmet -> CategoryId = 6
            _advertInfo.Add(new advertInfo
            {
                id = 7,
                title = "Sırt ve Bel Ağrısı İçin Profesyonel Masaj",
                desc = "Sertifikalı masörden medikal ve rahatlatıcı masaj hizmetleri. Randevu ile çalışılır.",
                image = "/image/trybanner.png",
                CategoryId = 6, // Hizmet
                price = 550
            });

            // Giyim -> CategoryId = 7
            _advertInfo.Add(new advertInfo
            {
                id = 8,
                title = "Yeni Sezon Kadın Deri Mont",
                desc = "Hiç kullanılmamış, etiketi üzerinde. Gerçek deri, M beden. Satın alırken beden uymadığı için satılıyor.",
                image = "/image/trybanner.png",
                CategoryId = 7, // Giyim
                price = 1800
            });

            // Emlak -> CategoryId = 3
            _advertInfo.Add(new advertInfo
            {
                id = 9,
                title = "2 Dönüm Yatırımlık Zeytinlik Arazi",
                desc = "Yolu, suyu mevcut. Elektrik hattı yakınında. İmarlı bölgeye yakın. Getirisi yüksek, bakımlı zeytin ağaçları.",
                image = "/image/trybanner.png",
                CategoryId = 3, // Emlak
                price = 1200000
            });

            // Bilgisayar -> CategoryId = 2
            _advertInfo.Add(new advertInfo
            {
                id = 10,
                title = "DJI Mavic Mini 2 Drone Satılık",
                desc = "Çok az kullanılmış, hasarsız, 3 batarya Fly More Combo seti. Profesyonel çekimler için ideal.",
                image = "/image/trybanner.png",
                CategoryId = 2, // Bilgisayar
                price = 11000
            });

            // Hizmet -> CategoryId = 6
            _advertInfo.Add(new advertInfo
            {
                id = 11,
                title = "İşinde Uzman Su Tesisatçısı",
                desc = "7/24 hizmet. Kırmadan dökmeden su kaçağı tespiti, tıkanıklık açma ve tüm tesisat arızaları.",
                image = "/image/trybanner.png",
                CategoryId = 6,
                price = 300
            });

            // Vasıta -> CategoryId = 4
            _advertInfo.Add(new advertInfo
            {
                id = 12,
                title = "Yazlık Tatile Uygun Karavan Kiralama",
                desc = "4 kişilik, tam donanımlı çekme karavan. Buzdolabı, ocak, tuvalet, duş mevcut. Haftalık veya aylık kiralama.",
                image = "/image/trybanner.png",
                CategoryId = 4,
                price = 1500
            });

            // Ev Eşyaları -> CategoryId = 5
            _advertInfo.Add(new advertInfo
            {
                id = 13,
                title = "Yeni Başlayanlar İçin Klasik Gitar",
                desc = "Az kullanılmış, tınısı güzel bir başlangıç gitarı. Kılıfı ve pena hediyeli.",
                image = "/image/trybanner.png",
                CategoryId = 5, // Ev Eşyaları
                price = 1450
            });

            // Ev Eşyaları -> CategoryId = 5
            _advertInfo.Add(new advertInfo
            {
                id = 14,
                title = "Organik Ev Yapımı Reçeller",
                desc = "Şeker ilavesiz, tamamen doğal meyvelerden yapılmış çilek, vişne ve kayısı reçelleri. Sipariş üzerine hazırlanır.",
                image = "/image/trybanner.png",
                CategoryId = 5, // Ev Eşyaları
                price = 85
            });

            // Ev Eşyaları -> CategoryId = 5
            _advertInfo.Add(new advertInfo
            {
                id = 15,
                title = "Şık ve Modern Yemek Odası Takımı",
                desc = "6 kişilik açılır masa ve 6 adet sandalyeden oluşur. Sadece 6 ay kullanıldı, taşınma nedeniyle satılık.",
                image = "/image/trybanner.png",
                CategoryId = 5,
                price = 18500
            });

        }
        public static void CreateAdvert(advertInfo advert)
        {
            _advertInfo.Add(advert);
        }
        public static advertInfo? GetById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return _advertInfo.FirstOrDefault(advert => advert.id == id);
        }
        public static void EditbyId(advertInfo newInfoEntity)
        {
            Console.WriteLine($"Edit: {newInfoEntity.id} → {newInfoEntity.title}");
            var currentInfo = _advertInfo.FirstOrDefault(advert => advert.id == newInfoEntity.id);
           
            if (currentInfo != null)
            
                 
            {
                currentInfo.image = newInfoEntity.image;
                currentInfo.title = newInfoEntity.title;
                currentInfo.desc = newInfoEntity.desc;
                currentInfo.CategoryId = newInfoEntity.CategoryId;
                currentInfo.price = newInfoEntity.price;
                

            }




        }
    }
}