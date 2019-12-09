using System;

namespace Zafiro.Uwp.ObjEditor
{
    public class EditorKey
    {
        public Type TargetType => Type.GetType(TargetTypeString);
        public string TargetTypeString { get; set; }

        public string PropertyName { get; set; }
    }
}