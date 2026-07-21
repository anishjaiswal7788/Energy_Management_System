using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EmsDashboard.Controllers
{
    public class DashboardController : Controller
    {
        // IMPORTANT: Replace '7195' with the actual port your EmsApi runs on!
        private readonly string apiUrl = "http://192.168.137.1:8081/EMS_API/api/Ems/";

        public async Task<ActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);

                try
                {

                    // Fetch data from your API
                    var dailyResponse = await client.GetAsync("daily");
                    var monthlyResponse = await client.GetAsync("monthly");
                    var masterViewResponse = await client.GetAsync("masterview");

                    // Ensure the API calls were successful
                    dailyResponse.EnsureSuccessStatusCode();
                    monthlyResponse.EnsureSuccessStatusCode();
                    masterViewResponse.EnsureSuccessStatusCode();

                    // Read the raw JSON strings
                    string dailyJson = await dailyResponse.Content.ReadAsStringAsync();
                    string monthlyJson = await monthlyResponse.Content.ReadAsStringAsync();
                    string masterViewJson = await masterViewResponse.Content.ReadAsStringAsync();

                    // Pass the raw JSON directly to the View so JavaScript can parse it for Chart.js
                    ViewBag.DailyData = dailyJson;
                    ViewBag.MonthlyData = monthlyJson;
                    ViewBag.MasterViewData = masterViewJson;
                }
                catch (Exception ex)
                {
                    // If the API is off or unreachable, pass empty arrays to prevent a crash
                    ViewBag.DailyData = "[]";
                    ViewBag.MonthlyData = "[]";
                    ViewBag.MasterViewData = "[]";
                    ViewBag.Error = "Could not connect to API: " + ex.Message;
                }

                return View();
            }
        }
    }
}