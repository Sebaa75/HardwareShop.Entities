using HardwareShop.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareShop
{
    public class HSDbInitializer : CreateDatabaseIfNotExists<HSDbContext>
    {
        protected override void Seed(HSDbContext context)
        {
            context.Customers.AddOrUpdate(x => x.Id,
            new Entities.Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Karol",
                LastName = "Kowalski",
                Email = "karol.kow@gmail.com"
            },
            new Entities.Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Maciek",
                LastName = "Nowarski",
                Email = "maciek.nowa@gmail.com"
            },
            new Entities.Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Marta",
                LastName = "Sora",
                Email = "marta.sor@gmail.com"
            });
            context.OrderStatuses.AddOrUpdate(x => x.Name,
            new Entities.OrderStatus() { Name = "Nowy" },
            new Entities.OrderStatus() { Name = "W trakcie realizacji" },
            new Entities.OrderStatus() { Name = "Dostarczony" },
            new Entities.OrderStatus() { Name = "Zrealizowany" }
            );
            context.Products.AddOrUpdate(x => x.Name,
            new Entities.Product()
            {
                Name = "Dell Inspiron 5570",
                Type = "Laptop",
                Description ="Twój nowy komputer powinien pozostać Twoim ulubionym przez wiele lat. Dlatego firma Dell przetestowała niezawodność działania każdego notebooka Inspiron nie tylko w typowych miejscach, ale też w bardziej wymagającym otoczeniu." },
            new Entities.Product()
            {
                Name = "MSI GP72MVR",
                Type = "Laptop",
                Description = "Stwórz idealne środowisko do mocnego gamingu i przyjemnej rozrywki multimedialnej.Matrix Display wspiera 2 zewnętrzne monitory, mogące pracować jednocześnie z ekranem notebooka.Dzięki temu rozszerzysz obraz w grze i zwiększysz pole widzenia,              co przełoży się na o wiele lepsze wrażenia podczas rozgrywki." },
            new Entities.Product()
            {
                Name = "iiyama X2483HSU",
                Type = "Monitor",
                Description = "ProLite X2483HSU-B2 to 24-calowy monitor FullHD (1920x1080 pikseli) z podświetlaniem LED wyposażony w matrycę AMVA oferującą doskonałe odwzorowanie kolorów (24 - bit True Colour).Wyjątkowo szerokie kąty widzenia - 178 stopni w pionie i w poziomie oraz bardzo wysokie współczynniki kontrastu 3000:1(kontrast typowy) i 12 000000 : 1(kontrast dynamiczny ACR) w połączeniu z szybkim, czasem reakcji i wysoką jasnością zapewniają mu znakomitą wydajność w takich zastosowaniach jak fotografia i obróbka graficzna." },
            new Entities.Product()
            {
                Name = "TP-Link Neffos X1",
                Type =
            "Smartphone",
                Description = "Szary TP-Link Neffos X1 Lite wyróżnia się wyjątkowo lekką i dopracowaną konstrukcją.Smukły profil ułatwia obsługę jedną ręką a profilowane szkło ekranu 5 nadaje smartfonowi eleganckiego wyglądu.Neffos X1 Lite zachwyci Ci również szybkością działania, doskonałym aparatem 13 Mpix oraz wielofunkcyjnym czytnikiem linii papilarnych." },
            new Entities.Product()
            {
                Name = "Navman 5000",
                Type = "GPS",
                Description = "Navman 5000 LM oferuje bezterminową aktualizację map, tak abyś niięcej nie musiał martwić się o nowe drogi i mapy.Nowe nowe adresy ? Navma 5000 LM poprowadzi Cię do celu." },
        new Entities.Product()
        {
            Name = "Microsoft Xbox One S 500GB",
            Type =
        "Konsola",
            Description = "estaw Xbox One S Forza Horizon 3 Hot Wheels (500GB) z pełną wersją ulubionej przez graczy gry wyścigowej Forza Horizon 3 wraz z najlepiej sprzedającym się dodatkiem Hot Wheels oraz bezprzewodowym kontrolerem Xbox.Prowadź ponad 350 modeli najlepszych aut,  odkrywaj tereny Australii oraz ścigaj się z innymi
        graczami.Poznaj najlepiej ocenianą i najlepiej sprzedającą się serię gier tej
        generacji12 na jedynej konsoli z odtwarzaczem Blu - ray 4K,
            przesyłaniem strumieniowym w
        jakości 4K oraz technologią High Dynamic Range." },
        new Entities.Product()
        {
            Name = "Creative Live! Cam Sync HD",
            Type =
        "Kamery",
            Description = "unkcja „Plug & Chat” pozwala na prowadzenie rozmów bez
        konieczności instalacji programów z płyty CD.Nagrywaj i udostępniaj wideo w
        rozdzielczości HD 720p w serwisach Facebook i YouTube dzięki oprogramowaniu Live!
        Central 3 Lite" }
);
        }
    }
}
