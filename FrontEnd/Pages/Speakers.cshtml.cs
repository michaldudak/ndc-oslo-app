using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ConferenceDTO;
using FrontEnd.Services;

namespace FrontEnd
{
    public class SpeakersModel : PageModel
    {
        private readonly IApiClient _apiClient;

        public SpeakersModel(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public List<SpeakerResponse> Speakers { get; set; }

        public async Task OnGetAsync()
        {
            Speakers = await _apiClient.GetSpeakersAsync();
        }
    }
}