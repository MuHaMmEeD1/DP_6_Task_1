
public interface IRaund
{
    void RaundChange(GameConsole gameConsole);
    void ShowRaund();
}


public class Raund1 : IRaund
{
    public void RaundChange(GameConsole gameConsole)
    {
        gameConsole.ChangeRaund(new Raund2());
    }

    public void ShowRaund()
    {
        Console.WriteLine("Raund 1");
    }
}


public class Raund2 : IRaund
{
    public void RaundChange(GameConsole gameConsole)
    {
        gameConsole.ChangeRaund(new Raund1());
    }

    public void ShowRaund()
    {
        Console.WriteLine("Raund 2");
    }
}







public class GameConsole
{
    private IRaund _raund;

    public GameConsole()
    {
        _raund = new Raund1();
    }

    public void StartRaund()
    {
        _raund.ShowRaund();
        _raund.RaundChange(this);
    }

    public void ChangeRaund(IRaund raund)
    {
        _raund = raund;
    }

}



class Program
{

    static void Main(string[] args)
    {

        GameConsole gameConsole = new GameConsole();

        gameConsole.StartRaund();
        gameConsole.StartRaund();
        gameConsole.StartRaund();
        gameConsole.StartRaund();







    }


}















