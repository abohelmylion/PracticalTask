﻿using System.ComponentModel.DataAnnotations;

namespace PracticalTask.Business.Dto.Parameter
{
    public class UsernameParameterDto : IUsernameParameterDto
    {
        [Required(ErrorMessage = "Name Is Required", AllowEmptyStrings = false), StringLength(maximumLength: 50, ErrorMessage = "Invalid Name")]
        public string Username { get; set; }
    }
}
