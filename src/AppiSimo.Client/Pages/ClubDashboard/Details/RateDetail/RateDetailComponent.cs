using System;
using System.Threading.Tasks;
using AppiSimo.Client.Abstract;
using AppiSimo.Client.Model;
using Microsoft.AspNetCore.Components;
using NodaTime;

namespace AppiSimo.Client.Pages.ClubDashboard.Details.RateDetail
{
    public class RateDetailComponent : DetailBaseComponent<Rate, RateViewModel>
    {
        protected RateDetailComponent()
            : base("/club-dashboard/rates")
        {
        }

        [Inject] protected ITypeConverter<LocalTime?> Converter { get; set; }

        [Parameter] Guid Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            if (Id != Guid.Empty)
            {
                var rate = await Service.GetAsync(Id);
                ViewModel = new RateViewModel(rate);   
            }
        }

        protected void Add() => ViewModel.AddDailyRate();

        protected void Remove(Guid id)
        {
            ViewModel.RemoveDailyRate(id);
            StateHasChanged();
        }
    }
}