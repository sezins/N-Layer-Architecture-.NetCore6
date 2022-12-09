using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CoreProject.Dto
{
    public class CustomResponseDto<T>
    {
        //Custom TDta List donerız
        //Apılerle donecegım apılere ozgu olan bır durum
        public T Data { get; set; }
        //Statuscode clıentlara donmeyecek onlar zaten ıstek yaptıklarında donecek.
        [JsonIgnore]
        public int Satatuscode { get; set; }
        public List<string> Errors { get; set; }
        public static CustomResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomResponseDto<T> { Satatuscode = statusCode, Data = data };
        }
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> { Satatuscode = statusCode };
        }

        public static CustomResponseDto<T> Fail(int statusCode,List<string> errors)
        {
            return new CustomResponseDto<T> { Satatuscode = statusCode, Errors = errors };
        }
        public static CustomResponseDto<T> Fail(int statusCode,string error)
        {
            return new CustomResponseDto<T> { Satatuscode = statusCode, Errors = new List<string> { error } };
        }

    }
}
