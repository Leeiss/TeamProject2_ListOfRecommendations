using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TeamProject2__ListOfRecommendations
{
    public partial class СhangeСharacteristics : Form
    {
        private string Xmlpath = "@./../../../ForLists.xml";
        XDocument doc = XDocument.Load("@./../../../ForLists.xml");
        public СhangeСharacteristics()
        {
            InitializeComponent();
        }

        private void СhangeСharacteristics_Load(object sender, EventArgs e)
        {
            IEnumerable<string> actors = doc.Element("for_lists").Element("actors").Elements("actor").Select(x => x.Value);

            foreach (string actor in actors)
            {
                actors_list.Items.Add(actor);
            }

            IEnumerable<string> countries = doc.Element("for_lists").Element("countries").Elements("country").Select(x => x.Value);

            foreach (string country in countries)
            {
                countries_list.Items.Add(country);
            }
        }
    }
}
