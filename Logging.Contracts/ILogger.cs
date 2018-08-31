using System;
namespace BM.MultiLayer.CrossCutting.Logging.Contracts
{
    public interface ILogger
    {
        void Write(string message);
    }
}
