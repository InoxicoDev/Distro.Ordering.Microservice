using NLog;
using System;

namespace Distro.Seedworks.Infrastructure
{
    public class LogWriter
    {
        private ILogger logger { get; set; }

        private string GetErrorReference()
        {
            return Guid.NewGuid().ToString();
        }

        public LogWriter(ILogger? existing_logger = null)
        {
            logger = existing_logger ?? LogManager.GetCurrentClassLogger();
        }

        public string Trace(string message, Exception? exception = null)
        {
            var reference = GetErrorReference();

            if (exception != null)
            {
                logger.Trace(exception, message);
            }
            else
            {
                logger.Trace(message);
            }

            return reference;
        }

        public string Debug(string message, Exception? exception = null)
        {
            var reference = GetErrorReference();

            if (exception != null)
            {
                logger.Debug(exception, message);
            }
            else
            {
                logger.Debug(message);
            }

            return reference;
        }

        public string Info(string message, Exception? exception = null)
        {
            var reference = GetErrorReference();

            if (exception != null)
            {
                logger.Info(exception, message);
            }
            else
            {
                logger.Info(message);
            }

            return reference;
        }

        public string Warn(string message, Exception? exception = null)
        {
            var reference = GetErrorReference();

            if (exception != null)
            {
                logger.Warn(exception, message);
            }
            else
            {
                logger.Warn(message);
            }

            return reference;
        }

        public string Error(Exception exception)
        {
            var reference = GetErrorReference();
            logger.Error(exception);
            return reference;
        }

        public string Error(string message, Exception? exception = null)
        {
            var reference = GetErrorReference();

            if (exception != null)
            {
                logger.Error(exception, message);
            }
            else
            {
                logger.Error(message);
            }

            return reference;
        }

        public string Fatal(Exception exception)
        {
            var reference = GetErrorReference();
            logger.Fatal(exception);
            return reference;
        }

        public string Fatal(string message, Exception? exception = null)
        {
            var reference = GetErrorReference();

            if (exception != null)
            {
                logger.Fatal(exception, message);
            }
            else
            {
                logger.Fatal(message);
            }

            return reference;
        }
    }
}
