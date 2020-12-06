using mgcTest.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace mgcTest.DAL
{
    public class EmployeeRepository
    {
        private string URL = "http://masglobaltestapi.azurewebsites.net/api/Employees";

        public ResponseDTO<List<EmployeeDTO>> GetEmployees() 
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(URL);
                    var response = client.GetAsync(URL).GetAwaiter().GetResult();
                    var result = response.Content.ReadAsStringAsync().Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        return new ResponseDTO<List<EmployeeDTO>>
                        {
                            success = false,
                            message = result
                        };
                    }
                    //if everything is ok
                    var list = JsonConvert.DeserializeObject<List<EmployeeDTO>>(result);
                    return new ResponseDTO<List<EmployeeDTO>>
                    {
                        success = true,
                        data = list
                    };
                }
            }
            catch (Exception ex) 
            {
                return new ResponseDTO<List<EmployeeDTO>>
                {
                    success = false,
                    message = ex.Message
                };
            }         
        }

        public ResponseDTO<EmployeeDTO> GetEmployeeById(int idEmployee)
        {
            try
            {
                var employees = GetEmployees();
                if (employees.success)
                {

                    var employee = (from d in employees.data
                                    where d.Id == idEmployee
                                    select d).FirstOrDefault();

                    return new ResponseDTO<EmployeeDTO>
                    {
                        success = true,
                        data = employee
                    };
                }
                else 
                {
                    return new ResponseDTO<EmployeeDTO>
                    {
                        success = false,
                        message = employees.message
                    };
                }
            }
            catch (Exception ex)
            {
                return new ResponseDTO<EmployeeDTO>
                {
                    success = false,
                    message = ex.Message
                };
            }
        }
    }
}
