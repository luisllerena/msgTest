using mgcTest.BLL.DTO;
using mgcTest.DAL;
using mgcTest.DTO;
using System.Collections.Generic;

namespace mgcTest.BLL
{
    public class BusinessService: IBusinessService
    {
        public ResponseDTO<List<BLLEmployeeDTO>> GetEmployees()
        {
            ResponseDTO<List<BLLEmployeeDTO>> response = new ResponseDTO<List<BLLEmployeeDTO>>();
            DataService dataService = new DataService();
            var apiResponse = dataService.GetEmployees();

            if (apiResponse.success && apiResponse.data.Count > 0)
            {
                response.success = true;
                response.data = Util.ConvertEmployeeListDTO(apiResponse.data);
            }
            else
            {
                response.success = false;
                response.message = apiResponse.message;
            }

            return response;
        }

        public ResponseDTO<BLLEmployeeDTO> GetEmployeeById(int idEmployee)
        {
            ResponseDTO<BLLEmployeeDTO> response = new ResponseDTO<BLLEmployeeDTO>();
            DataService dataService = new DataService();
            var apiResponse = dataService.GetEmployeeById(idEmployee);

            if (apiResponse.success )
            {
                if (apiResponse.data != null)
                {
                    response.success = true;
                    response.data = Util.ConvertEmployeeDTO(apiResponse.data);
                }
                else 
                {
                    response.success = false;
                    response.message = "No data found";
                }                
            }
            else 
            {
                response.success = false;
                response.message = apiResponse.message;
            }
                
            return response;
        }            
    }
}