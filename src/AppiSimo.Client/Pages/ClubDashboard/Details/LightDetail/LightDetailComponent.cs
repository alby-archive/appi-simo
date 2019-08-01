namespace AppiSimo.Client.Pages.ClubDashboard.Details.LightDetail
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using Model;

    public class LightDetailComponent : DetailBaseComponent<Light, LightViewModel>
    {
        [Parameter]
        Guid Id { get; set; }

        protected LightDetailComponent()
            : base("/club-dashboard/lights")
        {
        }
        
        protected override async Task OnParametersSetAsync()
        {
            if (Id != Guid.Empty)
            {
                var light = await Service.GetAsync(Id);
                ViewModel = new LightViewModel(light);
            }
        }
    }
}