
using CPT.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Serialization;
using Xml2CSharp;

namespace CPT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<CPTViewModel> masjids = new List<CPTViewModel>();

            using (var client = new WebClient())
            {
                var xml = client.DownloadString("https://spreadsheets.google.com/feeds/list/19fG8cRpaZO7iPH40O0c9s4-ftaks8NHSEpXIgFvELsc/od6/public/values");
                var serializer = new XmlSerializer(typeof(Feed));
                Feed cptgsheet = new Feed();

                using (var reader = new StringReader(xml))
                {
                    cptgsheet = (Feed)serializer.Deserialize(reader);
                    int ndx = 0;
                    foreach(var masjid in cptgsheet.Entry)
                    {
                        CPTViewModel tempMasjid = new CPTViewModel();
                        tempMasjid.Index = ndx;
                        tempMasjid.Name = masjid.Masjid;
                        tempMasjid.Address = masjid.Address;
                        tempMasjid.Fajr = masjid.Fajr;
                        tempMasjid.Zuhr = masjid.Zuhr;
                        tempMasjid.Asr = masjid.Asr;
                        tempMasjid.Maghrib = masjid.Maghrib;
                        tempMasjid.Isha = masjid.Isha;
                        tempMasjid.Jummah = masjid.Jummah;
                        tempMasjid.Jummah2 = masjid.Jummah2;

                        masjids.Add(tempMasjid);
                    }
                }
                

                
            }
            return View(masjids);
        }

        
    }
}