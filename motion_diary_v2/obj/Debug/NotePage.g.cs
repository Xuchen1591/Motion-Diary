﻿

#pragma checksum "C:\Users\旭晨\Documents\Visual Studio 2013\Projects\motion_diary_v2\motion_diary_v2\NotePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "84092216EFEDBCF0AF21BF85F87C641C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace motion_diary_v2
{
    partial class NotePage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 71 "..\..\NotePage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.ItemListView_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 77 "..\..\NotePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.motion1Taped;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 78 "..\..\NotePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.motion2Taped;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 79 "..\..\NotePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.motion3Taped;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 80 "..\..\NotePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.motion4Taped;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 81 "..\..\NotePage.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.motion5Taped;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

