Imports Microsoft.VisualBasic
Imports System

Partial Public Class ManitariaAlexandroupolisWindowsFormsApplication
    ''' <summary> 
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary> 
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed otherwise, false.</param>
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
        Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
        Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
        Me.objectsModule = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
        Me.PivotChartWindowsFormsModule1 = New DevExpress.ExpressApp.PivotChart.Win.PivotChartWindowsFormsModule()
        Me.PivotChartModuleBase1 = New DevExpress.ExpressApp.PivotChart.PivotChartModuleBase()
        Me.FileAttachmentsWindowsFormsModule1 = New DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule()
        Me.ConditionalAppearanceModule1 = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
        Me.ChartWindowsFormsModule1 = New DevExpress.ExpressApp.Chart.Win.ChartWindowsFormsModule()
        Me.ChartModule1 = New DevExpress.ExpressApp.Chart.ChartModule()
        Me.ReportsWindowsFormsModuleV21 = New DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2()
        Me.ReportsModuleV21 = New DevExpress.ExpressApp.ReportsV2.ReportsModuleV2()
        Me.SchedulerWindowsFormsModule1 = New DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule()
        Me.SchedulerModuleBase1 = New DevExpress.ExpressApp.Scheduler.SchedulerModuleBase()
        Me.KpiModule1 = New DevExpress.ExpressApp.Kpi.KpiModule()
        Me.ValidationModule1 = New DevExpress.ExpressApp.Validation.ValidationModule()
        Me.module3 = New ManitariaAlexandroupolis.[Module].ManitariaAlexandroupolisModule()
        Me.module4 = New ManitariaAlexandroupolis.[Module].Win.ManitariaAlexandroupolisWindowsFormsModule()
        Me.ViewVariantsModule1 = New DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PivotChartModuleBase1
        '
        Me.PivotChartModuleBase1.DataAccessMode = DevExpress.ExpressApp.CollectionSourceDataAccessMode.Client
        Me.PivotChartModuleBase1.ShowAdditionalNavigation = False
        '
        'ReportsModuleV21
        '
        Me.ReportsModuleV21.EnableInplaceReports = True
        Me.ReportsModuleV21.ReportDataType = GetType(DevExpress.Persistent.BaseImpl.ReportDataV2)
        '
        'ValidationModule1
        '
        Me.ValidationModule1.AllowValidationDetailsAccess = True
        Me.ValidationModule1.IgnoreWarningAndInformationRules = False
        '
        'ManitariaAlexandroupolisWindowsFormsApplication
        '
        Me.ApplicationName = "ManitariaAlexandroupolis"
        Me.Modules.Add(Me.module1)
        Me.Modules.Add(Me.module2)
        Me.Modules.Add(Me.objectsModule)
        Me.Modules.Add(Me.ChartModule1)
        Me.Modules.Add(Me.ReportsModuleV21)
        Me.Modules.Add(Me.module3)
        Me.Modules.Add(Me.FileAttachmentsWindowsFormsModule1)
        Me.Modules.Add(Me.module4)
        Me.Modules.Add(Me.PivotChartModuleBase1)
        Me.Modules.Add(Me.PivotChartWindowsFormsModule1)
        Me.Modules.Add(Me.ConditionalAppearanceModule1)
        Me.Modules.Add(Me.ChartWindowsFormsModule1)
        Me.Modules.Add(Me.ReportsWindowsFormsModuleV21)
        Me.Modules.Add(Me.SchedulerModuleBase1)
        Me.Modules.Add(Me.SchedulerWindowsFormsModule1)
        Me.Modules.Add(Me.ValidationModule1)
        Me.Modules.Add(Me.KpiModule1)
        Me.Modules.Add(Me.ViewVariantsModule1)
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
    Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
    Private module3 As ManitariaAlexandroupolis.Module.ManitariaAlexandroupolisModule
    Private module4 As ManitariaAlexandroupolis.Module.Win.ManitariaAlexandroupolisWindowsFormsModule
    Private objectsModule As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
    Friend WithEvents PivotChartWindowsFormsModule1 As DevExpress.ExpressApp.PivotChart.Win.PivotChartWindowsFormsModule
    Friend WithEvents PivotChartModuleBase1 As DevExpress.ExpressApp.PivotChart.PivotChartModuleBase
    Friend WithEvents FileAttachmentsWindowsFormsModule1 As DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule
    Friend WithEvents ConditionalAppearanceModule1 As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
    Friend WithEvents ChartWindowsFormsModule1 As DevExpress.ExpressApp.Chart.Win.ChartWindowsFormsModule
    Friend WithEvents ChartModule1 As DevExpress.ExpressApp.Chart.ChartModule
    Friend WithEvents ReportsWindowsFormsModuleV21 As DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2
    Friend WithEvents ReportsModuleV21 As DevExpress.ExpressApp.ReportsV2.ReportsModuleV2
    Friend WithEvents SchedulerWindowsFormsModule1 As DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule
    Friend WithEvents SchedulerModuleBase1 As DevExpress.ExpressApp.Scheduler.SchedulerModuleBase
    Friend WithEvents KpiModule1 As DevExpress.ExpressApp.Kpi.KpiModule
    Friend WithEvents ValidationModule1 As DevExpress.ExpressApp.Validation.ValidationModule
    Friend WithEvents ViewVariantsModule1 As DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule
End Class
