﻿// ﻿Copyright (c) Pavel Bakshy, Valeriy Ogiy. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Runtime.Serialization;

using OpenQA.Selenium;

namespace Selenol.Elements
{
    /// <summary>Indicates that element does not match restrictions.</summary>
    [Serializable]
    public class WrongElementException : Exception
    {
        /// <summary>Initializes a new instance of the <see cref="WrongElementException"/> class.</summary>
        /// <param name="message">The message. </param>
        /// <param name="webElement">The web element. </param>
        public WrongElementException(string message, IWebElement webElement)
            : base(message)
        {
            this.WebElement = webElement;
        }

        /// <summary>Initializes a new instance of the <see cref="WrongElementException"/> class.</summary>
        /// <param name="message">The message. </param>
        /// <param name="webElement">The web element. </param>
        /// <param name="innerException">The inner exception. </param>
        public WrongElementException(string message, IWebElement webElement, Exception innerException)
            : base(message, innerException)
        {
            this.WebElement = webElement;
        }

        /// <summary>Initializes a new instance of the <see cref="WrongElementException"/> class.</summary>
        /// <param name="info">The info. </param>
        /// <param name="context">The context. </param>
        protected WrongElementException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>Gets or sets the web element.</summary>
        public IWebElement WebElement { get; set; }
    }
}