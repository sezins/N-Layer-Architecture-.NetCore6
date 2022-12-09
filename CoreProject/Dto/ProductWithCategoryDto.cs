using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Dto
{
    public class ProductWithCategoryDto:ProductDto
    {
        //Repositoryler entıty doner
        //Servıceler apının ıstedıgıdtoyu ıster apıler donecegı datayı ıster
        public CategoryDto Category { get; set; }
    }
}
