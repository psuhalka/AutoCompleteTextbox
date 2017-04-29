using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace AutoCompleteTextbox
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private const string DEFAULT_FILEPATH = @"C:\words.txt";
        private const string DEFAULT_DELIMITER = "\n";

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            string fileText = "";
            string filepath = System.Configuration.ConfigurationManager.AppSettings["filepath"];
            if (filepath == null) { filepath = DEFAULT_FILEPATH; }
            if (File.Exists(filepath))
            {
                try
                {
                    fileText = System.IO.File.ReadAllText(filepath);
                }
                catch (Exception ex)
                {
                    Application["ErrorReadingDictionary"] = ex.Message;
                }
            }
            else
            {
                Application["ErrorReadingDictionary"] = "Error Loading Dictionarysss";
            }


            string delimiter =  DEFAULT_DELIMITER;
            string[] separator = { @delimiter };
            string[] WrdArray = { };
            if (fileText.Length > 0)
            {
                WrdArray = fileText.Split(separator, System.StringSplitOptions.RemoveEmptyEntries);
            }

            Dictionary<string, List<string>> dictonary = new Dictionary<string, List<string>>();

            List<string> lsOther = new List<string>();
            List<string> lsA = new List<string>();
            List<string> lsB = new List<string>();
            List<string> lsC = new List<string>();
            List<string> lsD = new List<string>();
            List<string> lsE = new List<string>();
            List<string> lsF = new List<string>();
            List<string> lsG = new List<string>();
            List<string> lsH = new List<string>();
            List<string> lsI = new List<string>();
            List<string> lsJ = new List<string>();
            List<string> lsK = new List<string>();
            List<string> lsL = new List<string>();
            List<string> lsM = new List<string>();
            List<string> lsN = new List<string>();
            List<string> lsO = new List<string>();
            List<string> lsP = new List<string>();
            List<string> lsQ = new List<string>();
            List<string> lsR = new List<string>();
            List<string> lsS = new List<string>();
            List<string> lsT = new List<string>();
            List<string> lsU = new List<string>();
            List<string> lsV = new List<string>();
            List<string> lsW = new List<string>();
            List<string> lsX = new List<string>();
            List<string> lsY = new List<string>();
            List<string> lsZ = new List<string>();

            for (int i = 0; i < WrdArray.Length; i++)
            {
                switch (WrdArray[i].Substring(0, 1))
                {
                    case "a":
                        lsA.Add(WrdArray[i]);
                        break;
                    case "b":
                        lsB.Add(WrdArray[i]);
                        break;
                    case "c":
                        lsC.Add(WrdArray[i]);
                        break;
                    case "d":
                        lsD.Add(WrdArray[i]);
                        break;
                    case "e":
                        lsE.Add(WrdArray[i]);
                        break;
                    case "f":
                        lsF.Add(WrdArray[i]);
                        break;
                    case "g":
                        lsG.Add(WrdArray[i]);
                        break;
                    case "h":
                        lsH.Add(WrdArray[i]);
                        break;
                    case "i":
                        lsI.Add(WrdArray[i]);
                        break;
                    case "j":
                        lsJ.Add(WrdArray[i]);
                        break;
                    case "k":
                        lsK.Add(WrdArray[i]);
                        break;
                    case "l":
                        lsL.Add(WrdArray[i]);
                        break;
                    case "m":
                        lsM.Add(WrdArray[i]);
                        break;
                    case "n":
                        lsN.Add(WrdArray[i]);
                        break;
                    case "o":
                        lsO.Add(WrdArray[i]);
                        break;
                    case "p":
                        lsP.Add(WrdArray[i]);
                        break;
                    case "q":
                        lsQ.Add(WrdArray[i]);
                        break;
                    case "r":
                        lsR.Add(WrdArray[i]);
                        break;
                    case "s":
                        lsS.Add(WrdArray[i]);
                        break;
                    case "t":
                        lsT.Add(WrdArray[i]);
                        break;
                    case "u":
                        lsU.Add(WrdArray[i]);
                        break;
                    case "v":
                        lsV.Add(WrdArray[i]);
                        break;
                    case "w":
                        lsW.Add(WrdArray[i]);
                        break;
                    case "x":
                        lsX.Add(WrdArray[i]);
                        break;
                    case "y":
                        lsY.Add(WrdArray[i]);
                        break;
                    case "z":
                        lsZ.Add(WrdArray[i]);
                        break;
                    default:
                        lsOther.Add(WrdArray[i]);
                        break;
                }


            }

            dictonary["a"] = lsA;
            dictonary["b"] = lsB;
            dictonary["c"] = lsC;
            dictonary["d"] = lsD;
            dictonary["e"] = lsE;
            dictonary["f"] = lsF;
            dictonary["g"] = lsG;
            dictonary["h"] = lsH;
            dictonary["i"] = lsI;
            dictonary["j"] = lsJ;
            dictonary["k"] = lsK;
            dictonary["l"] = lsL;
            dictonary["m"] = lsM;
            dictonary["n"] = lsN;
            dictonary["o"] = lsO;
            dictonary["p"] = lsP;
            dictonary["q"] = lsQ;
            dictonary["r"] = lsR;
            dictonary["s"] = lsS;
            dictonary["t"] = lsT;
            dictonary["u"] = lsU;
            dictonary["v"] = lsV;
            dictonary["w"] = lsW;
            dictonary["x"] = lsX;
            dictonary["y"] = lsY;
            dictonary["z"] = lsZ;
            dictonary["Other"] = lsOther;


            Application["WordDictionary"] = dictonary;
        }
    }
}
