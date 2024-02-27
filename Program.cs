using System;
using System.IdentityModel.Tokens.Jwt;

public class JwtTokenDecoder
{
    public static void DecodeToken(string token)
    {
        var handler = new JwtSecurityTokenHandler();
        var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

        if (jsonToken != null)
        {
            Console.WriteLine("Decoded Token Claims:");

            foreach (var claim in jsonToken.Claims)
            {
                Console.WriteLine($"{claim.Type}: {claim.Value}");
            }
        }
        else
        {
            Console.WriteLine("Invalid JWT token.");
        }


        //created dev branch
         public static void DToken(string token)
    {
        var handler = new JwtSecurityTokenHandler();
        var jsonToken = handler.ReadToken(token) as JwtSecurityToken;

        if (jsonToken != null)
        {
            Console.WriteLine("Decoded Token Claims:");

            foreach (var claim in jsonToken.Claims)
            {
                Console.WriteLine($"{claim.Type}: {claim.Value}");
            }
        }
        else
        {
            Console.WriteLine("Invalid JWT token.");
        }
    }

    public static void Main(string[] args)
    {
        // Replace 'your_token_here' with the actual JWT token
        string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1laWQiOiI1IiwibmJmIjoxNzA3NTg4ODQ1LCJleHAiOjE3MDc1OTI0NDUsImlhdCI6MTcwNzU4ODg0NX0.3KjutCcT7IXB8K8EMcHwlIOvgLyKkRvTZsXP9IkVKWU";

        DecodeToken(token);
    }
}

//change 1
//change 2
