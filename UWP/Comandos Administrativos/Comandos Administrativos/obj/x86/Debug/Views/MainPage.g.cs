﻿#pragma checksum "C:\Users\skq09\source\repos\Comandos Administrativos\Comandos Administrativos\Views\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AFF1D44A35BB2E195CE979D6FEB0D6B18C9909C81374937CBDFD2D88EE2A6FE8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Comandos_Administrativos.Views
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\MainPage.xaml line 9
                {
                    this.ContentArea = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // Views\MainPage.xaml line 63
                {
                    this.ResultBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Views\MainPage.xaml line 18
                {
                    this.IP_Information = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.IP_Information).Click += this.IP_Information_Click;
                }
                break;
            case 5: // Views\MainPage.xaml line 24
                {
                    this.ActivateAdminAccount = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ActivateAdminAccount).Click += this.ActivateAdminAccount_Click;
                }
                break;
            case 6: // Views\MainPage.xaml line 30
                {
                    this.DeactivateAdminAccount = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.DeactivateAdminAccount).Click += this.DeactivateAdminAccount_Click;
                }
                break;
            case 7: // Views\MainPage.xaml line 36
                {
                    this.WindowsVersion = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.WindowsVersion).Click += this.WindowsVersion_Click;
                }
                break;
            case 8: // Views\MainPage.xaml line 42
                {
                    this.Key = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Key).Click += this.Key_Click;
                }
                break;
            case 9: // Views\MainPage.xaml line 48
                {
                    this.FullInfo = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.FullInfo).Click += this.FullInfo_Click;
                }
                break;
            case 10: // Views\MainPage.xaml line 54
                {
                    this.ClearButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ClearButton).Click += this.ClearButton_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

