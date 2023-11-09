using Domain.Common;
using Domain.Customers;
using Domain.Formulas;
using Domain.Quotations;
using Domain.Supplements;
using Foodtruck.Persistence;
//using Foodtruck.Shared.Formulas;
//using Foodtruck.Shared.Supplements;

namespace Persistence
{
    public class FoodTruckDataInitializer
    {
        private readonly FoodtruckDbContext _dbContext;

        public FoodTruckDataInitializer(FoodtruckDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SeedData()
        {
            _dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();
            Seed();
        }

        private void Seed()
        {
            List<PricePerDayLine> pricePerDayLines = new List<PricePerDayLine> { new PricePerDayLine(1, new Money(350)), new PricePerDayLine(2, new Money(450)), new PricePerDayLine(3, new Money(520)) };
            var foodTruck = new Domain.Formulas.Foodtruck(50, pricePerDayLines);

            var catBier = new Category("Bier", 6);
            var catEten = new Category("Eten", 6);
            var catExtra = new Category("Extra", 21);

            var suppJup = new Supplement("Vat Jupiler", "1 Vat Jupiler van 50 L", catBier, new Money(150), 5);
            suppJup.AddImageUrl(new Uri("https://thysshop.be/321-thickbox_default/Jupiler-33-cl-Fles.jpg"));

            var suppDuvel = new Supplement("Vat Duvel", "Vat Duvel van 50 L", catBier, new Money(200), 3);
            suppDuvel.AddImageUrl(new Uri("https://www.prikentik.be/media/catalog/product/d/u/duvel_bottle_classic_be-nl-fr.jpg"));

            var suppStella = new Supplement("Vat Stella Artois", "1 Vat Stella van 50 L", catBier, new Money(190M), 7);
            suppStella.AddImageUrl(new Uri("https://goedkoopdrank.be/wp-content/uploads/2023/07/P2911.jpg"));

            var suppHamburger = new Supplement("Hamburgers", "Heerlijke rundshamburger", catEten, new Money(70), 4);
            suppHamburger.AddImageUrl(new Uri("https://www.fryskblackangus.nl/wp-content/uploads/2019/05/black-angus-steakburger-bbq-1080x675.jpg"));

            var suppRibbetjes = new Supplement("Ribbetjes", "1 hele varkensrib gemarineerd in pikante saus", catEten, new Money(10), 10);
            suppRibbetjes.AddImageUrl(new Uri("https://hunting.be/wp-content/uploads/2021/02/grilled-pork-ribs-P6RJQ79-scaled.jpg"));

            var supBbqStel = new Supplement("Bbq set", "Bbq-stel om lekker vlees op te bakken. Inclusief hout voor bbq", catExtra, new Money(50), 3);
            supBbqStel.AddImageUrl(new Uri("https://mb.fqcdn.nl/square1200ng/8676170/krumble-teflon-bakmat-rond-bbq-set-van-2.jpg"));

            var supBbqKit = new Supplement("Bbq-kit", "Barbequekit 18-delig. Alles wat je nodig hebt om je bbq te gebruiken", catExtra, new Money(20), 2);
            supBbqKit.AddImageUrl(new Uri("https://img.fruugo.com/product/4/37/575202374_max.jpg"));

            var supApertiefPlateaus = new Supplement("Aperitiefhapjes plateau", "Plateaus om je aperitiefhapjes mooi te kunnen presenteren.", catExtra, new Money(2), 35);
            supApertiefPlateaus.AddImageUrl(new Uri("https://www.elle.be/nl/wp-content/uploads/2021/12/nicola-dreyer-wlfiazldleu-unsplash-kopieren.jpg"));

            //begin
            var supDienblad = new Supplement("Plateau�s", "Plateau�s/dienblad zwart antislip (diameter 35cm).", catExtra, new Money(1.5M), 10);
            supDienblad.AddImageUrl(new Uri("https://localhost:7143/images/Dienblad.jpg"));

            var supSfeerverlichting = new Supplement("Lichtslinger", "Lichtslinger (guirlandes 10m).", catExtra, new Money(3), 8);
            supSfeerverlichting.AddImageUrl(new Uri("https://localhost:7143/images/Sfeerverlichting.jpg"));

            var supSaladette = new Supplement("Saladette", "Inclusief 5 GN bakken � + 5 deksels, diepte 150 mm", catExtra, new Money(65M), 2);
            supSaladette.AddImageUrl(new Uri("https://localhost:7143/images/Saladette.jpg"));

            var supGNBakken = new Supplement("GN bakken", "GN bakken � + 5 deksels, diepte 150 mm", catExtra, new Money(3M), 20);
            supGNBakken.AddImageUrl(new Uri("https://localhost:7143/images/GNbaken14.jpg"));

            var supGNBakken1_6 = new Supplement("GN bakken 1/6", "GN bakken 1/6  + deksel, diepte 150mm", catExtra, new Money(3M), 10);
            supGNBakken1_6.AddImageUrl(new Uri("https://localhost:7143/images/GNbakken16.jpg"));

            var supBarKoeler = new Supplement("Barkoeler", "Barkoeler 320 liter � 3x glazen schuifdeur - zwart (50cm (l) x 135cm (b) x 87cm (h)", catExtra, new Money(65M), 1);
            supBarKoeler.AddImageUrl(new Uri("https://localhost:7143/images/Barkoeler.jpg"));

            var supCocktailglasGoud = new Supplement("Cocktail glas gouden rand", "Cocktail glas met gouden rand 330ml", catExtra, new Money(0.5M), 100);
            supCocktailglasGoud.AddImageUrl(new Uri("https://localhost:7143/images/CocktailGoudenRand.jpg"));

            var supCocktailglasGewoon = new Supplement("Cocktail glas type rand", "Cocktail glas type rand 330ml", catExtra, new Money(0.2M), 100);
            supCocktailglasGewoon.AddImageUrl(new Uri("https://localhost:7143/images/CocktailRand.jpg"));

            var supCocktailglasKlein = new Supplement("Cocktailglas klein", "Cocktailglas 250ml", catExtra, new Money(0.15M), 100);
            supCocktailglasKlein.AddImageUrl(new Uri("https://localhost:7143/images/Cocktailglazen.jpg"));

            var supIjsemmer = new Supplement("Ijsemmer", "Ijsemmer 7l", catExtra, new Money(10M), 1);
            supIjsemmer.AddImageUrl(new Uri("https://localhost:7143/images/Ijsemmer.jpg"));

            var supVuurschaal = new Supplement("Vuurschaal", "Vuurschaal diameter 120cm", catExtra, new Money(40M), 1);
            supVuurschaal.AddImageUrl(new Uri("https://localhost:7143/images/Vuurschaal.jpg"));

            var supDriepoot = new Supplement("Driepoot", "Driepoot met BBQ rooster + vuurschaal", catExtra, new Money(100M), 1);
            supDriepoot.AddImageUrl(new Uri("https://localhost:7143/images/Driepoot.jpg"));

            var supDiepvries = new Supplement("Diepvries", "Diepvries 80l (60cm (l)x60cm (b) x 80cm (h))", catExtra, new Money(50M), 1);
            supDiepvries.AddImageUrl(new Uri("https://localhost:7143/images/Diepvries.jpg"));

            var supSnijplank = new Supplement("Snijplank", "Snijplanken groen (60cm x 40cm)", catExtra, new Money(4M), 3);
            supSnijplank.AddImageUrl(new Uri("https://localhost:7143/images/Snijplanken.jpg"));

            var supSpoelbak = new Supplement("Spoelbak", "Spoelbak klein type camping 100cm(b) x 50 cm(l) x 80cm(h)", catExtra, new Money(10M), 1);
            supSpoelbak.AddImageUrl(new Uri("https://localhost:7143/images/Spoelbak.jpg"));

            var supDrankenDispenser = new Supplement("Drankendispenser", "Drankendispenser", catExtra, new Money(15M), 2);
            supDrankenDispenser.AddImageUrl(new Uri("https://localhost:7143/images/Drankendispenser.jpg"));

            var supSoepketel = new Supplement("Soepketel", "Soepketel 10 liter + pollepel", catExtra, new Money(15M), 2);
            supSoepketel.AddImageUrl(new Uri("https://localhost:7143/images/Soepketel.jpg"));

            var supStrobaal = new Supplement("Strobaal", "Strobalen (80cm (l) x 45cm (b) x 45cm (h))", catExtra, new Money(4M), 10);
            supStrobaal.AddImageUrl(new Uri("https://localhost:7143/images/Strobalen.jpg"));

            var supSchapenvacht = new Supplement("Schapenvacht", "Schapenvacht ong. 100 cm x 50cm", catExtra, new Money(12M), 10);
            supSchapenvacht.AddImageUrl(new Uri("https://localhost:7143/images/Schapenvacht.jpg"));

            var supBiertafel = new Supplement("Biertafel set", "Biertafel set: 1 tafel (220cm (l) x 80cm (b) x 77cm (h) + 2 banken (220cm (l) x 25cm (b) x 48 cm (h)", catExtra, new Money(15M), 5);
            supBiertafel.AddImageUrl(new Uri("https://localhost:7143/images/Biertafel.jpg"));

            var supFruitkist = new Supplement("Fruitkist", "Fruitkisten (50cm (l) x 41cm (b) x 31cm (h)", catExtra, new Money(5M), 20);
            supFruitkist.AddImageUrl(new Uri("https://localhost:7143/images/Fruitkist.jpg"));

            var bierChoice = new FormulaSupplementChoice("Keuze bier", 3, suppJup);
            bierChoice.AddSupplementToChoose(suppJup);
            bierChoice.AddSupplementToChoose(suppDuvel);
            bierChoice.AddSupplementToChoose(suppStella);

            var etenChoice = new FormulaSupplementChoice("Keuze barbequevlees", 20, suppRibbetjes);
            etenChoice.AddSupplementToChoose(suppRibbetjes);
            etenChoice.AddSupplementToChoose(suppHamburger);



            var formulaBasic = new Formula(foodTruck, "Basis", "Enkel de foodtruck huren", new Uri("https://imageupload.io/ib/P0NNekeu9XhNflc_1698522659.jpg"));

            var formulaGoTo = new Formula(foodTruck, "Go to", "Foodtruck met vat(en) bier inclusief glazen", new Uri("https://imageupload.io/ib/nP0up1d1SE2j7qU_1698522658.jpg"));
            formulaGoTo.AddSupplemenChoice(bierChoice);
            formulaGoTo.AddIncludedSupplementLine(new FormulaSupplementLine(new SupplementItem(supApertiefPlateaus, 5)));

            var formulaAllIn = new Formula(foodTruck, "All in", "Foodtruck met vat(en) bier inclusief glazen, barbeque en barbequeset", new Uri("https://imageupload.io/ib/VIAQl8v1kWqxWCE_1698522991.jpg"));
            formulaAllIn.AddIncludedSupplementLine(new FormulaSupplementLine(new SupplementItem(supApertiefPlateaus, 5)));
            formulaAllIn.AddIncludedSupplementLine(new FormulaSupplementLine(new SupplementItem(supBbqStel, 1)));
            formulaAllIn.AddIncludedSupplementLine(new FormulaSupplementLine(new SupplementItem(supBbqKit, 1)));
            formulaAllIn.AddSupplemenChoice(bierChoice);
            formulaAllIn.AddSupplemenChoice(etenChoice);


            Customer customer1 = new Customer("Yi Long", "Ma", new EmailAddress("YiLong@yahoo.com"), "0472543891", "Tussla", "203242348932");
            Customer customer2 = new Customer("Froderick", "De Tander", new EmailAddress("Frodetender2004@skynet.com"), "0483231923");

            Quotation quotation1 = new Quotation(customer1);

            Reservation reservation = new Reservation(new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 2, 11, 0, 0).ToUniversalTime(), new DateTime(DateTime.Now.AddMonths(1).Year, DateTime.Now.AddMonths(1).Month, 4, 16, 0, 0).ToUniversalTime(), "TODO what should be in description");
            List<SupplementItem> formulaSupplementItems = formulaAllIn.Choices.Select(choice => new SupplementItem(choice.DefaultChoice, choice.MinQuantity)).ToList(); // add choices
            formulaSupplementItems.AddRange(formulaAllIn.IncludedSupplements.Select(includedSupplementLine => new SupplementItem(includedSupplementLine.Supplement, includedSupplementLine.Quantity)));
            List<SupplementItem> extraSupplements = new List<SupplementItem>() { new SupplementItem(supDrankenDispenser, 2), new SupplementItem(supStrobaal, 5), new SupplementItem(supBiertafel, 2) };
            Address eventAddress = new Address("9000", "Gent", "Sint-Denijslaan", "300"); 
            Address billingAddress = new Address("9160", "Lokeren", "Nieuwpoortstraat", "12");

            QuotationVersion quotationVersion= new QuotationVersion(1000, "Mijn feest moet super tof worden met jouw coole tapwagen", "TODO Delete description", reservation, formulaAllIn, formulaSupplementItems, extraSupplements, eventAddress, billingAddress);
            quotation1.AddVersion(quotationVersion);


            _dbContext.Foodtruck.Add(foodTruck);
            _dbContext.Supplements.AddRange(new List<Supplement>() { supDienblad, supSfeerverlichting, supSaladette, supGNBakken, supGNBakken1_6, supBarKoeler, supCocktailglasGoud, supCocktailglasGewoon, supCocktailglasKlein, supIjsemmer, supVuurschaal, supDriepoot, supDiepvries, supSnijplank, supSpoelbak, supDrankenDispenser, supSoepketel, supStrobaal, supSchapenvacht, supBiertafel, supFruitkist });
            _dbContext.Formulas.Add(formulaBasic);
            _dbContext.Formulas.Add(formulaGoTo);
            _dbContext.Formulas.Add(formulaAllIn);
            _dbContext.Quotations.Add(quotation1);


            _dbContext.SaveChanges();
        }
    }
}
