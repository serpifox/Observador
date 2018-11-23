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
    public partial class Zona_Admi : Form{
        public Zona_Admi(){
            InitializeComponent();
            tBCodigo.Focus();
        }

        Conexion BD = new Conexion();
        int res = -1;

        public void limpiar(){
            tBCodigo.Text = "";
            tBNombre.Text = "";
            tBEstado.Text = "";
            tBMunicipio.Text = "";
            tBCaracteristicas.Text = "";
            datGridMuestra.DataSource = "";
        }

        public void mostrarTodos(){
            DataSet datos = new DataSet();
            datos = BD.TablaZona("zona", "idZona");
            datGridMuestra.DataSource = datos.Tables["zona"];
        }

        public void buscar(){
            SqlDataReader ResConsul;
            string Consulta = "Select * from zona where idZona=" + tBCodigo.Text;
            ResConsul = BD.Buscar(Consulta);
            if (ResConsul.Read()){
                tBCodigo.Text = ResConsul.GetInt32(0).ToString();
                tBNombre.Text = ResConsul.GetString(1).ToString();
                tBEstado.Text = ResConsul.GetString(2).ToString();
                tBMunicipio.Text = ResConsul.GetString(3).ToString();
                tBCaracteristicas.Text = ResConsul.GetString(4).ToString();
            }else{
                MessageBox.Show("No se encontró ningún registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResConsul.Close();
            Conexion.conn.Close();
        }

        public void registrar(){
            try{
                if (tBNombre.Text == ""){
                    errorGeneral.SetError(tBNombre, "Ingrese su nombre");
                    tBNombre.Focus();
                }else if (tBEstado.Text == ""){
                    errorGeneral.SetError(tBEstado, "Ingrese su estado");
                    tBEstado.Focus();
                }else if (tBMunicipio.Text == ""){
                    errorGeneral.SetError(tBMunicipio, "Ingrese su municipio");
                    tBMunicipio.Focus();
                }else if (tBCaracteristicas.Text == ""){
                    errorGeneral.SetError(tBCaracteristicas, "Ingrese sus características");
                    tBCaracteristicas.Focus();
                }else{
                    string insertar = "insert into zona values('" + tBNombre.Text + "','" + tBEstado.Text + "','" + tBMunicipio.Text + "','" + tBCaracteristicas.Text + "')";
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
                string modificar = "update zona set nombre='" + tBNombre.Text + "', estado='" + tBEstado.Text + "', municipio='" + tBMunicipio.Text + "', caracteristicas='" + tBCaracteristicas.Text + "' where idZona=" + tBCodigo.Text;
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
                string eliminar = "delete from zona where idZona=" + tBCodigo.Text;
                res = BD.ABM(eliminar);
                if (res == 1)
                {
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
                tBEstado.Focus();
            }
        }

        private void tBEstado_KeyPress(object sender, KeyPressEventArgs e){
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }

            if (e.KeyChar == 13){
                tBMunicipio.Focus();
            }
        }

        private void tBMunicipio_KeyPress(object sender, KeyPressEventArgs e){
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }

            if (e.KeyChar == 13){
                tBMunicipio.Focus();
            }
        }

        private void tBCaracteristicas_KeyPress(object sender, KeyPressEventArgs e){
            if (char.IsLetter(e.KeyChar) || char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)){
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
    }
}
