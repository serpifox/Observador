using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace ObservadorApp{
    public partial class Inicio_sesion : Form{
        public Inicio_sesion(){
            InitializeComponent();
            Thread hilo = new Thread(mostrarSplash);
            hilo.Start();
            Thread.Sleep(5000);
            hilo.Abort();
        }

        Conexion BD = new Conexion();

        public void mostrarSplash(){
            Splash sps = new Splash();
            sps.ShowDialog();
        }

        public void abrirMenuPrincipal(){
            Hide();
            Menu_Admi menu = new Menu_Admi();
            menu.ShowDialog();
        }

        public void abrirObservaciones(){
            Hide();
            Observacion_ob observaciones = new Observacion_ob();
            observaciones.ShowDialog();
        }

        public void ingresar(){
            String idUsuario, usuario, contrasenia, privilegios, idObservador;

            if (tBUsuario.Text == ""){
                errorUsuario.SetError(tBUsuario, "Ingrese su usuario");
                tBUsuario.Focus();
            }else if (tBContrasenia.Text == ""){
                errorContrasenia.SetError(tBContrasenia, "Ingrese su contraseña");
                tBContrasenia.Focus();
            }else{
                try{
                    SqlDataReader ResConsul;
                    string Consulta = "Select u.*, o.estatus from usuario u join observador o on u.idObservador = o.idObservador where u.usuario='" + tBUsuario.Text + "' and u.contrasenia='" + tBContrasenia.Text + "' and o.estatus='Activo'";
                    ResConsul = BD.Buscar(Consulta);
                    if (ResConsul.Read()){
                        idUsuario = ResConsul.GetInt32(0).ToString();
                        usuario = ResConsul.GetString(1).ToString();
                        contrasenia = ResConsul.GetString(2).ToString();
                        privilegios = ResConsul.GetString(3).ToString();
                        idObservador = ResConsul.GetInt32(4).ToString();
                        if (privilegios == "administrador"){
                            abrirMenuPrincipal();
                            ResConsul.Close();
                            Conexion.conn.Close();
                        }else if (privilegios == "observador"){
                            abrirObservaciones();
                            ResConsul.Close();
                            Conexion.conn.Close();
                        }
                    }
                    else{
                        MessageBox.Show("Usuario/Contraseña inválido(s), intente nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Conexion.conn.Close();
                    }
                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                    Conexion.conn.Close();
                }
            }
        }

        public void salir(){
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Confirmación de salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes){
                Application.Exit();
            }else{
                tBUsuario.Focus();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e){
            ingresar();
        }

        private void btnSalir_Click(object sender, EventArgs e){
            salir();
        }

        private void tBUsuario_KeyPress(object sender, KeyPressEventArgs e){
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }

            if (e.KeyChar == 13){
                tBContrasenia.Focus();
            }
        }

        private void tBContrasenia_KeyPress(object sender, KeyPressEventArgs e){
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar)){
                e.Handled = false;
            }else{
                e.Handled = true;
            }

            if (e.KeyChar == 13){
                btnIngresar.Focus();
            }
        }

        private void btnIngresar_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                ingresar();
            }
        }

        private void btnSalir_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                salir();
            }
        }
    }
}
