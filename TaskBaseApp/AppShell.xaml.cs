using TaskBaseApp.Views;

namespace TaskBaseApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("TaskDetailsPage",typeof(TaskDetailsPage));
		}
    }
}
