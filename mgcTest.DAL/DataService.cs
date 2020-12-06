using mgcTest.DTO;
using System.Collections.Generic;

namespace mgcTest.DAL
{
    public class DataService
    {
        private EmployeeRepository _repository;
        public DataService()
        {
            _repository = new EmployeeRepository();
        }
        public ResponseDTO<List<EmployeeDTO>> GetEmployees()
        {
            return _repository.GetEmployees();
        }

        public ResponseDTO<EmployeeDTO> GetEmployeeById(int idEmployee)
        {
            return _repository.GetEmployeeById(idEmployee);
        }
    }
}