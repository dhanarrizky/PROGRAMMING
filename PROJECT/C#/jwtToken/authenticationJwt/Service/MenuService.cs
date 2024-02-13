using Microsoft.IdentityModel.Tokens;

namespace authenticationJwt;
public class MenuService
{

    private readonly IConfiguration _config;
    public MenuService(IConfiguration configuration){
        _config = configuration;
    }

    public MenuResponseModel GetMenu(){
        return new MenuResponseModel {
            StatusCode = "code is work \n status code is 200"
        };
    }
}
