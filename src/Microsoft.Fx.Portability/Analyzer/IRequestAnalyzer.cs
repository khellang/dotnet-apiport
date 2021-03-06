﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Fx.Portability.ObjectModel;

namespace Microsoft.Fx.Portability.Analyzer
{
    public interface IRequestAnalyzer
    {
        AnalyzeResponse AnalyzeRequest(AnalyzeRequest request, string submissionId);
    }
}