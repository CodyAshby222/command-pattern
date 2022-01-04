
namespace command_pattern_lab.Interfaces
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
