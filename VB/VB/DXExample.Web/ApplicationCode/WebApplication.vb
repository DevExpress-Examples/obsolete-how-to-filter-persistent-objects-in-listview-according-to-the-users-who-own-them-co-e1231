Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Namespace DXExample.Web
	Partial Public Class DXExampleAspNetApplication
		Inherits WebApplication
		Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
		Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
		Private module3 As DXExample.Module.DXExampleModule
		Private module4 As DXExample.Module.Web.DXExampleAspNetModule
		Private securityModule1 As DevExpress.ExpressApp.Security.SecurityModule
		Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
		Private sqlConnection1 As System.Data.SqlClient.SqlConnection
		Private authenticationStandard1 As DevExpress.ExpressApp.Security.AuthenticationStandard
		Private securityComplex1 As DevExpress.ExpressApp.Security.SecurityComplex
		Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub DXExampleAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
			If System.Diagnostics.Debugger.IsAttached Then
				e.Updater.Update()
				e.Handled = True
			Else
				Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Constants.vbCrLf & "The automatical update is disabled, because the application was started without debugging." & Constants.vbCrLf & "You should start the application under Visual Studio, or modify the " & "source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " & "or manually create a database with the help of the 'DBUpdater' tool.")
			End If
		End Sub

		Private Sub InitializeComponent()
			Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
			Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
			Me.module3 = New DXExample.Module.DXExampleModule()
			Me.module4 = New DXExample.Module.Web.DXExampleAspNetModule()
			Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
			Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
			Me.securityModule1 = New DevExpress.ExpressApp.Security.SecurityModule()
			Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
			Me.authenticationStandard1 = New DevExpress.ExpressApp.Security.AuthenticationStandard()
			Me.securityComplex1 = New DevExpress.ExpressApp.Security.SecurityComplex()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' module5
			' 
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResult))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSetValidationResultItem))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RulePropertyValueProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRequiredFieldProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRangeProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleValueComparisonProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleStringComparisonProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleRegularExpressionProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleCriteriaProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleSearchObjectProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleObjectExistsProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleUniqueValueProperties))
			Me.module5.AdditionalBusinessClasses.Add(GetType(DevExpress.Persistent.Validation.RuleIsReferencedProperties))
			' 
			' sqlConnection1
			' 
			Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=DXExample;Integrated Security=SSPI;Pooling=fa" & "lse"
			Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
			' 
			' authenticationStandard1
			' 
			Me.authenticationStandard1.LogonParametersType = GetType(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters)
			Me.authenticationStandard1.UserType = GetType(DXExample.Module.CustomUser)
			' 
			' securityComplex1
			' 
			Me.securityComplex1.Authentication = Me.authenticationStandard1
			Me.securityComplex1.IsGrantedForNonExistentPermission = False
			Me.securityComplex1.RoleType = GetType(DevExpress.Persistent.BaseImpl.Role)
			Me.securityComplex1.UserType = GetType(DXExample.Module.CustomUser)
			' 
			' DXExampleAspNetApplication
			' 
			Me.ApplicationName = "DXExample"
			Me.Connection = Me.sqlConnection1
			Me.Modules.Add(Me.module1)
			Me.Modules.Add(Me.module2)
			Me.Modules.Add(Me.module6)
			Me.Modules.Add(Me.module3)
			Me.Modules.Add(Me.module4)
			Me.Modules.Add(Me.module5)
			Me.Modules.Add(Me.securityModule1)
			Me.Security = Me.securityComplex1
'			Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.DXExampleAspNetApplication_DatabaseVersionMismatch);
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub
	End Class
End Namespace
