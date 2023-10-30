using NetCoreApplicationUnitTest.Models;

namespace NetCoreApplicationUnitTest.Services
{
    public interface IAutoService
    {
        public IEnumerable<Auto> GetAutos();
        public Auto? GetAuto(int IdAuto);
    }
}
