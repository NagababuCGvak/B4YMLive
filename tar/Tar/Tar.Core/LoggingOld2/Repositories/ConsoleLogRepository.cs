using System;
using System.Text;
using Tar.Core.LoggingOld2.Serialization;

namespace Tar.Core.LoggingOld2.Repositories
{
    class ConsoleLogRepository:LogRepository
    {
        #region Implementation of ILogRepository
        private const string Line = "------------------------------------";

        public ConsoleLogRepository(IMessageSerializer serializer) : base(serializer)
        {
        }

        public override void Log(IWriteToLogParameter parameter)
        {
            var log = new StringBuilder()
                .AppendLine(Line)
                .AppendLine(string.Format("ActiveUserName:{0}", parameter.ActiveUserName))
                .AppendLine(string.Format("AppFolder:{0}", parameter.AppFolder))
                .AppendLine(string.Format("AppName:{0}", parameter.AppName))
                .AppendLine(string.Format("AssemblyName:{0}", parameter.AssemblyName))
                .AppendLine(string.Format("BuildMode:{0}", parameter.BuildMode))
                .AppendLine(string.Format("ClassName:{0}", parameter.ClassName))
                .AppendLine(string.Format("DateTime:{0}", parameter.DateTime))
                .AppendLine(string.Format("IpAddress:{0}", parameter.IpAddress))
                .AppendLine(string.Format("IsWebApplication:{0}", parameter.IsWebApplication))
                .AppendLine(string.Format("Level:{0}", parameter.Level))
                .AppendLine(string.Format("Process:{0}", parameter.Process))
                .AppendLine(string.Format("ProcessCode:{0}", parameter.ProcessCode))
                .AppendLine(string.Format("ScopeLevel:{0}", parameter.ScopeLevel))
                .AppendLine(string.Format("SerializedMessage:{0}", parameter.SerializedMessage))
                .AppendLine();
            Console.WriteLine(log);
        }
        #endregion
    }
}
