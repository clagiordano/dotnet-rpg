using System.Collections.Generic;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAll();
         Character GetById(int id);
         List<Character> AddCharacter(Character newCharacter);
    }
}