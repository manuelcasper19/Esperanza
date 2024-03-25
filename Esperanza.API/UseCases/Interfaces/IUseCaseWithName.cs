

namespace Universidad.Console.UseCase.Interfaces
{
    public interface IUseCaseWithName<T> : IBaseUseCase<T>
    {
         T Execute(string name);
    }
}
