abstract class Motorcycle
{
    // Anyone can call this.
    public void StartEngine() { Console.WriteLine("Ligando o Motor...."); }

    // Only derived classes can call this.
    protected internal void AddGas(int gallons) { Console.WriteLine($"Adicionando {gallons}L Gasolina");}

    // Derived classes can override the base class implementation.
    public virtual int Drive(int kilometros, int velocidade) { /* Method statements here */ return 1; }

    // Derived classes can override the base class implementation.
    public virtual int Drive(TimeSpan time, int speed) { /* Method statements here */ return 0; }

    // Derived classes must implement this.
    public abstract double GetTopSpeed();
}