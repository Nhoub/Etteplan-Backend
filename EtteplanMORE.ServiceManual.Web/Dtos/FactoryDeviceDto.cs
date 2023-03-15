namespace EtteplanMORE.ServiceManual.ApplicationCore.Entities
{
    public class FactoryDeviceDto
    {
        //ViewModel 
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public string? Type { get; set; }
        //Mapper , in controller dit gebruiken
    }
}