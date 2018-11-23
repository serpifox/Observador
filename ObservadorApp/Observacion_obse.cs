using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ObservadorApp{
    public partial class Observacion_obse : Form{
        public static SqlConnection conn = new SqlConnection("Initial Catalog= Observaciones; Data Source=localhost; Integrated Security=SSPI;");

        public Observacion_obse(){
            InitializeComponent();
            cmbObservador.Focus();
        }

        Conexion BD = new Conexion();
        int res = -1;

        public void limpiar(){
            cmbObservador.Text = "";
            cmbEspecie.Text = "";
            cmbCantidad.Text = "";
            tBFecha.Text = "";
            tBHora.Text = "";
            datGridMuestra.DataSource = "";
        }
        
        public void mostrarTodos(){
            DataSet datos = new DataSet();
            datos = TablaObservacionObservador("observador", "idObservador");
            datGridMuestra.DataSource = datos.Tables["observador"];
        }

        public DataSet TablaObservacionObservador(string observacion, string idObservacion){
            DataSet datSet = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();
            String consulta = "Select * from " + observacion + " where idObservador=" + cmbObservador.Text + " order by " + idObservacion + " ASC;";
            SqlCommand comando = new SqlCommand(consulta, conn);
            adaptador.SelectCommand = comando;
            conn.Open();
            adaptador.Fill(datSet, observacion);
            conn.Close();
            return datSet;
        }

        public void registrar(){
            try{
                if (cmbObservador.Text == ""){
                    errorGeneral.SetError(cmbObservador, "Seleccione su código de observador");
                    cmbObservador.Focus();
                }else if (cmbEspecie.Text == ""){
                    errorGeneral.SetError(cmbEspecie, "Ingrese su especie");
                    cmbEspecie.Focus();
                }else if (cmbCantidad.Text == ""){
                    errorGeneral.SetError(cmbCantidad, "Ingrese su cantidad");
                    cmbCantidad.Focus();
                }else if (tBFecha.Text == ""){
                    errorGeneral.SetError(tBFecha, "Ingrese su fecha");
                    tBFecha.Focus();
                }else if (tBHora.Text == ""){
                    errorGeneral.SetError(tBHora, "Ingrese su hora");
                    tBHora.Focus();
                }
                else{
                    string insertar = "insert into observacion values(" + cmbObservador.Text + "," + cmbEspecie.Text + "," + cmbCantidad.Text + ",'" + tBFecha.Text + "','" + tBHora.Text + "')";
                    res = BD.ABM(insertar);
                    if (res == 1){
                        MessageBox.Show("Se ha agregado el registro correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        mostrarTodos();
                    }
                }
            }catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }finally{
                Conexion.conn.Close();
            }
        }

        public void salir(){
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes){
                Application.Exit();
            }
        }

        public void mostrarCmbObservador()
        {
            Conexion.conn.Close();
            cmbObservador.Items.Clear();
            try
            {
                DataSet ds = new DataSet();
                ds = BD.BuscarCmb("select idObservador from observador", "Observador");
                foreach (DataRow fila in ds.Tables["observador"].Rows)
                {
                    cmbObservador.Items.Add(fila["idObservador"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.conn.Close();
            }
        }

        public void mostrarCmbEspecie()
        {
            Conexion.conn.Close();
            cmbEspecie.Items.Clear();
            try
            {
                DataSet ds = new DataSet();
                ds = BD.BuscarCmb("select idEspecie from especie", "Especie");
                foreach (DataRow fila in ds.Tables["especie"].Rows)
                {
                    cmbEspecie.Items.Add(fila["idEspecie"].ToString());
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.conn.Close();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e){
            if (cmbObservador.Text == ""){
                MessageBox.Show("Seleccione su código de observador.", "Observador no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else{
                mostrarTodos();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e){
            registrar();
        }

        private void btnSalir_Click(object sender, EventArgs e){
            salir();
        }
        
        private void cmbCantidad_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                tBFecha.Focus();
            }
        }

        private void dTPFecha_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                tBHora.Focus();
            }
        }

        private void tBHora_KeyPress(object sender, KeyPressEventArgs e){
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == 58){
                e.Handled = false;
            }else{
                e.Handled = true;
            }

            if (e.KeyChar == 13){
                btnRegistrar.Focus();
            }
        }

        private void btnRegistrar_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                registrar();
            }
        }

        private void btnSalir_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                salir();
            }
        }

        private void btnMostrar_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                mostrarTodos();
            }
        }
        
        private void cmbObservador_Click(object sender, EventArgs e){
            mostrarCmbObservador();
        }

        private void cmbEspecie_Click(object sender, EventArgs e){
            mostrarCmbEspecie();
        }
    }
}
