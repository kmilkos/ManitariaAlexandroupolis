﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.DC
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Model
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Persistent.Validation

'<DefaultListViewOptions(MasterDetailMode.ListViewOnly, False, NewItemRowPosition.None)> _
<DefaultProperty("Caption")>
<ImageName("BO_Contact")>
<Persistent("Category")>
<DefaultClassOptions()>
Public Class Category ' Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    End Sub

    Private _Caption As String
    Public Property Caption As String
        Get
            Return _Caption
        End Get
        Set(value As String)
            SetPropertyValue("Caption", _Caption, value)
        End Set
    End Property

    Private _department As Department
    Property Department As Department
        Get
            Return _department
        End Get
        Set(ByVal Value As Department)
            SetPropertyValue(Nameof(Department), _department, Value)
        End Set
    End Property
    

    <DevExpress.Xpo.AssociationAttribute("Taskv2s-Category")>
    Public ReadOnly Property Taskv2s As XPCollection(Of ManitariaAlexandroupolis.Module.Taskv2)
        Get
            Return GetCollection(Of ManitariaAlexandroupolis.Module.Taskv2)("Taskv2s")
        End Get
    End Property

    <DevExpress.Xpo.AssociationAttribute("TaskV3s-Category")>
    Public ReadOnly Property TaskV3s As XPCollection(Of ManitariaAlexandroupolis.Module.TaskV3)
        Get
            Return GetCollection(Of ManitariaAlexandroupolis.Module.TaskV3)("TaskV3s")
        End Get
    End Property

    <Association("Category-DailyLogs")>
    Public ReadOnly Property DailyLogs() As XPCollection(Of DailyLog)
        Get
            Return GetCollection(Of DailyLog)(NameOf(DailyLogs))
        End Get
    End Property
End Class
