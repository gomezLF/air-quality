using model;
using System.Windows.Forms;

namespace userInterface
{
    public partial class LevelConcentrationReport : Form
    {
        private DatabaseAdministrator databaseAdministrator;
        public LevelConcentrationReport(DatabaseAdministrator databaseAdministrator)
        {
            InitializeComponent();
            this.databaseAdministrator = databaseAdministrator;
        }

       
    }
}
