using AutoMapper;
using Common.Dtos;
using Data.Common.GlobalDbServices.UserDbServices;
using MediartR.Test.Common.Queries;
using MediatR;

namespace MediartR.Test.Common.Handlers
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<UserDto>>
    {
        private readonly IUserDbService _userDbServie;
        private readonly IMapper _mapper;

        public GetAllUsersHandler(IUserDbService userDbServie, IMapper mapper)
        {
            _userDbServie = userDbServie;
            _mapper = mapper;
        }

        public async Task<List<UserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var result = await _userDbServie.GetAllUsers();
            return _mapper.Map<List<UserDto>>(result);
        }
    }
}
