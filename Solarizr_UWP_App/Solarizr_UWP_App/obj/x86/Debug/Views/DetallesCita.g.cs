﻿#pragma checksum "D:\GS DAM\Repositorios\DEINT\Solarizr_UWP_App\Solarizr_UWP_App\Views\DetallesCita.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "062E07E41E34F1A84050315E637E5AA2F25F012B74C8C78F02064E2FBFCE662F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solarizr_UWP_App.Views
{
    partial class DetallesCita : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\DetallesCita.xaml line 15
                {
                    this.back = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.back).Click += this.back_Click;
                }
                break;
            case 3: // Views\DetallesCita.xaml line 16
                {
                    this.datosPrincipales = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 4: // Views\DetallesCita.xaml line 21
                {
                    this.linea = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 5: // Views\DetallesCita.xaml line 26
                {
                    this.tablilla = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6: // Views\DetallesCita.xaml line 39
                {
                    this.user = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Views\DetallesCita.xaml line 40
                {
                    this.userData = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Views\DetallesCita.xaml line 41
                {
                    this.password = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // Views\DetallesCita.xaml line 42
                {
                    this.passwordData = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 10: // Views\DetallesCita.xaml line 17
                {
                    this.num = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Views\DetallesCita.xaml line 18
                {
                    this.idCita = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Views\DetallesCita.xaml line 19
                {
                    this.nombreCita = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

