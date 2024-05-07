namespace BuildingBlocks;

 
public abstract class PatternExecutor
{
    public virtual string Name => GetType().Name;
 
    public abstract void Execute();
}