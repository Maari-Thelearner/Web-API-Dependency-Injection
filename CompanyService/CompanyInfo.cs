namespace CompanyService
{
    public class CompanyInfo : ICompanyInfoForScoped, ICompanyInfoForSingleton, ICompanyInfoForTransient
    {
        public string CompanyName { get; set; }
        public string Place { get; set; }
        public string ContactNumber { get; set; }

        public int CompanyRefNo { get; set; }


        public CompanyInfo()
        {
            CompanyName = "Darkpixls Entertainment";
            Place = "Kovilpatti, Tamilnadu, India";
            ContactNumber = "(+91) 908 080 5773";
            var random = new Random();
            CompanyRefNo = random .Next(1, 100);
        }

        public int GetNumber()
        {
            return CompanyRefNo;
        }
        
    }
}