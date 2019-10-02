using Web.Builder.IBuilder;

namespace Web.Builder.ConcreteBuilder
{
    public class DesktopBuilder:ISystemBuilder
    {
        ComputerSystem desktopComputerSystem = new ComputerSystem();

        ///for fluent Builder design pattern replace void with ISystemBuilder
        public ISystemBuilder AddDrive(string size)
        {
            desktopComputerSystem.HDDSize = size;
            return this;
        }

        public ISystemBuilder AddKeyboard(string type)
        {
            desktopComputerSystem.KeyBoard = type;
            return this;
        }

        public ISystemBuilder AddMemory(string memory)
        {
            desktopComputerSystem.RAM = memory;
            return this;
        }

        public ISystemBuilder AddMouse(string type)
        {
            desktopComputerSystem.Mouse = type;
            return this;
        }

        public ISystemBuilder AddTouchScreen(string enabled)
        {
            return this;
        }

        public ComputerSystem GetComputerSystem()
        {
            return desktopComputerSystem;
        }
    }
}