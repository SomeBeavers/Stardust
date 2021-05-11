using System;

namespace MyNamespace
{
    internal interface IMyClass
    {
        void Test();
    }

    class MyClass : IMyClass
    {
        public byte LeftTeamId { get; private set; }
        public event Action OnClear;
        public event Action OnParticipantsInitialize;
        public event Action OnLeftForeParticipantIdChange;
        public event Action OnRightForeParticipantIdChange;
        public event Action<OneBattleParticipantModel> OnParticipantAdded;
        public event Action<OneBattleParticipantModel> OnParticipantRemoved;
        public string Name { get; set; }

        public void Test1()
        {
        }
    }

    internal class OneBattleParticipantModel
    {
    }
}