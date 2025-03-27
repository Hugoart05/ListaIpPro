using Domain.DTOs;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Interfaces
{
    public interface IUserAtuhService
    {
        Task<ResponseDTO> SignIn(LoginDomain login);
        Task<ResponseDTO> SignUp(UserDomain login);
    }
}
