using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sanat.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Soyut", Description="Soyut Eserler"},
                new Category(){ Name = "Natürmort", Description="Natürmort Eserler"},
                new Category(){ Name = "Figüratif", Description="Figüratif Eserler"},
                new Category(){ Name = "Nü", Description="Nü Eserler"},
                new Category(){ Name = "Portre", Description="Portre Eserler"},
            };
            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name = "Militia Company", Description = "Leonardo Da Vinci – 1452-1519 – İTALYA Mona-Lisa 1503-1506 yılları arasında yapılan Mona Lisa’nın yüzündeki hem mutlu hem de hüzünlü ifadenin sırrı, bugün bile tam anlamıyla çözülebilmiş değil. Portrede oturur halde görünen Lisa Gherardini sfumoto tekniğiyle (renk ve tonlar arasında yumuşak geçişleri sağlayan gölgeleme yöntemi) resmedilmiştir. Bu tekniği ilk kez da Vinci kullanmıştır", Price =500000 , Stock =1 , IsApproved = true, CategoryId =5, IsHome=true,Image="1.jpg" },
                new Product(){ Name = "Deneme1", Description = "Sanatçının bu resmi tarihi açıdan da bir ilk olma özelliğine sahip. Bu tablo, evlenme anının resmedilmesi nedeniyle, bir nevi ‘evlilik cüzdanı’ niteliğinde. Eseri bu kadar önemli kılan detay ise ayna. Duvardaki ayna, müthiş bir akis tekniğiyle anı derinleştirmek için kullanılmış. Aynaya dikkatlice bakıldığında, Van Eyck’ın da resmin içinde olduğu görülür. Ressam, kendini ‘an’a dâhil ederek, resim sanatına farklı bir boyut kazandırdı.", Price =500000 , Stock =1 , IsApproved = true, CategoryId =1 ,Image="2.jpg" },
                new Product(){ Name = "Deneme2", Description = "Sanatçı bu eserinde bütün kuralları yıkarcasına resmettiği çıplak insanların keyifli anlarını, fantastik bir öykü içinde verir. Tabloda, bir yanda dünya nimetlerinden zevk alan insanlar, diğer yanda günahları yüzünden cezalandırılanlar dikkat çeker. Tablo aynı zamanda Orta Çağ insanında hakim olan karabasan ve ölüm düşüncesine de vurgu yapmaktadır.", Price =10000 , Stock =1 , IsApproved = false, CategoryId =4, IsHome=true ,Image="3.jpg" },
                new Product(){ Name = "Deneme3", Description = "Sanatçı 1485’te yaptığı ‘Venüs’ün Doğuşu’ adlı eseriyle, kariyerinde üst basamaklara tırmanmıştır. Yapıtta, tanrıça Venüs’ün bir deniz kabuğundan doğduğu ve çıplak güzelliğiyle etrafındakileri büyülediği an resmedilir. Botticelli’nin Venüs tasviri, diğer sanatçılardan farklı olarak biraz erotiktir. Göğsünü ve cinsel organını tam kapatamamış olması dikkat çekicidir. Bu kapatma biçimi sonra birçok heykeltraş tarafından taklit edildi. Sanatçının diğer eserlerinden bazılarının yakıldığı, ancak yasak olmasına rağmen pagan etkisi taşıdığı açıkça görülen bu eserine dokunulmadığı bilinir.", Price =2000 , Stock =1 , IsApproved = true, CategoryId =3 ,Image="4.jpg" },
                new Product(){ Name = "Deneme4", Description = "Leonardo Da Vinci – 1452-1519 – İTALYA Mona-Lisa1503-1506 yılları arasında yapılan Mona Lisa’nın yüzündeki hem mutlu hem de hüzünlü ifadenin sırrı, bugün bile tam anlamıyla çözülebilmiş değil. Portrede oturur halde görünen Lisa Gherardini sfumoto tekniğiyle (renk ve tonlar arasında yumuşak geçişleri sağlayan gölgeleme yöntemi) resmedilmiştir. Bu tekniği ilk kez da Vinci kullanmıştır.", Price =60000 , Stock =1 , IsApproved = false, CategoryId =1, IsHome=true,Image="1.jpg"  },
                new Product(){ Name = "Deneme5", Description = "  ", Price =9000 , Stock =1 , IsApproved = true, CategoryId =2, IsHome=true ,Image="2.jpg" },
                new Product(){ Name = "Deneme6", Description = "  ", Price =80 , Stock =1 , IsApproved = false, CategoryId =3, IsHome=true ,Image="3.jpg" },
                new Product(){ Name = "Deneme7", Description = "  ", Price =300 , Stock =1 , IsApproved = true, CategoryId =4, IsHome=true ,Image="4.jpg" },

               
              
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}