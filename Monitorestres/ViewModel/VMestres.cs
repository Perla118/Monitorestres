using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Monitorestres.ViewModel
{
    public class VMestres : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        int _Latidos;
        int _Horas;
        double _Nivel;

        #endregion
        #region CONSTRUCTOR
        public VMestres(INavigation navigation)
        {
            Navigation = navigation;


        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public int Latidos
        {
            get { return _Latidos; }
            set { SetValue(ref _Latidos, value); }
        }
        public int Horas
        {
            get { return _Horas; }
            set { SetValue(ref _Horas, value); }
        }
        public double Nivel
        {
            get { return _Nivel; }
            set { SetValue(ref _Nivel, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoSimple()
        {

        }
        public async Task Calcularestres()
        {
            //NivelEstrés = (FrecuenciaCardiáca / 100) + (0.2X(8 - HorasSueño)) 
            Nivel = (Latidos / 100) + (0.2 * (8 - Horas));

            if (Nivel == 0.12 || Nivel == 1.4)
            {
                await DisplayAlert("Bajo estres", "Ok", "Salir");
                
            }
            else if (Nivel == 1.5 || Nivel == 2.0)
            {
                await DisplayAlert("Estres Moderado", "Ok", "Salir");
            }
            else
            {
                await DisplayAlert("Alto estres", "Ok", "Salir");
            }
        }

        #endregion
        #region COMANDOS
         public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand Carlularestrescommand => new Command(async () => await Calcularestres());
        public ICommand ProcesoSimpcomand => new Command(procesoSimple);
        #endregion
    }
}
