using Microsoft.AspNetCore.Mvc;
using NetCoreApplicationUnitTest.Controllers;
using NetCoreApplicationUnitTest.Models;
using NetCoreApplicationUnitTest.Services;

namespace NetCoreApplicationUnitTest.Testing
{
    public class UnitTest
    {
        // Declaracion de objetos
        private readonly AutoController _autoController;
        private readonly IAutoService _autoService;

        // Constructor
        public UnitTest() {
            this._autoService = new AutoService();
            this._autoController = new AutoController(_autoService);
        }

        #region Pruebas unitarias para GetAutos()

        [Fact] // Los Fact son ruebas que se tendran que ejecutar
        public void validarSiTieneDatosDevuelvaOk()
        {
            // Arrage
            // Preparacion de la prueba

            // Act
            // Ejecucion de lo que se necesita
            var result = _autoController.GetAutos();

            //Assert
            // Si cumple o no la prueba unitaria
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact] // Los Fact son ruebas que se tendran que ejecutar
        public void validarQueSeaDiferenteNulo()
        {
            // Arrage
            // Preparacion de la prueba

            // Act
            // Ejecucion de lo que se necesita
            var result = _autoController.GetAutos();

            // Assert
            // Si cumple o no la prueba unitaria
            Assert.NotNull(result);
        }

        [Fact] // Los Fact son ruebas que se tendran que ejecutar
        public void validarSiEsNullDevuelvaNotFound()
        {
            // Arrage
            // Preparacion de la prueba

            // Act
            // Ejecucion de lo que se necesita
            var result = _autoController.GetAutos();

            // Assert
            if (result == null)
            {
                // Si cumple o no la prueba unitaria
                Assert.IsType<NotFoundObjectResult>(result);
            }
        }

        [Fact] // Los Fact son ruebas que se tendran que ejecutar
        public void validarSiEsNull()
        {
            // Arrage
            // Preparacion de la prueba

            // Act
            // Ejecucion de lo que se necesita
            var result = _autoController.GetAutos();
            result = null;

            // Assert
            // Si cumple o no la prueba unitaria
            Assert.Null(result);
        }

        [Fact] // Los Fact son ruebas que se tendran que ejecutar
        public void obtenerCantidadAutos()
        {
            // Arrage
            // Preparacion de la prueba

            // Act
            // Ejecucion de lo que se necesita
            var result = (OkObjectResult) _autoController.GetAutos();

            // Assert
            // Si cumple o no la prueba unitaria
            var autos = Assert.IsType<List<Auto>>(result.Value);
            Assert.True(autos.Count > 0);
        }

        #endregion 

        #region Pruebas unitarias para GetAutoById(IdAuto)

        [Fact]
        public void validarSeEncuentreIdAuto() {

            // Arrage
            // Preparacion de la prueba
            int id = 2;

            // Act
            // Ejecucion de lo que se necesita
            var result = _autoController.GetAutoById(id);

            // Assert
            // Si cumple o no la prueba unitaria
            Assert.IsType<OkObjectResult>(result);
        }

        #endregion
    }
}