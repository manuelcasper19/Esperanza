

namespace Universidad.Console.UseCase.Interfaces
{
    public interface IUseCaseWithReturn<T> : IBaseUseCase<T>
    {
        T Execute();
    }
}
