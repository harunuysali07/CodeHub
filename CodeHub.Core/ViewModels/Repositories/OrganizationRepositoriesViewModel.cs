using System.Threading.Tasks;

namespace CodeHub.Core.ViewModels.Repositories
{
    public class OrganizationRepositoriesViewModel : RepositoriesViewModel
    {
        public string Name
        {
            get;
            private set;
        }

        public OrganizationRepositoriesViewModel()
        {
            ShowRepositoryOwner = false;
        }

        public void Init(NavObject navObject)
        {
            Name = navObject.Name;
        }

        protected override Task Load(bool forceDataRefresh)
        {
            return Repositories.SimpleCollectionLoad(this.GetApplication().Client.Organizations[Name].Repositories.GetAll(), forceDataRefresh);
        }

        public class NavObject
        {
            public string Name { get; set; }
        }
    }
}

