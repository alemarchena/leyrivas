namespace Leyrivas
{
    public interface IState
    {
        /// <summary>
        /// Al inicializar carga la escena y setea los parametros de Interfaz actual y DataState al publisher
        /// </summary>
        /// <param name="nameScene"></param>
        /// <param name="state"></param>
        /// <param name="dataState"></param>
        public void InitState(string nameScene,IState state, DataState dataState);
    }
}