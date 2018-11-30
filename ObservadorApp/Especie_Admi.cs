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
    public partial class Especie_Admi : Form{
        public Especie_Admi(){
            InitializeComponent();
        }

        Conexion BD = new Conexion();
        int res = -1;

        private void btnSalir_Click(object sender, EventArgs e){
            DialogResult confirmacion = MessageBox.Show("Está seguro que desea salir de la aplicación",
                "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            tBApodo.Text = "";
            tBDesc.Text = "";
            tBGenero.Text = "";
            datGridMuestra.DataSource = "";
        }

        public void Registrar(){
            try{
                errorGeneral.Clear();
                if (tBNombre.Text == ""){
                    errorGeneral.SetError(tBNombre, "Ingresa un nombre");
                    tBNombre.Focus();
                }else if (tBApodo.Text == ""){
                    errorGeneral.SetError(tBApodo, "Ingresa un apodo");
                    tBApodo.Focus();
                }else if (tBDesc.Text == ""){
                    errorGeneral.SetError(tBDesc, "Ingresa una descripción");
                    tBDesc.Focus();
                }else if (tBGenero.Text == ""){
                    errorGeneral.SetError(tBGenero, "Ingresa un genero");
                    tBGenero.Focus();
                }else{
                    string insertar = "insert into especie values('" + tBNombre.Text + "', '" + tBApodo.Text + "', '" + tBDesc.Text + "', '" + tBGenero.Text + "')";

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
                string modificar = "update especie set nombreCientifico='" + tBNombre.Text +
                    "', nombreVulgar='" + tBApodo.Text + "', descripcion='" + tBDesc.Text + "', genero='" + tBGenero + "' where idEspecie = " + tBCodigo.Text;

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
                string eliminar = "delete from especie where idEspecie = " + tBCodigo.Text;

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
            string Consulta = "Select * from especie where idEspecie=" + tBCodigo.Text;
            ResConsul = BD.Buscar(Consulta);

            if (ResConsul.Read()){
                tBCodigo.Text = ResConsul.GetInt32(0).ToString();
                tBNombre.Text = ResConsul.GetString(1).ToString();
                tBApodo.Text = ResConsul.GetString(2).ToString();
                tBDesc.Text = ResConsul.GetString(3).ToString();
                tBGenero.Text = ResConsul.GetString(4).ToString();
            }else{
                MessageBox.Show("No se encontró ningún registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResConsul.Close();
            Conexion.conn.Close();
        }

        public void MostrarTodo(){
            DataSet datos = new DataSet();
            datos = BD.TablaEspecie("especie", "idEspecie");
            datGridMuestra.DataSource = datos.Tables["especie"];
        }

        private void Reporte_Click(object sender, EventArgs e)
        {
            dsEspecie dsPro = new dsEspecie();

            try
            {
                DataSet DS = new DataSet();

                DS = BD.Reporte_Especies("select * from Ver_Especies",
                    "Ver_Especies");

                if (DS.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No se encontró ningún resultado", "Búsqueda",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (DataRow fila in DS.Tables["Ver_Especies"].Rows)
                    {
                        dsPro.dtEspecie.Rows.Add(fila["nombreCientifico"].ToString(), 
                            fila["nombreVulgar"].ToString(),fila["descripcion"].ToString(),
                            fila["cantidad"].ToString());
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

            Reporte_Especies rep = new Reporte_Especies(dsPro.dtEspecie);
            rep.ShowDialog();
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
