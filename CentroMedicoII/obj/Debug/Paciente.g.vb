﻿#ExternalChecksum("..\..\Paciente.xaml","{ff1816ec-aa5e-4d10-87f7-6f4963833460}","E0CA136B70F4817298EF150B5C10471701F76956")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports CentroMedico
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''Paciente
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Paciente
    Inherits System.Windows.Window
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\Paciente.xaml",28)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnagregar As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Paciente.xaml",29)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtbusqueda As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Paciente.xaml",30)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnbuscar As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Paciente.xaml",34)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents lst_paciente As System.Windows.Controls.ListView
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\Paciente.xaml",45)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btn_volver As System.Windows.Controls.Label
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/CentroMedicoII;component/paciente.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\Paciente.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            
            #ExternalSource("..\..\Paciente.xaml",8)
            AddHandler CType(target,Paciente).Loaded, New System.Windows.RoutedEventHandler(AddressOf Me.Window_Loaded)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 2) Then
            Me.btnagregar = CType(target,System.Windows.Controls.Label)
            
            #ExternalSource("..\..\Paciente.xaml",28)
            AddHandler Me.btnagregar.MouseDoubleClick, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.btnagregar_MouseDoubleClick)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 3) Then
            Me.txtbusqueda = CType(target,System.Windows.Controls.TextBox)
            
            #ExternalSource("..\..\Paciente.xaml",29)
            AddHandler Me.txtbusqueda.MouseDoubleClick, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.txtbusqueda_MouseDoubleClick)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 4) Then
            Me.btnbuscar = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 5) Then
            Me.lst_paciente = CType(target,System.Windows.Controls.ListView)
            
            #ExternalSource("..\..\Paciente.xaml",34)
            AddHandler Me.lst_paciente.MouseDoubleClick, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.ListView_MouseDoubleClick)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 6) Then
            Me.btn_volver = CType(target,System.Windows.Controls.Label)
            
            #ExternalSource("..\..\Paciente.xaml",45)
            AddHandler Me.btn_volver.MouseDoubleClick, New System.Windows.Input.MouseButtonEventHandler(AddressOf Me.btn_volver_MouseDoubleClick)
            
            #End ExternalSource
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

