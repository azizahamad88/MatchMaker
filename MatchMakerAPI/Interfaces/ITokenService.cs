using System;
using MatchMakerAPI.Entities;

namespace MatchMakerAPI.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
