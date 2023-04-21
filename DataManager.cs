using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.DirectoryServices;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace demo
{
    public class DataManager
    {
        public List<PartyData> GetCaseData(int CaseNo)
        {
            return TestData(CaseNo);
        }

        private List<PartyData> TestData(int CaseNo)
        {
            List<PartyData> cData = new List<PartyData>();
            cData.Add(new PartyData()
            {
                Member = "1111",
                Title = "MR.",
                GivenNames = "Benn",
                Surname = "Newton",
                DateOfBirth = "1980-01-01",
                DriversLicense = "12345",
                ResidentialStreetNo = "1",
                ResidentialStreenName = "Granth",
                ResidentialStreetType = "St",
                ResidentialSuburb = "WILSONTON",
                ResidentialState = "QLD",
                ResidentialPostCode = "4350",
                MailLine1 = "1 granth st",
                MailSuburb = "WILSONTON",
                MailState = "QLD",
                MailPostCode = "4350",
                MailCountryCode = "AU",
                OccupationLevel1 = "Teacher",
                OccupationLevel2 = "Math Teacher",
                OccupationFreeTxt = "Stuff",
                LandLinePhone = "24349805",
                MobilePhone = "0433234556"
            });
            cData.Add(new PartyData()
            {
                Member = "222",
                Title = "MR",
                GivenNames = "Ben",
                Surname = "Newton",
                DateOfBirth = "1980-01-01",
                DriversLicense = "12345",
                ResidentialStreetNo = "1",
                ResidentialStreenName = "Granth",
                ResidentialStreetType = "St",
                ResidentialSuburb = "WILSONTON",
                ResidentialState = "QLD",
                ResidentialPostCode = "4350",
                MailLine1 = "1 granth st",
                MailSuburb = "WILSONTON",
                MailState = "QLD",
                MailPostCode = "4350",
                MailCountryCode = "AU",
                OccupationLevel1 = "Teacher",
                OccupationLevel2 = "Math Teacher",
                OccupationFreeTxt = "Stuff",
                LandLinePhone = "24349805",
                MobilePhone = "0433234556"
            });
            cData.Add(new PartyData()
            {
                Member = "3333",
                Title = "MRR",
                GivenNames = "Ben1",
                Surname = "Newton",
                DateOfBirth = "1980-01-01",
                DriversLicense = "12345",
                ResidentialStreetNo = "1",
                ResidentialStreenName = "Granth",
                ResidentialStreetType = "St",
                ResidentialSuburb = "WILSONTON",
                ResidentialState = "QLD",
                ResidentialPostCode = "4350",
                MailLine1 = "1 granth st",
                MailSuburb = "WILSONTON",
                MailState = "QLD",
                MailPostCode = "4350",
                MailCountryCode = "AU",
                OccupationLevel1 = "Teacher",
                OccupationLevel2 = "Math Teacher",
                OccupationFreeTxt = "Stuff",
                LandLinePhone = "24349805",
                MobilePhone = "0433234556"
            });
            cData.Add(new PartyData()
            {
                Member = "4444",
                Title = "MR",
                GivenNames = "Benn",
                Surname = "Newton",
                DateOfBirth = "1980-01-01",
                DriversLicense = "12345",
                ResidentialStreetNo = "1",
                ResidentialStreenName = "Granth",
                ResidentialStreetType = "St",
                ResidentialSuburb = "WILSONTON",
                ResidentialState = "QLD",
                ResidentialPostCode = "4350",
                MailLine1 = "1 granth st",
                MailSuburb = "WILSONTON",
                MailState = "QLD",
                MailPostCode = "4350",
                MailCountryCode = "AU",
                OccupationLevel1 = "Teacher",
                OccupationLevel2 = "Math Teacher",
                OccupationFreeTxt = "Stuff",
                LandLinePhone = "24349805",
                MobilePhone = "0433234556"
            });
            return cData;

        }



    }

    public class PartyData
    {
        public string Member { get; set; }
        public string Title { get; set; }
        public string GivenNames { get; set; }
        public string Surname { get; set; }
        public string DateOfBirth { get; set; }
        public string DriversLicense { get; set; }
        public string ResidentialStreetNo { get; set; }
        public string ResidentialStreenName { get; set; }
        public string ResidentialStreetType { get; set; }
        public string ResidentialSuburb { get; set; }
        public string ResidentialState { get; set; }
        public string ResidentialPostCode { get; set; }
        public string MailLine1 { get; set; }
        public string MailSuburb { get; set; }
        public string MailState { get; set; }
        public string MailPostCode { get; set; }
        public string MailCountryCode { get; set; }
        public string OccupationLevel1 { get; set; }
        public string OccupationLevel2 { get; set; }
        public string OccupationFreeTxt { get; set; }
        public string LandLinePhone { get; set; }
        public string MobilePhone { get; set; }

    }

    //https://www.colorhexa.com/
    public static class ColourPallet
    {
        public static string[] TextDifferenceColourHex = { "#fdd58b", "#e0eb7f" , "#dcd9cb" , "#edece5", "#ffebeb" };
        public static string NoDiscrepancyColourHex = "#ffffff";

    }

    public static class MappingTools
    {
        public static List<PartyData> AddFormattingInfo(List<PartyData> CaseData)
        {

            List<PartyData> TransformedCaseData = new List<PartyData>();

            Dictionary<string, string> TitleColourDic = new Dictionary<string, string>();
            Dictionary<string, string> GivenNameColourDic = new Dictionary<string, string>();
            Dictionary<string, string> SurnameColourDic = new Dictionary<string, string>();
            Dictionary<string, string> DateOfBirthColourDic = new Dictionary<string, string>();
            Dictionary<string, string> DriversLicenseColourDic = new Dictionary<string, string>();
            Dictionary<string, string> ResidentialStreetNoColourDic = new Dictionary<string, string>();
            Dictionary<string, string> ResidentialStreenNameColourDic = new Dictionary<string, string>();
            Dictionary<string, string> ResidentialStreetTypeColourDic = new Dictionary<string, string>();
            Dictionary<string, string> ResidentialSuburbColourDic = new Dictionary<string, string>();
            Dictionary<string, string> ResidentialStateColourDic = new Dictionary<string, string>();
            Dictionary<string, string> ResidentialPostCodeColourDic = new Dictionary<string, string>();
            Dictionary<string, string> MailLine1ColourDic = new Dictionary<string, string>();
            Dictionary<string, string> MailSuburbColourDic = new Dictionary<string, string>();
            Dictionary<string, string> MailStateColourDic = new Dictionary<string, string>();
            Dictionary<string, string> MailPostCodeColourDic = new Dictionary<string, string>();
            Dictionary<string, string> MailCountryCodeColourDic = new Dictionary<string, string>();
            Dictionary<string, string> OccupationLevel1ColourDic = new Dictionary<string, string>();
            Dictionary<string, string> OccupationLevel2ColourDic = new Dictionary<string, string>();
            Dictionary<string, string> OccupationFreeTxtColourDic = new Dictionary<string, string>();
            Dictionary<string, string> LandLinePhoneColourDic = new Dictionary<string, string>();
            Dictionary<string, string> MobilePhoneColourDic = new Dictionary<string, string>();

            int ColourCounter = 0;
            foreach (PartyData Party in CaseData)
            {
                // Check counter is not out of range
                if (ColourPallet.TextDifferenceColourHex.Length < ColourCounter)
                {
                    ColourCounter = 0;
                }

                if (!TitleColourDic.ContainsKey(Party.Title)) { TitleColourDic[Party.Title] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!GivenNameColourDic.ContainsKey(Party.GivenNames)){GivenNameColourDic[Party.GivenNames] = ColourPallet.TextDifferenceColourHex[ColourCounter];}
                if (!SurnameColourDic.ContainsKey(Party.Surname)) { SurnameColourDic[Party.Surname] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!DateOfBirthColourDic.ContainsKey(Party.DateOfBirth)) { DateOfBirthColourDic[Party.DateOfBirth] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!DriversLicenseColourDic.ContainsKey(Party.DriversLicense)) { DriversLicenseColourDic[Party.DriversLicense] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!ResidentialStreetNoColourDic.ContainsKey(Party.ResidentialStreetNo)) { ResidentialStreetNoColourDic[Party.ResidentialStreetNo] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!ResidentialStreenNameColourDic.ContainsKey(Party.ResidentialStreenName)) { ResidentialStreenNameColourDic[Party.ResidentialStreenName] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!ResidentialStreetTypeColourDic.ContainsKey(Party.ResidentialStreetType)) { ResidentialStreetTypeColourDic[Party.ResidentialStreetType] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!ResidentialSuburbColourDic.ContainsKey(Party.ResidentialSuburb)) { ResidentialSuburbColourDic[Party.ResidentialSuburb] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!ResidentialStateColourDic.ContainsKey(Party.ResidentialState)) { ResidentialStateColourDic[Party.ResidentialState] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!ResidentialPostCodeColourDic.ContainsKey(Party.ResidentialPostCode)) { ResidentialPostCodeColourDic[Party.ResidentialPostCode] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!MailLine1ColourDic.ContainsKey(Party.MailLine1)) { MailLine1ColourDic[Party.MailLine1] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!MailSuburbColourDic.ContainsKey(Party.MailSuburb)) { MailSuburbColourDic[Party.MailSuburb] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!MailStateColourDic.ContainsKey(Party.MailState)) { MailStateColourDic[Party.MailState] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!MailPostCodeColourDic.ContainsKey(Party.MailPostCode)) { MailPostCodeColourDic[Party.MailPostCode] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!MailCountryCodeColourDic.ContainsKey(Party.MailCountryCode)) { MailCountryCodeColourDic[Party.MailCountryCode] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!OccupationLevel1ColourDic.ContainsKey(Party.OccupationLevel1)) { OccupationLevel1ColourDic[Party.OccupationLevel1] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!OccupationLevel2ColourDic.ContainsKey(Party.OccupationLevel2)) { OccupationLevel2ColourDic[Party.OccupationLevel2] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!OccupationFreeTxtColourDic.ContainsKey(Party.OccupationFreeTxt)) { OccupationFreeTxtColourDic[Party.OccupationFreeTxt] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!LandLinePhoneColourDic.ContainsKey(Party.LandLinePhone)) { LandLinePhoneColourDic[Party.LandLinePhone] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }
                if (!MobilePhoneColourDic.ContainsKey(Party.MobilePhone)) { MobilePhoneColourDic[Party.MobilePhone] = ColourPallet.TextDifferenceColourHex[ColourCounter]; }

                Party.Title = TitleColourDic[Party.Title] + "_" + Party.Title;
                Party.GivenNames = GivenNameColourDic[Party.GivenNames] + "_" + Party.GivenNames;
                Party.Surname = SurnameColourDic[Party.Surname] + "_" + Party.Surname;
                Party.DateOfBirth = DateOfBirthColourDic[Party.DateOfBirth] + "_" + Party.DateOfBirth;
                Party.DriversLicense = DriversLicenseColourDic[Party.DriversLicense] + "_" + Party.DriversLicense;
                Party.ResidentialStreetNo = ResidentialStreetNoColourDic[Party.ResidentialStreetNo] + "_" + Party.ResidentialStreetNo;
                Party.ResidentialStreenName = ResidentialStreenNameColourDic[Party.ResidentialStreenName] + "_" + Party.ResidentialStreenName;
                Party.ResidentialStreetType = ResidentialStreetTypeColourDic[Party.ResidentialStreetType] + "_" + Party.ResidentialStreetType;
                Party.ResidentialSuburb = ResidentialSuburbColourDic[Party.ResidentialSuburb] + "_" + Party.ResidentialSuburb;
                Party.ResidentialState = ResidentialStateColourDic[Party.ResidentialState] + "_" + Party.ResidentialState;
                Party.ResidentialPostCode = ResidentialPostCodeColourDic[Party.ResidentialPostCode] + "_" + Party.ResidentialPostCode;
                Party.MailLine1 = MailLine1ColourDic[Party.MailLine1] + "_" + Party.MailLine1;
                Party.MailSuburb = MailSuburbColourDic[Party.MailSuburb] + "_" + Party.MailSuburb;
                Party.MailState = MailStateColourDic[Party.MailState] + "_" + Party.MailState;
                Party.MailPostCode = MailPostCodeColourDic[Party.MailPostCode] + "_" + Party.MailPostCode;
                Party.MailCountryCode = MailCountryCodeColourDic[Party.MailCountryCode] + "_" + Party.MailCountryCode;
                Party.OccupationLevel1 = OccupationLevel1ColourDic[Party.OccupationLevel1] + "_" + Party.OccupationLevel1;
                Party.OccupationLevel2 = OccupationLevel2ColourDic[Party.OccupationLevel2] + "_" + Party.OccupationLevel2;
                Party.OccupationFreeTxt = OccupationFreeTxtColourDic[Party.OccupationFreeTxt] + "_" + Party.OccupationFreeTxt;
                Party.LandLinePhone = LandLinePhoneColourDic[Party.LandLinePhone] + "_" + Party.LandLinePhone;
                Party.MobilePhone = MobilePhoneColourDic[Party.MobilePhone] + "_" + Party.MobilePhone;

                ColourCounter += 1;
                TransformedCaseData.Add(Party);
            }
            return TransformedCaseData;
        }

    }

}
