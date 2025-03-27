using Company.Data.Entites;
using Company.Service.Interfaces.Department.Dto;


namespace Company.Service.Interfaces
{
    public interface IDepartmentService
    {
        DepartmentDto GetById(int? id);

        IEnumerable<DepartmentDto> GetAll();

        void Add(DepartmentDto department);

        void Update(DepartmentDto department);

        void Delete(DepartmentDto department);
    }
}
