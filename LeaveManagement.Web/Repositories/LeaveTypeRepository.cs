using AutoMapper;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public LeaveTypeRepository(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
