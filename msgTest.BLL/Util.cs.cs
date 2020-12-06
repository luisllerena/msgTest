using mgcTest.BLL.DTO;
using mgcTest.DTO;
using System.Collections.Generic;

namespace mgcTest.BLL
{
    public static class Util
    {
        public static BLLEmployeeDTO ConvertEmployeeDTO(EmployeeDTO employeeDTO)
        {
            BLLEmployeeDTO bLLEmployeeDTO = new BLLEmployeeDTO();
            bLLEmployeeDTO.Id = employeeDTO.Id;
            bLLEmployeeDTO.Name = employeeDTO.Name;
            bLLEmployeeDTO.RoleName = employeeDTO.RoleName;
            bLLEmployeeDTO.ContractTypeName = employeeDTO.ContractTypeName;
            bLLEmployeeDTO.HourlySalary = employeeDTO.HourlySalary;
            bLLEmployeeDTO.MonthlySalary = employeeDTO.MonthlySalary;
            return bLLEmployeeDTO;
        }

        public static List<BLLEmployeeDTO> ConvertEmployeeListDTO(List<EmployeeDTO> employeeListDTO)
        {
            List<BLLEmployeeDTO> bLLEmployeeListDTO = new List<BLLEmployeeDTO>();
            foreach (EmployeeDTO item in employeeListDTO)
            {
                bLLEmployeeListDTO.Add(new BLLEmployeeDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    RoleName = item.RoleName,
                    ContractTypeName = item.ContractTypeName,
                    HourlySalary = item.HourlySalary,
                    MonthlySalary = item.MonthlySalary
                });                
            }            
            return bLLEmployeeListDTO;
        }
    }
}
