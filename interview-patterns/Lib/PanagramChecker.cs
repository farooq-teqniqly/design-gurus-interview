namespace Lib;

public class PanagramChecker
{
    private readonly IPanagramStrategy _strategy;
    
    public PanagramChecker(IPanagramStrategy strategy)
    {
        ArgumentNullException.ThrowIfNull(strategy);
        _strategy = strategy;
    }

    public bool CheckIfPanagram(string sentence)
    {
        ArgumentNullException.ThrowIfNull(sentence);

        return _strategy.CheckIfPanagram(sentence);
    }
}
