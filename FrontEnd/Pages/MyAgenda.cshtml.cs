using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using FrontEnd.Services;
using ConferenceDTO;

namespace FrontEnd.Pages
{
	public class MyAgendaModel : IndexModel
	{
		public MyAgendaModel(IApiClient apiClient) : base(apiClient)
		{

		}

		protected override async Task<List<SessionResponse>> GetSessionsAsync()
        {
            return await _apiClient.GetSessionsByAttendeeAsync(User.Identity.Name);
        }
	}
}