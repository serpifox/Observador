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
    public partial class Observacion_admi : Form{
        public Observacion_admi(){
            InitializeComponent();
            tBCodigo.Focus();
        }

        Conexion BD = new Conexion();
        int res = -1;

        public void limpiar(){
            tBCodigo.Text = "";
            cmbObservador.Text = "";
            cmbEspecie.Text = "";
            cmbCantidad.Text = "";
            tBFecha.Text = "";
            tBHora.Text = "";
            datGridMuestra.DataSource = "";
        }

        public void mostrarTodos(){
            DataSet datos = new DataSet();
            datos = BD.TablaObservacion("observacion", "idObservacion");
            datGridMuestra.DataSource = datos.Tables["observacion"];
        }

        public void buscar(){
            SqlDataReader ResConsul;
            string Consulta = "Select * from observacion where idObservacion=" + tBCodigo.Text;
            ResConsul = BD.Buscar(Consulta);
            if (ResConsul.Read()){
                tBCodigo.Text = ResConsul.GetInt32(0).ToString();
                cmbObservador.Text = ResConsul.GetInt32(1).ToString();
                cmbEspecie.Text = ResConsul.GetInt32(2).ToString();
                cmbCantidad.Text = ResConsul.GetInt32(3).ToString();
                tBFecha.Text = ResConsul.GetString(4).ToString();
                tBHora.Text = ResConsul.GetString(5).ToString();
            }else{
                MessageBox.Show("No se encontró ningún registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResConsul.Close();
            Conexion.conn.Close();
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
                }else{
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

        public void modificar(){
            try{
                string modificar = "update observacion set idObservador=" + cmbObservador.Text + ", idEspecie=" + cmbEspecie.Text + ", cantidad=" + cmbCantidad.Text + ", fechaObservacion='" + tBFecha.Text + "', horaObservacion='" + tBHora.Text + "' where idObservacion=" + tBCodigo.Text;
                res = BD.ABM(modificar);
                if (res == 1){
                    MessageBox.Show("Se ha modificado el registro correctamente.", "Modificación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    mostrarTodos();
                }
            }catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }finally{
                Conexion.conn.Close();
            }
        }

        public void eliminar(){
            try{
                string eliminar = "delete from observacion where idObservador=" + tBCodigo.Text;
                res = BD.ABM(eliminar);
                if (res == 1){
                    MessageBox.Show("Se ha eliminado el registro correctamente.", "Baja existosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    mostrarTodos();
                }
            }catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }finally{
                Conexion.conn.Close();
            }
        }

        public void regresar(){
            Hide();
            Menu_Admi menu = new Menu_Admi();
            menu.ShowDialog();
        }

        public void salir(){
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes){
                Application.Exit();
            }
        }

        public void mostrarCmbObservador(){
            cmbObservador.Items.Clear();
            try{
                DataSet ds = new DataSet();
                ds = BD.BuscarCmb("select idObservador from observador", "Observador");
                foreach (DataRow fila in ds.Tables["observador"].Rows){
                    cmbObservador.Items.Add(fila["idObservador"].ToString());
                }
            }catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }finally{
                Conexion.conn.Close();
            }
        }

        public void mostrarCmbEspecie(){
            cmbEspecie.Items.Clear();
            try{
                DataSet ds = new DataSet();
                ds = BD.BuscarCmb("select idEspecie from especie", "Especie");
                foreach (DataRow fila in ds.Tables["especie"].Rows){
                    cmbEspecie.Items.Add(fila["idEspecie"].ToString());
                }
            }catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }finally{
                Conexion.conn.Close();
            }
        }

        private void Reporte_Click(object sender, EventArgs e)
        {
            dsObservaciones dsPro = new dsObservaciones();

            try
            {
                DataSet DS = new DataSet();

                DS = BD.Reporte_Observaciones("select * from Ver_Observaciones",
                    "Ver_Observaciones");

                if (DS.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún resultado", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (DataRow fila in DS.Tables["Ver_Observaciones"].Rows)
                    {
                        dsPro.dtObservaciones.Rows.Add(fila["nombre"].ToString(),
                            fila["nombreCientifico"].ToString(), fila["cantidad"].ToString());
                    }
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

            Reporte_Observaciones rep = new Reporte_Observaciones(dsPro.dtObservaciones);
            rep.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e){
            mostrarTodos();
        }

        private void btnBuscar_Click(object sender, EventArgs e){
            buscar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e){
            limpiar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e){
            registrar();
        }

        private void btnModificar_Click(object sender, EventArgs e){
            modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            eliminar();
        }

        private void btnRegresar_Click(object sender, EventArgs e){
            regresar();
        }

        private void btnSalir_Click(object sender, EventArgs e){
            salir();
        }

        private void tBCodigo_KeyPress(object sender, KeyPressEventArgs e){
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }

            if (e.KeyChar == 13){
                cmbObservador.Focus();
            }
        }

        private void cmbObservador_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                cmbEspecie.Focus();
            }
        }

        private void cmbEspecie_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                cmbCantidad.Focus();
            }
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

        private void btnModificar_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                modificar();
            }
        }

        private void btnEliminar_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                eliminar();
            }
        }

        private void btnRegresar_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                regresar();
            }
        }

        private void btnSalir_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                salir();
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
