namespace API.Interfaz
{
    public class Base
    {
        public string Moverse(IAnimal animal)
        {
            return animal.Moverse();
        }
    }
}
