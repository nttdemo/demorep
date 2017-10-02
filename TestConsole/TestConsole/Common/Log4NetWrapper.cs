using System;
using System.Text;
using log4net;

namespace TestConsole.Common
{
    public class Log4NetWrapper : ITestLog
    {
        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILog logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="Log4NetWrapper"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Log4NetWrapper(string name)
        {
            this.logger = LogManager.GetLogger(name);
        }

        #region "IUmbrellaProcessorLog"

        /// <summary>
        /// Gets a value indicating whether this instance is debug enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is debug enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsDebugEnabled
        {
            get
            {
                return this.logger.IsDebugEnabled;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is error enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is error enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsErrorEnabled
        {
            get
            {
                return this.logger.IsErrorEnabled;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is fatal enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is fatal enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsFatalEnabled
        {
            get
            {
                return this.logger.IsFatalEnabled;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is information enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is information enabled; otherwise, <c>false</c>.
        /// </value>
        public bool IsInfoEnabled
        {
            get
            {
                return this.logger.IsInfoEnabled;
            }
        }

        /// <summary>
        /// Write info message
        /// </summary>
        /// <param name="message">The message.</param>
        public void Info(params string[] message)
        {
            this.Info(null, message);
        }

        /// <summary>
        /// Write Info message
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public void Info(Exception exception, params string[] message)
        {
            if (!this.logger.IsInfoEnabled)
            {
                return;
            }

            var messageStr = new StringBuilder();
            foreach (string str in message)
            {
                messageStr.Append(str);
            }

            this.logger.Info(messageStr.ToString(), exception);
        }

        /// <summary>
        /// Debugs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Debug(params string[] message)
        {
            this.Debug(null, message);
        }

        /// <summary>
        /// Debugs the specified exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public void Debug(Exception exception, params string[] message)
        {
            if (!this.logger.IsDebugEnabled)
            {
                return;
            }

            var messageStr = new StringBuilder();
            foreach (string str in message)
            {
                messageStr.Append(str);
            }

            this.logger.Debug(messageStr.ToString(), exception);
        }

        /// <summary>
        /// Errors the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Error(params string[] message)
        {
            this.Error(null, message);
        }

        /// <summary>
        /// Errors the specified exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public void Error(Exception exception, params string[] message)
        {
            if (!this.logger.IsErrorEnabled)
            {
                return;
            }

            var messageStr = new StringBuilder();
            foreach (string str in message)
            {
                messageStr.Append(str);
            }

            this.logger.Error(messageStr.ToString(), exception);
        }

        /// <summary>
        /// Write fatal message
        /// </summary>
        /// <param name="message">The message.</param>
        public void Fatal(params string[] message)
        {
            this.Fatal(null, message);
        }

        /// <summary>
        /// Write fatal message
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="message">The message.</param>
        public void Fatal(Exception exception, params string[] message)
        {
            if (!this.logger.IsFatalEnabled)
            {
                return;
            }

            var messageStr = new StringBuilder();
            foreach (string str in message)
            {
                messageStr.Append(str);
            }

            this.logger.Fatal(messageStr.ToString(), exception);
        }
        #endregion
    }
}
