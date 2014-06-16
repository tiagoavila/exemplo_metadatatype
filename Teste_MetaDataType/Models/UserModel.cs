using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Teste_MetaDataType.Models
{
    [MetadataType(typeof(UserModel))]
    public partial class User
    {
        class UserModel
        {
            [Required]
            public string Nome { get; set; }

            [Required]
            public string Senha { get; set; }
        }
    }
}