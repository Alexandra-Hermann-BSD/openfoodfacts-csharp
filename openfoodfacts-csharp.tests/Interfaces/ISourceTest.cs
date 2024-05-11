// openfoodfacts-csharp
//     OpenFoodFacts-CSharp.Tests
//     ISourceTest.cs
// 
//     Copyright 2024 Alexandra Hermann – Beratung, Software, Design
// 
//     Licensed under the Apache License, Version 2.0 (the "License");
//     you may not use this file except in compliance with the License.
//     You may obtain a copy of the License at
// 
//         http://www.apache.org/licenses/LICENSE-2.0
// 
//     Unless required by applicable law or agreed to in writing, software
//     distributed under the License is distributed on an "AS IS" BASIS,
//     WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//     See the License for the specific language governing permissions and
//     limitations under the License.

using JetBrains.Annotations;
using OpenFoodFactsCSharp.EventArguments;
using OpenFoodFactsCSharp.Interfaces;
using OpenFoodFactsCSharp.Models;
using Xunit;

namespace OpenFoodFacts.CSharp.Tests.Interfaces
{
    [TestSubject(typeof(ISource))]
    public class ISourceTest
    {

        [Fact]
        public void TestNameChanged()
        {
            ISource source = new Source();
            source.Name = "Source";
            source.NameChanged += Source_OnNameChanged;

            source.Name = "New value";
        }

        private void Source_OnNameChanged(object sender, ChangeEventArgs<string> e)
        {
            Assert.NotEqual(e.OldValue, e.NewValue);
        }
    }
}