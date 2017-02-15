VERSION 1.0 CLASS
BEGIN
  MultiUse = -1  'True
  Persistable = 0  'NotPersistable
  DataBindingBehavior = 0  'vbNone
  DataSourceBehavior  = 1  'vbDataSource
  MTSTransactionMode  = 0  'NotAnMTSObject
END
Attribute VB_Name = "clsINVAGE00"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = True
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Private WithEvents rsAgenda As ADODB.Recordset
Attribute rsAgenda.VB_VarHelpID = -1

Private Sub Class_Initialize()
    DataMembers.Add "Agenda"
    Set rsAgenda = New ADODB.Recordset
    
End Sub
