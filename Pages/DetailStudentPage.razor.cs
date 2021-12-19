using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class DetailStudentPage
    {
        [Parameter]
        public string Id { get; set;}
        public Student Student { get; set; } = new Student();
        [Inject]
        public IStudentService StudentService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Student = await StudentService.GetById(Id);
        }
    }
}