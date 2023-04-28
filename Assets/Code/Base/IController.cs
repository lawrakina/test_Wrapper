namespace Code.Base {
    internal interface IStartAndCleanUp {
        void Start();
        void ClearUp();
    }

    internal interface IController: IStartAndCleanUp {
    }
}