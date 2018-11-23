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
    public partial class Observador_Admi : Form{
        public Observador_Admi(){
            InitializeComponent();
            tBCodigo.Focus();
        }

        Conexion BD = new Conexion();
        int res = -1;

        public void limpiar(){
            tBCodigo.Text = "";
            tBCurp.Text = "";
            tBNombre.Text = "";
            tBDireccion.Text = "";
            cmbZona.Text = "";
            cmbAsociacion.Text = "";
            datGridMuestra.DataSource = "";
        }

        public void mostrarTodos(){
            DataSet datos = new DataSet();
            datos = BD.TablaObservador("observador", "idObservador");
            datGridMuestra.DataSource = datos.Tables["observador"];
        }

        public void buscar(){
            SqlDataReader ResConsul;
            string Consulta = "Select * from observador where idObservador=" + tBCodigo.Text;
            ResConsul = BD.Buscar(Consulta);
            if (ResConsul.Read()){
                tBCodigo.Text = ResConsul.GetInt32(0).ToString();
                tBCurp.Text = ResConsul.GetString(1).ToString();
                tBNombre.Text = ResConsul.GetString(2).ToString();
                tBDireccion.Text = ResConsul.GetString(3).ToString();
                cmbZona.Text = ResConsul.GetInt32(4).ToString();
                cmbAsociacion.Text = ResConsul.GetInt32(5).ToString();
            }else{
                MessageBox.Show("No se encontró ningún registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResConsul.Close();
            Conexion.conn.Close();
        }
        
        public void registrarUsuario(){
            try {
                if (tBUsuario.Text == ""){
                    errorGeneral.SetError(tBUsuario, "Ingrese su usuario");
                    tBUsuario.Focus();
                }else if (tBContrasenia.Text == ""){
                    errorGeneral.SetError(tBContrasenia, "Ingrese su contraseña");
                    tBContrasenia.Focus();
                }else{
                    SqlDataReader ResConsul;
                    string Consulta = "Select MAX(idObservador) from observador";
                    ResConsul = BD.Buscar(Consulta);
                    if (ResConsul.Read()){
                        lblId.Text = ResConsul.GetInt32(0).ToString();
                    }
                    ResConsul.Close();
                    Conexion.conn.Close();
                    lblId.Visible = false;
                    string insertar = "insert into usuario values('" + tBUsuario.Text + "','" + tBContrasenia.Text + "','observador'," + lblId.Text + ")";
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

        public void registrar(){
            try{
                if (tBCurp.Text == ""){
                    errorGeneral.SetError(tBCurp, "Ingrese su CURP");
                    tBCurp.Focus();
                }else if (tBNombre.Text == ""){
                    errorGeneral.SetError(tBNombre, "Ingrese su nombre");
                    tBNombre.Focus();
                }else if (tBDireccion.Text == ""){
                    errorGeneral.SetError(tBDireccion, "Ingrese su dirección");
                    tBDireccion.Focus();
                }else{
                    string insertar = "insert into observador values('" + tBCurp.Text + "','" + tBNombre.Text + "','" + tBDireccion.Text + "'," + cmbZona.Text + "," + cmbAsociacion.Text + ",'Activo')";
                    res = BD.ABM(insertar);
                    if (res == 1){
                        //MessageBox.Show("Se ha agregado el registro correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //limpiar();
                        //mostrarTodos();
                    }
                    Conexion.conn.Close();
                }
            }catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }finally{
                Conexion.conn.Close();
            }
        }

        public void modificar(){
            try{
                string modificar = "update observador set curp='" + tBCurp.Text + "', nombre='" + tBNombre.Text + "', direccion='" + tBDireccion.Text + "', idZona=" + cmbZona.Text + ", idAsociacion=" + cmbAsociacion.Text + " where idObservador=" + tBCodigo.Text;
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
                string eliminar = "update observador set estatus='Inactivo' where idObservador=" + tBCodigo.Text;
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

        public void mostrarCmbZona(){
            cmbZona.Items.Clear();
            try{
                DataSet ds = new DataSet();
                ds = BD.BuscarCmb("select idZona from zona", "Zona");
                foreach (DataRow fila in ds.Tables["zona"].Rows){
                    cmbZona.Items.Add(fila["idZona"].ToString());
                }
            }catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }finally{
                Conexion.conn.Close();
            }
        }

        public void mostrarCmbAsociacion(){
            cmbAsociacion.Items.Clear();
            try{
                DataSet ds = new DataSet();
                ds = BD.BuscarCmb("select idAsociacion from asociacion", "Asociacion");
                foreach (DataRow fila in ds.Tables["asociacion"].Rows){
                    cmbAsociacion.Items.Add(fila["idAsociacion"].ToString());
                }
            }catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }finally{
                Conexion.conn.Close();
            }
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
            Conexion.conn.Close();
            registrarUsuario();
        }

        private void btnModificar_Click(object sender, EventArgs e){
            modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            eliminar();
        }

        private void cmbZona_Click(object sender, EventArgs e){
            mostrarCmbZona();   
        }

        private void cmbAsociacion_Click(object sender, EventArgs e){
            mostrarCmbAsociacion();
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
                tBCurp.Focus();
            }
        }

        private void tBCurp_KeyPress(object sender, KeyPressEventArgs e){
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }

            if (e.KeyChar == 13){
                tBNombre.Focus();
            }
        }

        private void tBNombre_KeyPress(object sender, KeyPressEventArgs e){
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }

            if (e.KeyChar == 13){
                tBDireccion.Focus();
            }
        }

        private void tBDireccion_KeyPress(object sender, KeyPressEventArgs e){
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }

            if (e.KeyChar == 13){
                cmbZona.Focus();
            }
        }

        private void cmbZona_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                cmbAsociacion.Focus();
            }
        }

        private void cmbAsociacion_KeyPress(object sender, KeyPressEventArgs e){
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
    }
}
