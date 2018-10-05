using Web.Builder.IBuilder;

namespace Web.Builder.ConcreteBuilder
{
    public class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem laptopComputerSystem = new ComputerSystem();
        //for fluent Builder design pattern replace void with ISystemBuilder
        //and return this; for method chaining
        public ISystemBuilder AddDrive(string size)
        {
            laptopComputerSystem.HDDSize = size;
            return this;
        }

        public ISystemBuilder AddKeyboard(string type)
        {
            return this;
        }

        public ISystemBuilder AddMemory(string memory)
        {
            laptopComputerSystem.RAM = memory;
            return this;
        }

        public ISystemBuilder AddMouse(string type)
        {
            return this;
        }

        public ISystemBuilder AddTouchScreen(string enabled)
        {
            laptopComputerSystem.TouchScreen = enabled;
            return this;
        }

        public ComputerSystem GetComputerSystem()
        {
            return laptopComputerSystem;
        }
    }
}