namespace PetShelter.ViewModels
{
    public class LocationDetailsVM : BaseVm
    {
        public string City { get; set; }

        public string Address {  get; set; }

        public string Country { get; set; }    

        public int? ShelterId { get; set; }
    }
}
