﻿#ExternalChecksum("C:\Users\charlesJA\Documents\Visual Studio 2015\Projects\Projects\Paperbooklet\Paperbooklet\MainPage.xaml", "{406ea660-64cf-4c82-b6f0-42d48172a799}", "FF8AC2F8EAAD17737DD2EE3B4D2ADD91")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Namespace Global.Paperbooklet

    Partial Class MainPage
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector
        Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2


        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "14.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub Connect(ByVal connectionId As Integer, ByVal target As Global.System.Object) Implements Global.Windows.UI.Xaml.Markup.IComponentConnector.Connect
            Select Case connectionid
            Case 1
                    Me.webview1 = CType(target, Global.Windows.UI.Xaml.Controls.WebView)
#ExternalSource("..\..\..\MainPage.xaml",11)
                AddHandler DirectCast(Me.webview1, Global.Windows.UI.Xaml.Controls.WebView).LoadCompleted, AddressOf Me.WebView_LoadCompleted
#End ExternalSource
                    Exit Select
            Case 2
                    Me.ProgressRing1 = CType(target, Global.Windows.UI.Xaml.Controls.ProgressRing)
                    Exit Select
                    Case Else
                        Exit Select
            End Select
                Me._contentLoaded = true
        End Sub
        <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "14.0.0.0")>  _
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Function GetBindingConnector(connectionId As Integer, target As Object) As Global.Windows.UI.Xaml.Markup.IComponentConnector Implements Global.Windows.UI.Xaml.Markup.IComponentConnector2.GetBindingConnector
            Dim returnValue As Global.Windows.UI.Xaml.Markup.IComponentConnector = Nothing
            Return returnValue
        End Function
    End Class

End Namespace

