using AutoMapper;
using Common.Dtos;
using Data.Common.GlobalDbServices.UserDbServices;
using MediartR.Test.Common.Queries;
using MediatR;

namespace MediartR.Test.Common.Handlers
{
    public class GetUserByUsernameHandler : IRequestHandler<GetUserByUsername, UserDto>
    {
        private readonly IUserDbService _userDbServie;
        private readonly IMapper _mapper;

        public GetUserByUsernameHandler(IUserDbService userDbServie, IMapper mapper)
        {
            _userDbServie = userDbServie;
            _mapper = mapper;
        }

        public async Task<UserDto> Handle(GetUserByUsername request, CancellationToken cancellationToken)
        {
            var result = await _userDbServie.GetUserByUsername(request.Username);
            return _mapper.Map<UserDto>(result);
        }
    }
}
