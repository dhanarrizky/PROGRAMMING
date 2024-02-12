using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace authenticationJwt;
public class LoginService
{

    private readonly IConfiguration _config;
    public LoginService(IConfiguration configuration){
        _config = configuration;
    }

    public LoginResponseModel Login(LoginRequestModel account){
        var IsUser = CheckLogin(account);
        if(IsUser){
            return new LoginResponseModel {
                JwtToken = GenerateJwtTokenApi(account),
            };
        } else {
            throw new KeyNotFoundException("account is not found !!!...");
        }
    }

    private bool CheckLogin(LoginRequestModel account){
        if(account.Username.Equals("dhanar")){
            if(account.Password.Equals("dhanar")){
                return true;
            }
            return false;
        } else {
            return false;
        }
    }

    private string GenerateJwtTokenApi(LoginRequestModel account){
        List<Claim> claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, account.Username)
        };

        var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
            _config.GetSection("AppSettings:Token").Value
        )); 

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
        var token = new JwtSecurityToken(
            claims: claims,
            expires:DateTime.Now.AddDays(1),
            signingCredentials:creds
        );

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }

}
