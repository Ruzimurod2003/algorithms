using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

public class Program
{
    public static void Main(string[] args)
    {
        string kryptoNames = "BTC,ETH,USDT,USDC,BNB,BUSD,XRP,ADA,SOL,DOGE,DAI,DOT,TRX,SHIB,AVAX,MATIC,LEO,WBTC,UNI,LTC";
        List<string> kryptoList = kryptoNames.Split(",").ToList();string data = "";
        foreach (var item in kryptoList)
        {
            data = "else if (name == \"BTC\")\r\n                    {\r\n                        result = await Get_BTC_Currency(crypto_rates);\r\n                    }";
            using (StreamWriter w = File.AppendText("c:/myFile.txt"))
            {
                string newdata = data.Replace("BTC", item);
                w.WriteLine(newdata);
            }
        }
    }
}