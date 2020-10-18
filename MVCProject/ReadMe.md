# MVC ECommerce Project

## Proje Hakkýnda
Öncelikle projemize katmanlarý ekliyoruz. Her bir katman Class Library (.Net Framework)
(Class Library içerisinde varsayýlan olarak oluþturulan classlarý silin.)


## Katmanlar
- CORE
- MODEL
- SERVICE
- UI (MVC)
	
----------------
- API

Katmanlarý oluþturduktan sonra birbirleriyle haberleþmeleri için referans vermeliyiz.

## Reference

- Core katmaný referanslarý
	- EntityFramework

- Model katmaný referanslarý
	- EntityFramework
	-MVCProject.Core

- Service katmaný referanslarý
	- EntityFramework
- UI(MVC) katmaný referanslarý
	- EntityFramework

## Katmanlarýn Görevleri

Çok katmanlý (NTier) mimari yapýlarda her bir katmanýn kendine ait bir görevi bulunmaktadýr. Bu görevler tanýmlanan katmanlarýn çalýþma sistemini belirler. Oluþturulan projede yer alan katmanlar tek baþlarýna bir anlam ifade etmezler ancak tamamý birbirleriyle haberleþerek bir projenin bütününü oluþtururlar.

### Core Katmaný

Bu katman Interface,abstract gibi yapýlarý saklayan katmandýr.

### Model Katmaný

Projemizdeki veritabanýný temsil eden katmandýr. Veritabaný mapping iþlemleri gibi yapýlar bu katmanda tanýmlanýr.

### Service Katmaný

Sunum katmanýný (UI/MVC) hizmet etmek için hazýrlanan ve çalýþtýrýlacak olan kodlar bu katmanda yer alýr. Aslýnda hizmet katmaný olarak ta adlandýrýlmaktadýr.

### UI (Sunum) Katmaný

kullanýcý ile doðrudan iletiþime geçecek olan katmandýr.

## Core Katmaný Yapýlandýrýlmasý

- Bu kütüphane içerisine CoreEntity, Map ve Service klasörlerini oluþturuyoruz. Bu klasörler her bir katmanda olmasý gereken kurallarý içermelidir.

- Entity içerisine Enums klasörü oluþturuyoruz. Projede kullanýlacak sabitler (Enums) bu klasörde yeralacak.

- CoreEntity klasörü içerisinde IEntity isminde bir interface oluþturuldu. Ýçerisinde sadece Id bulunmakta. Oluþturulan bu interface farklý bir class'a (EntityRepository) miras vererek içerisinde her bir entity'de olmasý gereken ID property'snin kuralýný oluþturmaktadýr.

- Map klasörü içerisine CoreMap classýný oluþturuyoruz. Bu sýnýf bizim çekirdek sýnýfýmýzdaki yapýlarýmýzýn map edilmesi için kullanýlmaktadýr.

- service classý içerisine dýþarýda kullanýlacak/tanýmlanacak eylemleri içerir.

## Model Katmaný Yapýlandýrýlmasý

- Model kütüphanesi içerisine Entities,Map ve Context isimlerinde 3 farklý klasör oluþturuldu.

- Entities Klasörü içerisine aþaðýdaki classlar tanýmlandý.;
	- AppUser
	- AppUserRole
	- Category
	- Order
	- OrderDetails
	- Product
	- SubCategory

- Map isimli klasör içerisine tüm entitylerin mapleme iþlemleri gerçekleþtirildi.
	- AppUserMap
	- AppUserRoleMap
	- CategoryMap
	- OrderMap
	- OrderDetailsMap
	- ProductMap
	- SubCategoryMap

- AppDbContext (/Context) içerisinde yukarýda tanýmlanan entitylert dbset içerisine alýnarak veritbanýnda tablo haline getirildi.

- OnModelCreating isimli metot ezilerek (override) Map klasörü içerisinde tanýmlanan classlarýn instance (örnek)'larý  alýndý.
