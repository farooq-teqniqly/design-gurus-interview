namespace Lib;

public interface ISearchStrategy
{
    const int TargetNotFound = -1;
    int Search(int[] input, int target);
}