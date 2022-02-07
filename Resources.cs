
namespace Company
{
    public class Resources
    {
        public decimal NightHours { get; set; }
        public decimal DayHours { get; set; }
        public int EmployeeNumber { get; set; }

        public decimal DayHoursCost { get; set; }
        public decimal NightHoursCost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal HourCost { get; set; }

        public const decimal HourCostN = 2;

        public Resources()
        {
            

        }

        public void Calcul()
        {
            CompanyConfig companyConfig = new CompanyConfig();
            companyConfig = companyConfig.Load(companyConfig); // copiere obiect serializat in obiect
            HourCost = companyConfig.HourCost;
            DayHoursCost = DayHours * HourCost;
            NightHoursCost = NightHours * (HourCost * HourCostN);
            TotalCost = DayHoursCost + NightHoursCost;

        }

    }
}
