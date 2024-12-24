namespace API.Herencia
{
    public class Animal
    {
        public string especie {  get; set; }

        public virtual string Moverse()
        {
            return "El animal se movio";
        }
    }
}
