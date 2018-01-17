Imports DevExpress.Xpo
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.ExpressApp.ConditionalAppearance

'<ImageName("BO_Task")> _
'<DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")> _
'<DefaultListViewOptions(MasterDetailMode.ListViewOnly, False, NewItemRowPosition.None)> _

'<Appearance("FontColorRed", AppearanceItemType:="ViewItem", TargetItems:="*", ContextBoundObject:="ListView", CriteriaProcessorBase:="Status!='Completed'", FontColor:="Red")>
<DefaultClassOptions()>
<ImageName("BO_Task")>
<Persistent("TaskV2")>
<DevExpress.ExpressApp.DC.XafDisplayName("Εργασίες")>
Public Class Taskv2
    Inherits Task
    Implements IComparable

    Private _priority As PriorityEnum
    Private _estimatedWork As Int32
    Private _actualWork As Int32

    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    '<Appearance("PriorityBackColork", AppearanceItemType:="ViewItem", CriteriaProcessorBase:="Priority=2", BackColor:="0xfff0f0")>
    Public Property Priority As PriorityEnum
        Get
            Return _priority
        End Get
        Set(value As PriorityEnum)
            SetPropertyValue("Priority", _priority, value)
        End Set
    End Property

    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        Priority = PriorityEnum.Normal
        StartDate = Now
    End Sub

    Public Overrides Function ToString() As String
        Return This.Subject
    End Function
	
    <Action(Caption:="Postpone", ImageName:="State_Task_Deferred")>
    Public Sub Postpone()
        If (DueDate = DateTime.MinValue) Then
            DueDate = DateTime.Now
        End If

        DueDate = DueDate + TimeSpan.FromDays(1)
    End Sub
    Public Property EstimatedWork As Int32
        Get
            Return _estimatedWork
        End Get
        Set(value As Int32)
            SetPropertyValue("EstimatedWork", _estimatedWork, value)
        End Set
    End Property
    Public Property ActualWork As Int32
        Get
            Return _actualWork

        End Get
        Set(value As Int32)
            SetPropertyValue("ActualWork", _actualWork, value)

        End Set
    End Property

    Private _category As Category
    <DevExpress.Xpo.AssociationAttribute("Taskv2s-Category")>
    Public Property Category As Category
        Get
            Return _category
        End Get
        Set
            SetPropertyValue("Category", _category, Value)
        End Set
    End Property

    Public Enum PriorityEnum
        <ImageName("State_Priority_Low")>
        Low = 0
        <ImageName("State_Priority_Normal")>
        Normal = 1
        <ImageName("State_Priority_High")>
        High = 2
    End Enum
End Class
