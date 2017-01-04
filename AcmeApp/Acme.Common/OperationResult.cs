namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
    public class OperationResult<T>  //generic type variable declaration, make it a generic class
    {
        public OperationResult()
        {
        }

       // public OperationResult(bool success, string message) : this()
        public OperationResult(T result, string message) : this()
        {
            // this.Success = success;
            this.Result = result;

            this.Message = message;
        }

        //  public bool Success { get; set; }
        public T Result { get; set; } // T generic type variable
        public string Message { get; set; }
    }

     //Provides a decimal amount and message
  /*  public class OperationResultDecimal
    {
        public OperationResultDecimal()
        {

        }

        public OperationResultDecimal(decimal result, string message) : this()
        {
            this.Result = result;
            this.Message = message;
        }

        public decimal Result { get; set; }
        public string Message { get; set; }
    }*/
}
