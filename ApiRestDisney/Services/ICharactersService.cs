using ApiRestDisney.Models.DataModels;

namespace ApiRestDisney.Services
{
    public interface ICharactersService
    {
        IEnumerable<Character> GetCharacters();
        IEnumerable<Character> GetCharactersByName(string name);
        IEnumerable<Character> GetCharactersByAge(int age);
        IEnumerable<Character> GetCharactersWithMovies(int movieId);
    }
}
