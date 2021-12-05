using ApplicationCore.BusinessLayer;
using ApplicationCore.Infrastructure;
using System;

namespace ConsoleApp
{
    class Program
    {
    

        static void Main(string[] args)
        {
            try
            {
                LogWriter.LogWrite("Promotion Engine is initialized : ");

                Facade facade = new Facade();


                facade.CheckoutProducts();

                facade.ApplyPromotion();

                facade.DisplayTotalPrice(); 

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite("Exception in Promotion Engine .... : " + ex.Message);
            }
        }
    }
    }

