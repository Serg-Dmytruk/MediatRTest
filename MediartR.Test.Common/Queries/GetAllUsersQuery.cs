using Common.Dtos;
using MediatR;

namespace MediartR.Test.Common.Queries
{
    public class GetAllUsersQuery : IRequest<List<UserDto>>
    {
    }
}
