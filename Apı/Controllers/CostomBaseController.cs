using CoreProject.Dto;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostomBaseController : ControllerBase
    {
        //Endpoınt degıldır.Apı bunu endpoınt olarak algılamamsı ıcın yapılmıtrı.
        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.Satatuscode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = response.Satatuscode,
                };
            //Burada da 204 dısında gelen ne vars o donecek.
            return new ObjectResult(response)
            {
                StatusCode = response.Satatuscode
            };
        }
    }
}
