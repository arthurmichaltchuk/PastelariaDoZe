using PastelariaDoZe.Infra.ExtensionMethods.Linguagem.Idiomas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastelariaDoZe.Infra.ExtensionMethods.Linguagem
{
    public static class GeneralConfig
    {
        public static string Language = "es-ES";

        //public static Dictionary<string, Color> Settings;

        public static Dictionary<string, string> Data = new Dictionary<string, string>()
        {
            {"Employees",""}
            ,{"Employee",""}
            ,{"Login",""}
            ,{"Password",""}
            ,{"User",""}
            ,{"Users",""}
            ,{"Configuration",""}
            ,{"Language",""}
            ,{"Save",""}
            ,{"Cancel",""}
            ,{@"AreYouSureThatYouWantToCancel?",""}
            ,{"Home",""}//
            ,{"Products",""}
            ,{"Product",""}
            ,{"Customers",""}
            ,{"Customer",""}
            ,{"Sells",""}
            ,{"Sell",""}
            ,{"Orders",""}
            ,{"Order",""}
            ,{"Debits",""}
            ,{"Debit",""}
            ,{"Welcome",""}
            ,{"Name",""}
            ,{"Identify Document",""}
            ,{"Phone Number",""}
            ,{"Registration",""}
            ,{"Acess user",""}
            ,{"Permissions",""}
            ,{"Admin",""}
            ,{"Cashier",""}
            ,{"Add new",""}
            ,{"Register",""}
            ,{"Update",""}
            ,{"Remove",""}
            ,{"Are you sure that you want to remove",""}
            //,{"",""}
        };

        public static void SetLanguageData()
        {
            Language = GetLinguagem();

            switch (Language)
            {
                case "en-EN":
                    foreach (var key in Data)
                    {
                        Data[key.Key] = configEn.ResourceManager.GetString(key.Key, configEn.resourceCulture);
                    }
                    break;
                case "pt-BR":
                    foreach (var key in Data)
                    {
                        Data[key.Key] = configPt.ResourceManager.GetString(key.Key, configPt.resourceCulture);
                    }
                    break;
                case "es-ES":
                    foreach (var key in Data)
                    {
                        Data[key.Key] = configEs.ResourceManager.GetString(key.Key, configEs.resourceCulture);
                    }
                    break;
            }
        }

        public static string GetLinguagem()
        {
            string? auxIdiomaRegiao = (ConfigurationManager.AppSettings.Get("IdiomaRegiao") is not null) ?
            ConfigurationManager.AppSettings.Get("IdiomaRegiao") : "";

            return auxIdiomaRegiao;
        }

    }
}