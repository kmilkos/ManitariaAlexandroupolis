Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.Base.General
Imports DevExpress.Persistent.BaseImpl
Imports System.Drawing


'<DefaultListViewOptions(MasterDetailMode.ListViewOnly, False, NewItemRowPosition.None)> _
<ImageName("BO_Contact")>
<DefaultProperty("FullName")>
<Persistent("Employee")>
<DefaultClassOptions()>
<DevExpress.ExpressApp.DC.XafDisplayName("Προσωπικό")>
Public Class Employee ' Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    Inherits Person
    Implements IResource

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    End Sub

    Private Sub Employee_Changed(sender As Object, e As ObjectChangeEventArgs) Handles Me.Changed

        'SetPropertyValue("Caption", _caption, FullName)
        '_caption = FullName

    End Sub

#Region "Properties"
    Private _manager As Employee
    <DataSourceProperty("Department.Employees", DataSourcePropertyIsNullMode.SelectAll)>
    <DataSourceCriteria("Position.Title = 'Υπεύθυνος' AND Oid !='@This.Oid'")>
    Public Property Manager As Employee
        Get
            Return _manager
        End Get
        Set(value As Employee)
            SetPropertyValue("Manager", _manager, value)
        End Set
    End Property

    Private _datehired As DateTime
    Public Property DateHired As DateTime
        Set(value As DateTime)
            SetPropertyValue("DateHired", _datehired, value)
        End Set
        Get
            Return _datehired
        End Get
    End Property

    Private _datefired As DateTime
    Public Property DateFired As DateTime
        Set(value As DateTime)
            SetPropertyValue("DateFired", _datefired, value)
        End Set
        Get
            Return _datefired
        End Get
    End Property

    Private _nickname As String
    Public Property Nickname() As String
        Get
            Return _nickname
        End Get
        Set(ByVal value As String)
            SetPropertyValue("Nickname", _nickname, value)
        End Set
    End Property

    Private _notes As String
    <Size(4096)>
    Public Property Notes() As String
        Get
            Return _notes
        End Get
        Set(value As String)
            SetPropertyValue("Notes", _notes, value)
        End Set
    End Property
#End Region

#Region "Connections"
    Private _department As ManitariaAlexandroupolis.Module.Department
    <DevExpress.Xpo.AssociationAttribute("Employees-Department")>
    Public Property Department As ManitariaAlexandroupolis.Module.Department
        Get
            Return _department
        End Get
        Set
            SetPropertyValue("Department", _department, Value)
        End Set
    End Property

    Private _position As ManitariaAlexandroupolis.Module.Position
    <DevExpress.Xpo.AssociationAttribute("Employees-Positions")>
    Public ReadOnly Property Positions As XPCollection(Of ManitariaAlexandroupolis.Module.Position)
        Get
            Return GetCollection(Of ManitariaAlexandroupolis.Module.Position)("Positions")
        End Get
    End Property

    Private _skill As ManitariaAlexandroupolis.Module.Skill
    <DevExpress.Xpo.AssociationAttribute("Skills-Employee")>
    Public ReadOnly Property Skills As XPCollection(Of ManitariaAlexandroupolis.Module.Skill)
        Get
            Return GetCollection(Of ManitariaAlexandroupolis.Module.Skill)("Skills")
        End Get
    End Property


    <Association("Activity-Employees", UseAssociationNameAsIntermediateTableName:=True)>
    Public ReadOnly Property Activities() As XPCollection(Of Activity)
        Get
            Return GetCollection(Of Activity)("Activities")
        End Get
    End Property
#End Region

#Region "IResource Members"
    <Persistent("Color")>
    Private _Color As Integer
    Private _Caption As String
    Public Property Caption() As String Implements IResource.Caption
        Get
            Return _Caption
        End Get
        Set(ByVal value As String)
            'Convert.ToString(EvaluateAlias("FullName"))
            'SetPropertyValue("Caption", _Caption, value)
            SetPropertyValue("Caption", _Caption, Convert.ToString(FullName))
        End Set
    End Property
    <Browsable(False)>
    Public ReadOnly Property Id() As Object Implements IResource.Id
        Get
            Return Oid
        End Get
    End Property
    <Browsable(False)>
    Public ReadOnly Property OleColor() As Integer Implements IResource.OleColor
        Get
            Return ColorTranslator.ToOle(Color.FromArgb(_Color))
        End Get
    End Property
#End Region

End Class
