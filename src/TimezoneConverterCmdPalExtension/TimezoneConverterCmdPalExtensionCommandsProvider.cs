// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;

namespace TimezoneConverterCmdPalExtension;

public partial class TimezoneConverterCmdPalExtensionCommandsProvider : CommandProvider
{
    private readonly ICommandItem[] _commands;

    public TimezoneConverterCmdPalExtensionCommandsProvider()
    {
        DisplayName = "Time Zone Converter";
        Icon = new IconInfo("\uE775");
        _commands = [
            new CommandItem(new global::TimezoneConverterCmdPalExtension.Pages.TimezoneConverterCmdPalExtensionPage()) { Title = DisplayName },
        ];
    }

    public override ICommandItem[] TopLevelCommands()
    {
        return _commands;
    }

}
