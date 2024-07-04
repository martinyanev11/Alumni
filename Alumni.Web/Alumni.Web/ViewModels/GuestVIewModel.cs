namespace Alumni.Web.ViewModels
{
    public class GuestViewModel
    {
        public IEnumerable<NewsViewModel> News { get; set; }
        public IEnumerable<EventViewModel> Events { get; set; }
    }
}