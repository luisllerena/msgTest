using mgcTest.BLL.DTO;
using mgcTest.DTO;
using System.Collections.Generic;

namespace mgcTest.BLL
{
    public interface IBusinessService
    {
        ResponseDTO<List<BLLEmployeeDTO>> GetEmployees();
        ResponseDTO<BLLEmployeeDTO> GetEmployeeById(int idEmployee);
    }
}