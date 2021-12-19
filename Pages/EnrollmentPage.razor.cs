using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class EnrollmentPage
    {
        [Parameter]
        public string id { get; set; }

        [Inject]
        public IEnrollmentService EnrollmentService { get; set; }
        public List<Enrollment> Enrollment { get; set; } = new List<Enrollment>();

        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Enrollment = (await EnrollmentService.GetById(int.Parse(id))).ToList();
        }
    }
}