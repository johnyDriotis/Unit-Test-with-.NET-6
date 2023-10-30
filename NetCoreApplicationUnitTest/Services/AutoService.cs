using NetCoreApplicationUnitTest.Models;

namespace NetCoreApplicationUnitTest.Services
{
    public class AutoService : IAutoService
    {
        // Datos para lista
        private List<Auto> autos = new List<Auto>()
        {
            new Auto(){ Id = 1, Brand = "Toyota", ProductionYear = new DateTime(1990,01,01), Doors = 4, Color = "Negro" },
            new Auto(){ Id = 2, Brand = "Nissan", ProductionYear = new DateTime(1985,01,01), Doors = 4, Color = "Blanco" }
        };

        public Auto? GetAuto(int IdAuto) => autos.Where(x => x.Id == IdAuto).FirstOrDefault();

        public IEnumerable<Auto> GetAutos() => autos;
    }
}
