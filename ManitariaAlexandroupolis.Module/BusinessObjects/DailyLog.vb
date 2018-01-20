Imports Microsoft.VisualBasic
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

'<ImageName("BO_Contact")> _
'<DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")> _
'<DefaultListViewOptions(MasterDetailMode.ListViewOnly, False, NewItemRowPosition.None)> _
'<Persistent("DatabaseTableName")> _
<NavigationItem("Παραγωγή")>
<DefaultClassOptions()> _
Public Class DailyLog ' Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    Inherits BaseObject ' Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    Public Overrides Sub AfterConstruction()
        MyBase.AfterConstruction()
        ' Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
    End Sub

    Private _theDate As DateTime
    <XafDisplayName("Ημερομηνία")>
    Property TheDate As DateTime
        Get
            Return _theDate
        End Get
        Set(ByVal Value As DateTime)
            SetPropertyValue(Nameof(TheDate), _theDate, Value)
        End Set
    End Property

    Private _operation As Category
    <Association("Category-DailyLogs")>
    <DataSourceCriteria("Department = 'Παραγωγή'")>
    <XafDisplayName("Κατηγορία")>
    Property Operation() As Category
        Get
            Return _operation
        End Get
        Set(ByVal Value As Category)
            SetPropertyValue(NameOf(Operation), _operation, Value)
        End Set
    End Property

    Private _notes As String
    <XafDisplayName("Σημειώσεις")>
    Property Notes As String
        Get
            Return _notes
        End Get
        Set(ByVal Value As String)
            SetPropertyValue(NameOf(Notes), _notes, Value)
        End Set
    End Property

    <Association("Employee-DailyLogs")>
    <XafDisplayName("Εργαζόμενοι")>
    Public ReadOnly Property Employees() As XPCollection(Of Employee)
        Get
            Return GetCollection(Of Employee)(NameOf(Employees))
        End Get
    End Property
End Class
