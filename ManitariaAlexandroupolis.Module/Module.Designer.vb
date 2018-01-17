Imports Microsoft.VisualBasic
Imports System

Partial Public Class ManitariaAlexandroupolisModule
    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Component Designer generated code"

    ''' <summary> 
    ''' Required method for Designer support - do not modify 
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        '
        'ManitariaAlexandroupolisModule
        '
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.BaseObject))
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Xpo.XPCustomObject))
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Xpo.XPBaseObject))
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Xpo.PersistentBase))
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Address))
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Country))
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Note))
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.PhoneNumber))
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Party))
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Person))
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.PhoneType))
        Me.AdditionalExportedTypes.Add(GetType(DevExpress.Persistent.BaseImpl.Analysis))
        Me.AdditionalExportedTypes.Add(GetType(DomainComponents.Common.IPersistentRecurrentEvent))
        Me.AdditionalExportedTypes.Add(GetType(DomainComponents.Common.IPersistentEvent))
        Me.AdditionalExportedTypes.Add(GetType(DomainComponents.Common.IPersistentResource))
        Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.SystemModule.SystemModule))
        Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule))
        Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.Chart.ChartModule))
        Me.RequiredModuleTypes.Add(GetType(DevExpress.ExpressApp.ReportsV2.ReportsModuleV2))

    End Sub

#End Region
End Class
