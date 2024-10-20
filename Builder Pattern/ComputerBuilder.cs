using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    public class ComputerBuilder
    {
        private CPU _cpu;
        private Motherboard _motherboard;
        private RAM _ram;
        private Storage _storage;
        private GPU _gpu;

        public ComputerBuilder SetCPU(string model, int cores)
        {
            _cpu = new CPU(model, cores);
            return this;
        }

        public ComputerBuilder SetMotherboard(string model, string socket)
        {
            _motherboard = new Motherboard(model, socket);
            return this;
        }

        public ComputerBuilder SetRAM(string model, int size)
        {
            _ram = new RAM(model, size);
            return this;
        }

        public ComputerBuilder SetStorage(string type, int size)
        {
            _storage = new Storage(type, size);
            return this;
        }

        public ComputerBuilder SetGPU(string model, int memory)
        {
            _gpu = new GPU(model, memory);
            return this;
        }

        public Computer Build()
        {
            return new Computer
            {
                Processor = _cpu,
                Motherboard = _motherboard,
                Memory = _ram,
                Storage = _storage,
                GraphicsCard = _gpu
            };
        }
    }
}
