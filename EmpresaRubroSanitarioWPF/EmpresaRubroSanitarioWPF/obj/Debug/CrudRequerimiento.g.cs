﻿#pragma checksum "..\..\CrudRequerimiento.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DC0029C6CB6FBD3E049BB04ABAAB2655CBCD7AF1F59FC5D28485E04C2A732DE8"
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
    /// CrudRequerimiento
    /// </summary>
    public partial class CrudRequerimiento : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\CrudRequerimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Titulo;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\CrudRequerimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRegresarListaReq;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\CrudRequerimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCrearReq;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\CrudRequerimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnActualizarReq;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\CrudRequerimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnEliminarReq;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\CrudRequerimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imagen;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\CrudRequerimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDescripcion;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\CrudRequerimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbEstado;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\CrudRequerimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTipoRequerimiento;
        
        #line default
        #line hidden
        
        
        #line 162 "..\..\CrudRequerimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPrioridad;
        
        #line default
        #line hidden
        
        
        #line 165 "..\..\CrudRequerimiento.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbResponsable;
        
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
            System.Uri resourceLocater = new System.Uri("/EmpresaRubroSanitarioWPF;component/crudrequerimiento.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CrudRequerimiento.xaml"
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
            this.BtnRegresarListaReq = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\CrudRequerimiento.xaml"
            this.BtnRegresarListaReq.Click += new System.Windows.RoutedEventHandler(this.Regresar);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCrearReq = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\CrudRequerimiento.xaml"
            this.BtnCrearReq.Click += new System.Windows.RoutedEventHandler(this.CrudCrearRequerimiento);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnActualizarReq = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\CrudRequerimiento.xaml"
            this.BtnActualizarReq.Click += new System.Windows.RoutedEventHandler(this.CrudActualizarRequerimiento);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnEliminarReq = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\CrudRequerimiento.xaml"
            this.BtnEliminarReq.Click += new System.Windows.RoutedEventHandler(this.CrudEliminarRequerimiento);
            
            #line default
            #line hidden
            return;
            case 6:
            this.imagen = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.tbDescripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cbEstado = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.cbTipoRequerimiento = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.cbPrioridad = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.cbResponsable = ((System.Windows.Controls.ComboBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

