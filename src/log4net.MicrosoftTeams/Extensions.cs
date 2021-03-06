﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace log4net.MicrosoftTeams
{

    internal static class Extensions
    {
        public static string Expand(this string text)
        {
            return text != null ? Environment.ExpandEnvironmentVariables(text) : null;
        }

        public static string FormatString(this log4net.Layout.ILayout layout, log4net.Core.LoggingEvent loggingEvent)
        {
            using (var writer = new StringWriter())
            {
                layout.Format(writer, loggingEvent);
                return writer.ToString();
            }
        }

    }
}

