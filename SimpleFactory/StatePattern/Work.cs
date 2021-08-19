using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Work
    {
        public StateBase _stateNow;

        public Work()
        {
            _stateNow = new ForenoonState();
        }

        public int Hour { get; set; }

        public bool FinishWork { get; set; }

        public void SetState(StateBase state)
        {
            _stateNow = state;
        }

        public void WriteProgram()
        {
            _stateNow.WriteProgram(this);
        }
    }
}
