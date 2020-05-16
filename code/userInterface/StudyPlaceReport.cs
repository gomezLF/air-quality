using model;
using System.Windows.Forms;

namespace userInterface
{
    public partial class StudyPlaceReport : Form
    {

        private DatabaseAdministrator databaseAdministrator;

        public StudyPlaceReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();
            this.databaseAdministrator = databaseAdministrator;
        }

       
        
    }
}
