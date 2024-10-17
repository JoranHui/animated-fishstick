namespace Program
{
    public interface ILogService
    {
        void Log(string message);
    }
    public class Rekenmachine
    {
        private readonly ILogService _logService;
        public Rekenmachine(ILogService logService)
        {
            _logService = logService;
        }
        public int TelOp(int a, int b)
        {
            _logService.Log($"Optellen: {a} + {b}");
            return a + b;
        }
        public int TrekAf(int a, int b)
        {
            _logService.Log($"Aftrekken: {a} - {b}");
            return a - b;
        }
        public int Vermenigvuldig(int a, int b)
        {
            _logService.Log($"Vermenigvuldigen: {a} * {b}");
            return a * b;
        }
        public double Deel(int a, int b)
        {
            if (b == 0)
            {
                _logService.Log("Delen door nul geprobeerd.");
                throw new ArgumentException("Kan niet delen door nul.");
            }
            _logService.Log($"Delen: {a} / {b}");
            return (double)a / b;
        }
    }
}
