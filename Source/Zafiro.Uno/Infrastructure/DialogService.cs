﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Zafiro.Core;
using Zafiro.Core.UI;

namespace Zafiro.Uno.Infrastructure
{
    public class DialogService : IDialogService
    {
        public Task Notice(string title, string content)
        {
            return new MessageDialog(content) { Title = title }.ShowAsync().AsTask();
        }

        public Task<Option> Interaction(string title, string markdown, IEnumerable<Option> options, string assetBasePath = "")
        {
            throw new NotSupportedException();
        }
    }
}