/*
 */

namespace System
{
    /// <summary>
    /// An attribute signifying that the specified member is only a stub to maintain compatibility with the WinForms API.
    /// </summary>
    public class EtoWinFormsCompatStubOnlyAttribute : Attribute
    {
        public EtoWinFormsCompatStubOnlyAttribute()
        {
        }
    }
}