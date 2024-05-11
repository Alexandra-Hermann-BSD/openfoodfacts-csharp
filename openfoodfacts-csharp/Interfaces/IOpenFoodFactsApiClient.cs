// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Net.Http;
using System.Threading.Tasks;
using OpenFoodFactsCSharp.Models;

namespace OpenFoodFactsCSharp.Interfaces
{
    /// <summary>
    /// Interface for an OpenFoodFacts API client
    /// </summary>
    public interface IOpenFoodFactsApiClient
    {
        /// <summary>
        /// Fetches an asynchronous task (of <see cref="ProductResponse"/>) for a given <paramref name="code"/>.
        /// </summary>
        /// <param name="code">The given code</param>
        /// <returns>The asynchronous task</returns>
        /// <exception cref="HttpRequestException">If no successful response was available for the given <paramref name="code"/></exception>
        Task<ProductResponse> FetchProductByCodeAsync(string code);
    }
}
