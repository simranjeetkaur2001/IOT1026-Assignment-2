namespace Assignment
{
    class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        public TreasureChest()
        {
            throw new NotImplementedException();
        }

        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            throw new NotImplementedException();
        }

        public State? Manipulate(Action action)
        {
            throw new NotImplementedException();
        }

        private void Unlock()
        {
            throw new NotImplementedException();
        }

        private void Lock()
        {
            throw new NotImplementedException();
        }

        private void Open()
        {
            throw new NotImplementedException();
        }

        private void Close()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        private static void ConsoleHelper(string prop1, string prop2, string prop3)
        {
            Console.WriteLine($"Choose from the following properties.\n1.{prop1}\n2.{prop2}\n3.{prop3}");
        }

        public enum State { Open, Closed, Locked };
        public enum Action { Open, Close, Lock, Unlock };
        public enum Material { Oak, RichMahogany, Iron };
        public enum LockType { Novice, Intermediate, Expert };
        public enum LootQuality { Grey, Green, Purple };
    }
}
