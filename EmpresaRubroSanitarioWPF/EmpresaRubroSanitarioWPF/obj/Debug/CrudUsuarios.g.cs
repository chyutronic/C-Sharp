#pragma checksum "..\..\CrudUsuarios.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9988D927585040D011814EC36B85E0297159B6812279405A75FB2FA4F6E39D4B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using EmpresaRubroSanitarioWPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace EmpresaRubroSanitarioWPF {
    
    
    /// <summary>
    /// CrudUsuarios
    /// </summary>
    public partial class CrudUsuarios : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Titulo;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegresar;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCrear;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEliminar;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPrivilegio;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagen;
        
        #line default
        #line hidden
        
        
        #line 144 "..\..\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbNombreCrud;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbApellidoCrud;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbUsuarioCrud;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\CrudUsuarios.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbClaveCrud;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EmpresaRubroSanitarioWPF;component/crudusuarios.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CrudUsuarios.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Titulo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.BtnRegresar = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\CrudUsuarios.xaml"
            this.BtnRegresar.Click += new System.Windows.RoutedEventHandler(this.Regresar);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCrear = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\CrudUsuarios.xaml"
            this.BtnCrear.Click += new System.Windows.RoutedEventHandler(this.BtnCrear_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\CrudUsuarios.xaml"
            this.BtnEliminar.Click += new System.Windows.RoutedEventHandler(this.BtnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cbPrivilegio = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.imagen = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.tbNombreCrud = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.tbApellidoCrud = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbUsuarioCrud = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.tbClaveCrud = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

