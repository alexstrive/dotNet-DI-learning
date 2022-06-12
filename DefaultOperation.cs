namespace dotnet_di
{
    public class DefaultOperation : IScopedOperation, ISingletonOperation, ITransientOperation
    {
        public string OperationId { get; } = Guid.NewGuid().ToString()[^4..];
    }
}
