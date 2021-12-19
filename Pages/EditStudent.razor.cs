

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class EditStudent
    {
        public Student Student { get; set; } = new Student();

        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string Id{ get; set; }

        protected override async Task OnInitializedAsync()
        {
            Student = await StudentService.GetById(Id);
        }

        protected async Task HandleValidSubmit(){
            Student results = await StudentService.Update(Student);
            NavigationManager.NavigateTo("/studentpage");
        }
    }
}