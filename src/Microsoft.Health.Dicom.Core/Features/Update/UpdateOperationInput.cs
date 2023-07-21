// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Microsoft.Health.Dicom.Core.Features.Update;

public class UpdateOperationInput
{
    public int PartitionKey { get; set; }

    public IReadOnlyList<string> StudyInstanceUids { get; set; }

    public string ChangeDataset { get; set; }
}