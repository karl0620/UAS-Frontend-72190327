using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class DeleteStudent
    {
        [Parameter]
        public string Id{ get; set; }

        [Inject]
        public IStudentService StudentService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await StudentService.Delete(Id);
            NavigationManager.NavigateTo("/studentpage");
        }
    }
}