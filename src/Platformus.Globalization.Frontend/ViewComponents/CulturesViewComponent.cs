﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using ExtCore.Data.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Platformus.Barebone.Frontend.ViewComponents;
using Platformus.Globalization.Frontend.ViewModels.Shared;

namespace Platformus.Globalization.Frontend.ViewComponents
{
  public class CulturesViewComponent : ViewComponentBase
  {
    public CulturesViewComponent(IStorage storage)
      : base(storage)
    {
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
      return this.View(new CulturesViewModelBuilder(this).Build());
    }
  }
}