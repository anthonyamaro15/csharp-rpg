namespace csharp_rpg.Models
{
   // <T> actuall type of the data to send back
   public class ServiceResponse<T>
   {
      public T Data { get; set; }
      public bool Success { get; set; }
      public string Message { get; set; }
   }
}

// {
//    data: [
//       {
//          // properties from Character File
//       }
//    ],
//    success: false,
//    message: null
// }