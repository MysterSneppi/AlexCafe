using MainProject.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace MainProject.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel() 
        {
           List<ListOfProducts> listOfProducts = new List<ListOfProducts>();

            for (int i = 0;i<5;i++) 
            {
                ListOfProducts list = new ListOfProducts($"Product{i}",i+100,i);
                listOfProducts.Add(list);
            }

            FullData data = new FullData();
            data.DepositedSum = 200.0;
            data.TimeOfPurchase = "12:00";
            data.MethodOfpayment = false;
            data.ListOfProducts = listOfProducts;
            
            
            string json = JsonConvert.SerializeObject(data);

            Encoding encoding = Encoding.UTF8;
            File.WriteAllText("C:\\Git\\Vivaldi\\json.txt",json,encoding);


        }   
         
         
        
        


    }
}
