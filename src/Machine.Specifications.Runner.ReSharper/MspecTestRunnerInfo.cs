﻿using System.Reflection;
using JetBrains.Util;

namespace Machine.Specifications.Runner.ReSharper
{
    public static class MspecTestRunnerInfo
    {
        public static FileSystemPath Root = Assembly.GetExecutingAssembly().GetPath().Directory.Combine("TestRunner");

        public static FileSystemPath Adapters = Root.Combine(nameof (Adapters));
    }
}