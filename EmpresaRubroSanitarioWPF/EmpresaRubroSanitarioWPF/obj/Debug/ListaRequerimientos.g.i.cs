﻿#pragma checksum "..\..\ListaRequerimientos.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C75E48A083490CD832A667ADA1493369D79BD9EB14B1EA054197298539269283"
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
    /// ListaRequerimientos
    /// </summary>
    public partial class ListaRequerimientos : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 14 "..\..\ListaRequerimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridRequerimientos;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\ListaRequerimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCrearRequerimiento;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\ListaRequerimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GridDatos;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\ListaRequerimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTipoRequerimiento;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\ListaRequerimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPrioridad;
        
        #line default
        #line hidden
        
        
        #line 176 "..\..\ListaRequerimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbPendienteResuelto;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\ListaRequerimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBuscarRequerimiento;
        
        #line default
        #line hidden
        
        
        #line 197 "..\..\ListaRequerimientos.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame FrameRequerimientos;
        
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
            System.Uri resourceLocater = new System.Uri("/EmpresaRubroSanitarioWPF;component/listarequerimientos.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ListaRequerimientos.xaml"
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
            this.GridRequerimientos = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.BtnCrearRequerimiento = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\ListaRequerimientos.xaml"
            this.BtnCrearRequerimiento.Click += new System.Windows.RoutedEventHandler(this.AgregarRequerimiento);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GridDatos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.cbTipoRequerimiento = ((System.Windows.Controls.ComboBox)(target));
            
            #line 153 "..\..\ListaRequerimientos.xaml"
            this.cbTipoRequerimiento.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BloquearPyPR);
            
            #line default
            #line hidden
            return;
            case 7:
            this.cbPrioridad = ((System.Windows.Controls.ComboBox)(target));
            
            #line 166 "..\..\ListaRequerimientos.xaml"
            this.cbPrioridad.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BloquearTRyPR);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbPendienteResuelto = ((System.Windows.Controls.ComboBox)(target));
            
            #line 179 "..\..\ListaRequerimientos.xaml"
            this.cbPendienteResuelto.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BloquearTRyP);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnBuscarRequerimiento = ((System.Windows.Controls.Button)(target));
            
            #line 188 "..\..\ListaRequerimientos.xaml"
            this.BtnBuscarRequerimiento.Click += new System.Windows.RoutedEventHandler(this.BuscarRequerimiento);
            
            #line default
            #line hidden
            return;
            case 10:
            this.FrameRequerimientos = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 4:
            
            #line 95 "..\..\ListaRequerimientos.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Eliminar);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 103 "..\..\ListaRequerimientos.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Actualizar);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
