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
    public partial class Asociacion_Admi : Form{
        public Asociacion_Admi(){
            InitializeComponent();
        }

        Conexion BD = new Conexion();
        int res = -1;

        private void btnSalir_Click(object sender, EventArgs e){
            DialogResult confirmacion = MessageBox.Show("Está seguro que desea salir de la aplicación","Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes){
                Application.Exit();
            }else{
                Borrar();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e){
            Menu_Admi menu = new Menu_Admi();
            this.Hide();
            menu.Show();
        }

        public void Borrar(){
            tBCodigo.Text = "";
            tBNombre.Text = "";
            tBDireccion.Text = "";
            tBTelefono.Text = "";
            datGridMuestra.DataSource = "";
        }
        
        public void Registrar(){
            try{
                errorGeneral.Clear();
                if (tBNombre.Text == ""){
                    errorGeneral.SetError(tBNombre, "Ingresa un nombre");
                    tBNombre.Focus();
                }else if (tBDireccion.Text == ""){
                    errorGeneral.SetError(tBDireccion, "Ingresa una dirección");
                    tBDireccion.Focus();
                }else if (tBTelefono.Text == ""){
                    errorGeneral.SetError(tBTelefono, "Ingresa un télefono");
                    tBTelefono.Focus();
                }else{
                    string insertar = "insert into asociacion values('" + tBNombre.Text + "', '" + tBDireccion.Text + "', '" + tBTelefono.Text + "')";

                    res = BD.ABM(insertar);
                    if (res == 1){
                        MessageBox.Show("Se ha agregado un registro", "Altas",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Borrar();
                        MostrarTodo();
                    }
                }
            }catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }finally{
                Conexion.conn.Close();
            }
        }

        public void Modificar(){
            try{
                errorGeneral.Clear();
                string modificar = "update asociacion set nombre='" + tBNombre.Text +
                    "', direccion='" + tBDireccion.Text + "', telefono='" + tBTelefono.Text + "' where idAsociacion = " + tBCodigo.Text;

                res = BD.ABM(modificar);
                if (res == 1){
                    MessageBox.Show("Se ha modificado el registro correctamente",
                        "Modificaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Borrar();
                    MostrarTodo();
                }
            }catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }finally{
                Conexion.conn.Close();
            }
        }

        public void Eliminar(){
            try{
                errorGeneral.Clear();
                string eliminar = "delete from asociacion where idAsociacion = " + tBCodigo.Text;

                res = BD.ABM(eliminar);
                if (res == 1){
                    MessageBox.Show("Se ha eliminado un registro correctamente", "Bajas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Borrar();
                    MostrarTodo();
                }
            }catch (SqlException ex){
                MessageBox.Show(ex.Message);
            }finally{
                Conexion.conn.Close();
            }
        }

        public void Buscar(){
            SqlDataReader ResConsul;
            string Consulta = "Select * from asociacion where idAsociacion=" + tBCodigo.Text;
            ResConsul = BD.Buscar(Consulta);

            if (ResConsul.Read()){
                tBCodigo.Text = ResConsul.GetInt32(0).ToString();
                tBNombre.Text = ResConsul.GetString(1).ToString();
                tBDireccion.Text = ResConsul.GetString(2).ToString();
                tBTelefono.Text = ResConsul.GetString(3).ToString();
            }else{
                MessageBox.Show("No se encontró ningún registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResConsul.Close();
            Conexion.conn.Close();
        }

        public void MostrarTodo(){
            DataSet datos = new DataSet();
            datos = BD.TablaAsociacion("asociacion", "idAsociacion");
            datGridMuestra.DataSource = datos.Tables["asociacion"];
        }

        private void btnRegistrar_Click(object sender, EventArgs e){
            Registrar();
        }

        private void btnModificar_Click(object sender, EventArgs e){
            Modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            Eliminar();
        }

        private void btnMostrar_Click(object sender, EventArgs e){
            MostrarTodo();
        }

        private void btnBuscar_Click(object sender, EventArgs e){
            Buscar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e){
            Borrar();
        }
    }
}
