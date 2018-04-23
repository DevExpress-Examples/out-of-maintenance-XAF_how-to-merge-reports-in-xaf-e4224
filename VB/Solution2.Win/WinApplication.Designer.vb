Namespace Solution2.Win
    Partial Public Class Solution2WindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
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
            Me.module3 = New Solution2.Module.Solution2Module()
            Me.module4 = New Solution2.Module.Win.Solution2WindowsFormsModule()

            Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlConnection1
            ' 
            Me.sqlConnection1.ConnectionString = "Integrated Security=SSPI;Pooling=false;Data Source=.\SQLEXPRESS;Initial Catalog=Solution2"
            Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
            ' 
            ' Solution2WindowsFormsApplication
            ' 
            Me.ApplicationName = "Solution2"
            Me.Connection = Me.sqlConnection1
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)

            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As Solution2.Module.Solution2Module
        Private module4 As Solution2.Module.Win.Solution2WindowsFormsModule
        Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    End Class
End Namespace
