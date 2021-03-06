﻿//===============================================================================
// Microsoft patterns & practices
// Unity Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surveys.BlobContainers
{
  public interface IBlobContainer<T>
  {
    void EnsureExist();

    T Get(string objId);
    IEnumerable<IListBlobItemWithName> GetBlobList();
    Uri GetUri(string objId);

    void Delete(string objId);
    void DeleteContainer();

    void Save(string objId, T obj);
    void Save(T obj);
  }
}
