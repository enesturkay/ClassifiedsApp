namespace ilanApp.Models
{
    public static class Repository
    {
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
            // Varsayım: Bu kod bir metodun veya sınıfın içinde çalışıyor ve
            // _advertInfo, List<advertInfo> tipinde bir koleksiyondur.

            // Emlak İlanları
            _advertInfo.Add(new advertInfo
            {
                id = 1,
                title = "Merkezi Konumda Kiralık 3+1 Daire",
                desc = "Şehir merkezine yakın, ulaşım sorunu olmayan, geniş ve ferah 3. kat daire. Okullara ve marketlere yürüme mesafesinde.",
                image = "/image/trybanner.png",
                category = "Emlak",
                price = 12500
            });

            _advertInfo.Add(new advertInfo
            {
                id = 9,
                title = "2 Dönüm Yatırımlık Zeytinlik Arazi",
                desc = "Yolu, suyu mevcut. Elektrik hattı yakınında. İmarlı bölgeye yakın. Getirisi yüksek, bakımlı zeytin ağaçları.",
                image = "/image/trybanner.png",
                category = "Emlak",
                price = 1200000
            });

            // Vasıta İlanları
            _advertInfo.Add(new advertInfo
            {
                id = 2,
                title = "Sahibinden Temiz Kullanılmış 2020 Model Sedan",
                desc = "Düşük kilometreli, tüm bakımları yapılmış, hasarsız, otomatik vites, yakıt cimrisi aile aracı.",
                image = "/image/trybanner.png",
                category = "Vasıta",
                price = 680000
            });

            _advertInfo.Add(new advertInfo
            {
                id = 12,
                title = "Yazlık Tatile Uygun Karavan Kiralama",
                desc = "4 kişilik, tam donanımlı çekme karavan. Buzdolabı, ocak, tuvalet, duş mevcut. Haftalık veya aylık kiralama.",
                image = "/image/trybanner.png",
                category = "Vasıta",
                price = 1500
            });

            // Elektronik İlanları
            _advertInfo.Add(new advertInfo
            {
                id = 3,
                title = "Sıfır Ayarında Oyuncu Bilgisayarı Satılık",
                desc = "i7 işlemci, 32 GB RAM, RTX 3070 ekran kartı. En güncel oyunları ultra ayarlarda oynatır. Fatura ve garantisi mevcuttur.",
                image = "/image/trybanner.png",
                category = "Elektronik",
                price = 32500
            });

            _advertInfo.Add(new advertInfo
            {
                id = 10,
                title = "DJI Mavic Mini 2 Drone Satılık",
                desc = "Çok az kullanılmış, hasarsız, 3 batarya Fly More Combo seti. Profesyonel çekimler için ideal.",
                image = "/image/trybanner.png",
                category = "Elektronik",
                price = 11000
            });

            // Ev & Yaşam İlanları
            _advertInfo.Add(new advertInfo
            {
                id = 4,
                title = "El Yapımı Seramik Kahve Fincan Seti",
                desc = "6 adet, özel tasarım, el yapımı seramik fincanlar. Mutfaklara otantik bir hava katar. Hediyelik için ideal.",
                image = "/image/trybanner.png",
                category = "Ev & Yaşam",
                price = 850
            });

            _advertInfo.Add(new advertInfo
            {
                id = 15,
                title = "Şık ve Modern Yemek Odası Takımı",
                desc = "6 kişilik açılır masa ve 6 adet sandalyeden oluşur. Sadece 6 ay kullanıldı, taşınma nedeniyle satılık.",
                image = "/image/trybanner.png",
                category = "Ev & Yaşam",
                price = 18500
            });

            // Hizmet ve Eğitim İlanları
            _advertInfo.Add(new advertInfo
            {
                id = 5,
                title = "İngilizce Özel Ders - Her Seviye",
                desc = "Deneyimli öğretmen ile online veya yüz yüze İngilizce dersleri. Genel İngilizce, TOEFL ve IELTS hazırlık.",
                image = "/image/trybanner.png",
                category = "Özel Ders",
                price = 400
            });

            _advertInfo.Add(new advertInfo
            {
                id = 7,
                title = "Sırt ve Bel Ağrısı İçin Profesyonel Masaj",
                desc = "Sertifikalı masörden medikal ve rahatlatıcı masaj hizmetleri. Randevu ile çalışılır.",
                image = "/image/trybanner.png",
                category = "Hizmet",
                price = 550
            });

            _advertInfo.Add(new advertInfo
            {
                id = 11,
                title = "İşinde Uzman Su Tesisatçısı",
                desc = "7/24 hizmet. Kırmadan dökmeden su kaçağı tespiti, tıkanıklık açma ve tüm tesisat arızaları.",
                image = "/image/trybanner.png",
                category = "Hizmet",
                price = 300
            });

            // Giyim, Antika ve Müzik İlanları
            _advertInfo.Add(new advertInfo
            {
                id = 6,
                title = "Antika Ahşap Sandalye Takımı (4 Adet)",
                desc = "1950'lerden kalma, orijinal ahşap oyma detaylara sahip, restore edilmiş 4 adet sandalye. Koleksiyonluk.",
                image = "/image/trybanner.png",
                category = "Antika",
                price = 9000
            });

            _advertInfo.Add(new advertInfo
            {
                id = 8,
                title = "Yeni Sezon Kadın Deri Mont",
                desc = "Hiç kullanılmamış, etiketi üzerinde. Gerçek deri, M beden. Satın alırken beden uymadığı için satılıyor.",
                image = "/image/trybanner.png",
                category = "Giyim",
                price = 1800
            });

            _advertInfo.Add(new advertInfo
            {
                id = 13,
                title = "Yeni Başlayanlar İçin Klasik Gitar",
                desc = "Az kullanılmış, tınısı güzel bir başlangıç gitarı. Kılıfı ve pena hediyeli.",
                image = "/image/trybanner.png",
                category = "Müzik Aletleri",
                price = 1450
            });

            // Gıda İlanı
            _advertInfo.Add(new advertInfo
            {
                id = 14,
                title = "Organik Ev Yapımı Reçeller",
                desc = "Şeker ilavesiz, tamamen doğal meyvelerden yapılmış çilek, vişne ve kayısı reçelleri. Sipariş üzerine hazırlanır.",
                image = "/image/trybanner.png",
                category = "Gıda",
                price = 85
            });

        }
        public static void CreateAdvert(advertInfo advert)
        {
            _advertInfo.Add(advert);
        }
        public static advertInfo? GetById(int id)
        {
            return _advertInfo.FirstOrDefault(advert => advert.id == id);
        } 
    }
}