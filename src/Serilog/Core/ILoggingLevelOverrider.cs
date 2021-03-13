// Copyright 2013-2021 Serilog Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Serilog.Core;
using Serilog.Events;


namespace Serilog
{
    /// <summary>
    /// The implementation is used by the client to override the
    /// minimum logging level per scope.
    /// </summary>
    public interface ILoggingLevelOverrider
    {
        /// <summary>
        /// The current minimum level, below which no events
        /// should be generated.
        /// </summary>
        LogEventLevel MinimumLevel { get; set; }
    }
}
