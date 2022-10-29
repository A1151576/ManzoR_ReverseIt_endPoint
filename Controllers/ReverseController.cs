/* Rafael Manzo
Reverse it end Point
10/27/2022
Peer reviewed by : Chris Prado, This program runs and hs been verified in Postman, That little comment in the return was pretty funny.
*/

using Microsoft.AspNetCore.Mvc;

namespace ManzoR_ReverseIt_endPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseController : ControllerBase
{
    [HttpGet]
    [Route("ReverseIt/{number}")]
    public string Back(string number)
    {
        string num1 = "";
        string num2 = "";
        int input = int.Parse(number);
        char[] intArray = number.ToCharArray();


        for (int i = 0; i < intArray.Length; i++)
        {
            num1 = num1 + intArray[i].ToString();
        }
        for (int j = intArray.Length - 1; j > -1; j--)
        {
            num2 = num2 + intArray[j].ToString();
        }
        return $"Your number is {num1} here it is reversed as we have made it possesed so now it goes backwards.{num2}";
    }



}
