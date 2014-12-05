using Microsoft.Framework.Runtime;
using System;

namespace Dependency.compiler.preprocess
{
    public class Class : ICompileModule
    {
        public Class(IApplicationEnvironment applicationEnvironment)
        {
            Console.WriteLine("Name: \{applicationEnvironment.ApplicationName}");
        }
        public void BeforeCompile(IBeforeCompileContext context)
        {
        }

        public void AfterCompile(IAfterCompileContext context)
        {
        }
    }
}