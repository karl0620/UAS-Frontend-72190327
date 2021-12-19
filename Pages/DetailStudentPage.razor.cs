using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class DetailStudentPage
    {
        [Parameter]
        public string id { get; set;}
        public Student Student { get; set; } = new Student();
        [Inject]
        public IStudentService StudentService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Student = await StudentService.GetById(id);
        }
    }
}