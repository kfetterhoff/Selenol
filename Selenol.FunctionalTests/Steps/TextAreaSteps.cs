﻿// ﻿Copyright (c) Pavel Bakshy, Valeriy Ogiy. All rights reserved. See License.txt in the project root for license information.

using FluentAssertions;

using OpenQA.Selenium;

using Selenol.Elements;

using TechTalk.SpecFlow;

namespace Selenol.FunctionalTests.Steps
{
    [Binding]
    public class TextAreaSteps
    {
        [When(@"I clear text area with id ""(.*)""")]
        public void WhenIClearTextAreaWithId(string id)
        {
            GetTextArea(id).Clear();
        }

        [When(@"I type text ""(.*)"" to text area with id ""(.*)""")]
        public void WhenITypeTextToTextAreaWithId(string text, string id)
        {
            GetTextArea(id).TypeText(text);
        }

        [Then(@"text ""(.*)"" appears in text area with id ""(.*)""")]
        public void ThenTextAppearsInTextAreaWithId(string text, string id)
        {
            GetTextArea(id).Text.Should().Be(text);
        }

        private static TextAreaElement GetTextArea(string id)
        {
            return Browser.Current.TextArea(By.Id(id));
        }
    }
}