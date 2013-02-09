using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Zenfolio.Examples.Browser.ZfApiRef;

namespace Zenfolio.Examples.Browser
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class MainWindow : UserControl
    {
        private ZenfolioClient _client;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            _client = new ZenfolioClient();

            // try to login
            Boolean loggedIn = _client.Login("", "");
            //Boolean loggedIn = _client.LoginPlain("", "");

            // load own profile
            User user = _client.LoadPrivateProfile();

            // load and wrap Groups hierarchy
            Group rootGroup = _client.LoadGroupHierarchy(user.LoginName);
            //TreeNode rootNode = CreateGroupNode(rootGroup);

            //// fix-up the root node of the Group hierarchy
            //rootNode.ImageIndex = (int)NodeType.Root;
            //rootNode.SelectedImageIndex = rootNode.ImageIndex;
            //rootNode.Text = user.DisplayName;
            //_tvGroups.Nodes.Add(rootNode);

            //// initialize browser pane
            //_axWebBrowser.Navigate("about:blank");
            //_axWebBrowser.TheaterMode = true;
        }
    }
}
