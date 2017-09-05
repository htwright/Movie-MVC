using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers{
  
  public class HelloWorldController : Controller{
    // /HelloWorld/
    public string Index(){
      return "Default action";
    }
// /HelloWorld/Welcome
    public string Welcome(){
      return "welcome action method";
    }
  }

}