# BIM472-Web-Project </br>
Bu proje BIM 472 dersi için geliştirilmiş bir blog sitesidir.

+ .Net Core MVC ile geliştirilmiştir.
+ Authentication ve Authorization ile güvenlik sağlanmıştır.
+ Onion Architecture kullanılmıştır.
+ CQRS - MediatR patternleri uygulanmıştır.
+ Veritabanı olarak SqlServer kullanılmıştır. </br></br>
=> Proje Linki : https://github.com/Rivians/SamCar-BIM472 </br>

## Dağıtım </br>
Bu projeyi çalıştırmak için şu adımları uygulayabilirsiniz. </br>

Poreyi tanımlayacağınız dosya yoluna girip aşağıdaki kodu terminale yazarak klonlayabilirsiniz</br>

`https://github.com/Rivians/SamCar-BIM472.git` </br>

ardından appsettings.json file içeriği değiştirilmeli </br>

`"SqlServerOptions": {
    "SqlConnection": "Mssql Url"
    }` </br>
    
Hazır migration'lar uygulanmalı termainali açıp şu komutlar yazılmalı </br>

`dotnet ef database update` </br>

Sonra proje terminale aşağıdaki kod yazılarak ayağa kaldırılabilir. </br>

`dotnet run` </br>

## Kullanılan Teknolojiler

**İstemci:** Html, CSS   </br>
**Sunucu:** .Net Core MVC, SqlServer </br>

## Resimler </br>

![image](https://github.com/Rivians/SamCar-BIM472/assets/120320211/1ef61fc3-42be-47f0-966d-655e09eec99b)
![image](https://github.com/Rivians/SamCar-BIM472/assets/120320211/e5183b30-fc0f-4982-ae29-6056c21a9c01)
![image](https://github.com/Rivians/SamCar-BIM472/assets/120320211/20af43db-b3de-4ffb-b857-1ddb81021e41)
![image](https://github.com/Rivians/SamCar-BIM472/assets/120320211/aafbc514-874b-409e-a550-eae865451488)
![image](https://github.com/Rivians/SamCar-BIM472/assets/120320211/b7e075a5-7293-4934-b94f-41d4a6df498a)
![image](https://github.com/Rivians/SamCar-BIM472/assets/120320211/aa5c4469-b55c-47c7-8695-af325683eba7)
![image](https://github.com/Rivians/SamCar-BIM472/assets/120320211/c05ef33b-fc13-4f59-8d90-b233adbdf7c0)
![image](https://github.com/Rivians/SamCar-BIM472/assets/120320211/068ad73a-a530-47c0-b513-0d72aa436402)
![image](https://github.com/Rivians/SamCar-BIM472/assets/120320211/5174e39f-307f-4120-969b-76ea754ee7f5)
















