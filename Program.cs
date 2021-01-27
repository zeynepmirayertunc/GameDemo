using GameDemo.Adapter;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerService customerService = new CustomerManager(new MernisServiceAdapter());
            customerService.Save(new Customer() {FirstName="Zeynep Miray",LastName="Ertunç",
                DateofBirth=new DateTime(1998,1,12), NationalityId="2222222222"});

            ISellService sellService = new SalesManager();
            Product product1 = new Product() { GameName="LOL",GamePrice = 100 };
            sellService.SellCampaign(new Customer() { FirstName = "Zeynep Miray" } ,new Campain()
            { CampaignName = "BlackFriday",CampaignPrice = product1.GamePrice / 2 }, new Product() {GameName=product1.GameName });

            


          



        }
    }
}
