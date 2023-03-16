// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using MediatR;

namespace Microsoft.Health.Dicom.Core.Messages.Retrieve;
public class RetrieveRenderedRequest : IRequest<RetrieveRenderedResponse>
{

    public RetrieveRenderedRequest(string studyInstanceUid, string seriesInstanceUid, string sopInstanceUid, IReadOnlyCollection<AcceptHeader> acceptHeaders)
    {
        StudyInstanceUid = studyInstanceUid;
        SeriesInstanceUid = seriesInstanceUid;
        SopInstanceUid = sopInstanceUid;
        ResourceType = ResourceType.Instance;
        AcceptHeaders = acceptHeaders;
    }

    public ResourceType ResourceType { get; }

    public IReadOnlyCollection<AcceptHeader> AcceptHeaders { get; }

    public string StudyInstanceUid { get; }

    public string SeriesInstanceUid { get; }

    public string SopInstanceUid { get; }
}