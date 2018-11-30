using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObservadorApp
{
    public partial class Reporte_Especies : Form
    {
        public Reporte_Especies(DataTable dt)
        {
            InitializeComponent();

            //Crear el objeto del reporte (.rpt)
            CrystalEspecie CRProd = new CrystalEspecie();

            //Asignar los datos contenidos en el dataset que recibe como parametro
            CRProd.SetDataSource(dt);

            //Asignar el visor de reportes el contenido del reporte
            crystalReportViewer1.ReportSource = CRProd;
        }
    }
}
