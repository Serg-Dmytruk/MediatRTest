using Common.Dtos;
using MediatR;

namespace MediartR.Test.Common.Queries
{
    public class GetUserByUsername : IRequest<UserDto>
    {
        public string Username { get; set; }
    }
}
