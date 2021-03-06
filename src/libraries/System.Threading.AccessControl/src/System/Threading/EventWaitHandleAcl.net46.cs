// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Security.AccessControl;

namespace System.Threading
{
    public static class EventWaitHandleAcl
    {
        public static EventWaitHandle Create(
            bool initialState,
            EventResetMode mode,
            string? name,
            out bool createdNew,
            EventWaitHandleSecurity? eventSecurity)
        {
            return new EventWaitHandle(initialState, mode, name, out createdNew, eventSecurity);
        }
    }
}
