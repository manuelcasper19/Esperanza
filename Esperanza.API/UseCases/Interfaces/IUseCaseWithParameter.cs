

namespace Universidad.Console.UseCase.Interfaces
{
    public interface IUseCaseWithParameter<T> : IBaseUseCase<T>
    {
        T Execute(T t);
    }
}
