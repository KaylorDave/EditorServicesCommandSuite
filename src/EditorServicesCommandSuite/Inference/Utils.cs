using System.Management.Automation;
using System.Management.Automation.Internal;

namespace EditorServicesCommandSuite.Inference
{
    internal static class Utils
    {
        internal static object Base(object obj)
        {
            PSObject pso = obj as PSObject;
            if (pso == null)
            {
                return obj;
            }

            if (pso == AutomationNull.Value)
            {
                return null;
            }

            return pso.BaseObject;
        }
    }
}
