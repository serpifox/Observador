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
    public partial class Reporte_Observaciones : Form
    {
        public Reporte_Observaciones(DataTable dt)
        {
            InitializeComponent();

            //Crear el objeto del reporte (.rpt)
            CrystalObservaciones CRProd = new CrystalObservaciones();

            //Asignar los datos contenidos en el dataset que recibe como parametro
            CRProd.SetDataSource(dt);

            //Asignar el visor de reportes el contenido del reporte
            crystalReportViewer1.ReportSource = CRProd;
        }
    }
}
