using SuperZapatosApp.Views;
using System.Drawing.Text;

namespace SuperZapatosApp
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
            CustomizeDesing();
        }
        private void CustomizeDesing()
        {
            panelArticulosSubMenu.Visible = false;
            panelTiendasSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelArticulosSubMenu.Visible == true)
            {
                panelArticulosSubMenu.Visible = false;
            }
            if (panelTiendasSubMenu.Visible == true)
            {
                panelTiendasSubMenu.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnTiendasSubMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelTiendasSubMenu);
        }

        private void btnArticulosSubMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelArticulosSubMenu);
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainerChild.Controls.Add(childForm);
            panelContainerChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTodosArticulos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ArticulosView());
            HideSubMenu();
        }

        private void btnFiltrarArticulos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FiltrarArticulosView());
            HideSubMenu();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AgregarArticuloView());
            HideSubMenu();
        }

        private void BtnEditarArticulo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditarArticuloView());
            HideSubMenu();
        }

        private void btnTiendas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TiendasView());
            HideSubMenu();
        }

        private void btnAgregarTienda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AgregarTiendaView());
            HideSubMenu();
        }

        private void btnEditarTienda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EditarTiendaView());
            HideSubMenu();
        }
    }
}
