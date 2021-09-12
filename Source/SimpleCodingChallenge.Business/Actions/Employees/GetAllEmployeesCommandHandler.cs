using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;

using SimpleCodingChallenge.Common.DTO;
using SimpleCodingChallenge.DataAccess.Database;
using System.Collections.Generic;

using System.Threading;
using System.Threading.Tasks;

namespace SimpleCodingChallenge.Business.Actions.Employees
{
    public class GetAllEmployeesCommand : IRequest<GetAllEmployeesCommandResponse>
    {

    }

    //public record AddProductCommand(EmployeeDto EmployeeDto) : IRequest;

    //public class FakeData
    //{
    //    private static List<EmployeeDto> _employeeDto;

    //    public FakeData()
    //    {
    //        _employeeDto = new List<EmployeeDto>
    //    {
    //        new EmployeeDto { EmployeeID = "UC002", FirstName = "Blair" },
    //        new EmployeeDto { EmployeeID = "UC001", FirstName = "Minna" }


    //    };
    //    }

    //    public async Task AddEmployee(EmployeeDto employeeDto)
    //    {
    //        _employeeDto.Add(employeeDto);
    //        await Task.CompletedTask;
    //    }

    //    public async Task<IEnumerable<EmployeeDto>> GetAllProducts() => await Task.FromResult(_employeeDto);
    //}





    //public class AddProductHandler : IRequestHandler<AddProductCommand, Unit>
    //{
    //private readonly FakeData _fakeData;

    //    public AddProductHandler(FakeData fakeDataStore) => _fakeData = fakeDataStore;

    //    public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
    //    {
    //        await _fakeData.AddEmployee(request.EmployeeDto);

    //        return Unit.Value;
    //    }
    //}

    public class GetAllEmployeesCommandResponse
    {
        public List<EmployeeDto> EmployeeList { get; set; }

    }
    //public class MyDbContext : DbContext
    //{
    //    public DbSet<EmployeeDto> As { get; private set; } // or public setters


    //}

    //public class getEmployeebyid
    //{
    //    public EmployeeID { get; set; }
    //}


    public class GetAllEmployeesCommandHandler : IRequestHandler<GetAllEmployeesCommand, GetAllEmployeesCommandResponse>
    {
        private readonly SimpleCodingChallengeDbContext dbContext;
        private readonly IMapper mapper;

        public GetAllEmployeesCommandHandler(SimpleCodingChallengeDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<GetAllEmployeesCommandResponse> Handle(GetAllEmployeesCommand request, CancellationToken cancellationToken)
        {
            var employees = await dbContext.Employees.ToListAsync();
            var dataList = mapper.Map<List<EmployeeDto>>(employees);
            return new GetAllEmployeesCommandResponse
            {
                EmployeeList = dataList
            };


        }

    }
}
