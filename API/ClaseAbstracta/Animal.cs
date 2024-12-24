namespace API.ClaseAbstracta
{
    public abstract class Animal
    {
        public string color { get; set; }
        public Animal(string color) 
        {

        }

        public string ObtenerDistanciaRecorrida()
        {
            return "El animal recorio 20km";
        }
    }
}
