using System.Collections.Generic;


namespace Code.Base {
    internal class Controllers : List<IController> {
        private List<IFixedExecute> _fixedExecuteControllers;
        private List<IExecute> _executeControllers;

        public Controllers() {
            _fixedExecuteControllers = new List<IFixedExecute>();
            _executeControllers = new List<IExecute>();
        }

        public void Start() {
            foreach (var controller in this)
            {
                controller.Start();
            }
        }

        public new void Add(IController obj) {
            base.Add(obj);
            if(obj is IExecute execute)
                _executeControllers.Add(execute);
            if(obj is IFixedExecute fixedExecute)
                _fixedExecuteControllers.Add(fixedExecute);
        }

        public void Execute(float deltaTime) {
            foreach (var controller in _executeControllers)
            {
                controller.Execute(deltaTime);
            }
        }

        public void FixedExecute(float deltaTime) {
            foreach (var controller in _fixedExecuteControllers)
            {
                controller.FixedExecute(deltaTime);
            }
        }

        public void ClearUp() {
            foreach (var controller in this)
            {
                controller.ClearUp();
            }
        }
    }
}