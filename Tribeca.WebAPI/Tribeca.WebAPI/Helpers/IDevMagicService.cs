namespace Tribeca.WebAPI.Helpers
{
    public interface IDevMagicService
    {
        string TransformToDevMagic(string input);
        string TransformFromDevMagic(string input);
    }
}
