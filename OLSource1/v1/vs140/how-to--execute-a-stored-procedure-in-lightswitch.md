---
title: "How to: Execute a Stored Procedure in LightSwitch"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 8766dead-900a-4387-9af9-7a8da34c19d5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Execute a Stored Procedure in LightSwitch
LightSwitch applications can execute stored procedures in a SQL Server database by calling them from the server tier. You can create commands on the client tier to trigger the execution, and you can define permissions to control who has access to the stored procedures.  
  
 Many existing databases use stored procedures because they have advantages over other types of database interaction such as modular programming, faster execution, and reduced network traffic. These same advantages apply to executing stored procedures from your LightSwitch application.  
  
 The following procedures use the uspUpdateEmployeePersonalInfo stored procedure from the AdventureWorks sample database:  
  
```  
CREATE PROCEDURE [HumanResources].[uspUpdateEmployeePersonalInfo]  
@EmployeeID [int],   
@NationalIDNumber [nvarchar](15),   
@BirthDate [datetime],   
@MaritalStatus [nchar](1),   
@Gender [nchar](1)  
WITH EXECUTE AS CALLER  
AS  
BEGIN  
SET NOCOUNT ON;  
UPDATE [HumanResources].[Employee]   
SET [NationalIDNumber] = @NationalIDNumber   
,[BirthDate] = @BirthDate   
,[MaritalStatus] = @MaritalStatus   
,[Gender] = @Gender   
WHERE [EmployeeID] = @EmployeeID;  
END;  
  
```  
  
 To execute a different stored procedure, you must change the names and parameters to match it.  
  
### To execute a stored procedure  
  
1.  Create a table in the intrinsic database that contains the input parameters for the stored procedure.  
  
    1.  In **Solution Explorer**, open the shortcut menu for the **Data Sources** node, and then choose **Add Table**.  
  
    2.  In the **Properties** window, in the **Name** text box, enter `UpdateEmployeePersonalInfoOperation`.  
  
        > [!NOTE]
        >  You will typically replace `UpdateEmployeePersonalInfoOperation` with the name of the stored procedure that you want to execute plus an identifier such as “Operation” to signify that this table is used for a stored procedure.  
  
    3.  Add the following fields to the table:  
  
        |Name|Type|Required|  
        |----------|----------|--------------|  
        |EmployeeID|Integer|Yes|  
        |NationalIDNumber|String|Yes|  
        |BirthDate|Date Time|Yes|  
        |MaritalStatus|String|Yes|  
        |Gender|String|Yes|  
  
        > [!NOTE]
        >  In the **Name** and **Type** fields, replace the values with the names and data types for each input parameter in your stored procedure, and ensure that all fields are marked as required.  
  
2.  Add a reference to the `ConfigurationManager` class.  
  
    1.  In **Solution Explorer**, open the shortcut menu for the **Server** node, and then choose **Add Reference**.  
  
    2.  In the **Reference Manager** dialog box, expand the **Assemblies** node, choose the **Framework** node, and then select the **System.Configuration** check box.  
  
3.  In the **Write Code** list, choose the **Inserting** method (in this case, the **UpdateEmployeePersonalInfoOperations_Inserting** method).  
  
4.  Add code that resembles the following example:  
  
    ```vb  
    Imports System.Configuration  
    Imports System.Data  
    Imports System.Data.SqlClient  
  
    Namespace LightSwitchApplication  
        Public Class ApplicationDataService  
            Private Sub UpdateEmployeePersonalInfoOperations_Inserting(entity As UpdateEmployeePersonalInfoOperation)  
                Using connection = New SqlConnection  
                    Dim connectionStringName = Me.DataWorkspace.AdventureWorksData.Details.Name  
                    connection.ConnectionString =  
                        ConfigurationManager.ConnectionStrings(connectionStringName).ConnectionString  
  
                    Dim procedure = "HumanResources.uspUpdateEmployeePersonalInfo"  
                    Using command = New SqlCommand(procedure, connection)  
                        command.CommandType = CommandType.StoredProcedure  
  
                        command.Parameters.Add(  
                            New SqlParameter("@EmployeeID", entity.EmployeeID))  
                        command.Parameters.Add(  
                            New SqlParameter("@NationalIDNumber", entity.NationalIDNumber))  
                        command.Parameters.Add(  
                            New SqlParameter("@BirthDate", entity.BirthDate))  
                        command.Parameters.Add(  
                            New SqlParameter("@MaritalStatus", entity.MaritalStatus))  
                        command.Parameters.Add(  
                            New SqlParameter("@Gender", entity.Gender))  
  
                        connection.Open()  
                        command.ExecuteNonQuery()  
                    End Using  
                End Using  
  
                Me.Details.DiscardChanges()  
            End Sub  
        End Class  
    End Namespace  
  
    ```  
  
    ```c#  
    using System.Configuration;  
    using System.Data;  
    using System.Data.SqlClient;  
  
    public partial class ApplicationDataService  
    {  
        partial void UpdateEmployeePersonalInfoOperations_Inserting(UpdateEmployeePersonalInfoOperation entity)  
        {  
            using (SqlConnection connection = new SqlConnection())  
            {  
                string connectionStringName = this.DataWorkspace.AdventureWorksData.Details.Name;  
                connection.ConnectionString =  
                    ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;  
  
                string procedure = "HumanResources.uspUpdateEmployeePersonalInfo";  
                using (SqlCommand command = new SqlCommand(procedure, connection))  
                {  
                    command.CommandType = CommandType.StoredProcedure;  
  
                    command.Parameters.Add(  
                        new SqlParameter("@EmployeeID", entity.EmployeeID));  
                    command.Parameters.Add(  
                        new SqlParameter("@NationalIDNumber", entity.NationalIDNumber));  
                    command.Parameters.Add(  
                        new SqlParameter("@BirthDate", entity.BirthDate));  
                    command.Parameters.Add(  
                        new SqlParameter("@MaritalStatus", entity.MaritalStatus));  
                    command.Parameters.Add(  
                        new SqlParameter("@Gender", entity.Gender));  
  
                    connection.Open();  
                    command.ExecuteNonQuery();  
                }  
            }  
  
            this.Details.DiscardChanges();  
        }  
    }  
  
    ```  
  
     This code creates a `SqlConnection` object and gets the connection string from the web.config file. The code then creates a **SqlCommand** object with the required command text, adds the parameter values, and executes the command.  
  
    > [!NOTE]
    >  You must replace the **DataWorkspace** name and the parameter names and values with those for your own stored procedure.  
  
### To invoke the stored procedure from a screen  
  
1.  In the **Screen Designer**, open the shortcut menu for the **Screen Command Bar** node, and then choose **Add Button**.  
  
2.  In the **Add Button** dialog box, choose the **New Method** option button.  
  
3.  In the **Name** text box, enter `UpdateEmployeeInfo`.  
  
    > [!NOTE]
    >  You can substitute a name that describes what your stored procedure does.  
  
4.  In the **Screen Designer**, open the shortcut menu for the button node, and then choose **Edit Execute Code**.  
  
5.  Add code that resembles the following example:  
  
    ```vb  
    Private Sub UpdateEmployeeInfo_Execute()  
        Dim dataWorkspace = New DataWorkspace  
        Dim employee = Me.Employees.SelectedItem  
  
        Dim operation =  
            dataWorkspace.ApplicationData.UpdateEmployeePersonalInfoOperations.AddNew()  
        operation.EmployeeID = employee.EmployeeID  
        operation.NationalIDNumber = employee.NationalIDNumber  
        operation.BirthDate = employee.BirthDate  
        operation.MaritalStatus = employee.MaritalStatus  
        operation.Gender = employee.Gender  
  
        dataWorkspace.ApplicationData.SaveChanges()  
    End Sub  
  
    ```  
  
    ```c#  
    partial void UpdateEmployeeInfo_Execute()  
    {  
        DataWorkspace dataWorkspace = new DataWorkspace();  
        Employee employee = this.Employees.SelectedItem;  
  
        UpdatePersonalInfoOperation operation =   
            dataWorkspace.ApplicationData.UpdateEmployeePersonalInfoOperations.AddNew();  
        operation.EmployeeID = employee.EmployeeID;  
        operation.NationalIDNumber = employee.NationalIDNumber;  
        operation.BirthDate = employee.BirthDate;  
        operation.MaritalStatus = employee.MaritalStatus;  
        operation.Gender = employee.Gender;  
  
        dataWorkspace.ApplicationData.SaveChanges();  
    }  
  
    ```  
  
     This code first creates a `DataWorkspace` and then creates an **UpdateEmployeePersonalInfoOperation** by using the newly created DataWorkspace’s `ApplicationData`. The values for the operation are assigned, and operation is invoked by calling `SaveChanges`. This step triggers the middle tier `UpdateEmployeePersonalInfoOperations_Inserting` method that executes the stored procedure in the database.  
  
    > [!TIP]
    >  The screen data isn’t refreshed to reflect the changes when you call the stored procedure. To refresh the screen, you can either call `Employees.Refresh()` or `DataWorkspace.AdventureWorksData.Employees_Single(operation.EmployeeID)` at the end of the button’s `Execute` method. Note that `Employees.Refresh()` refreshes all the records, and `Employees_Single` refreshes only the item that you specify.  
  
### To define permissions for a stored procedure  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Properties** node, and then choose **Open**.  
  
2.  On the **Access Control** tab, choose the type of authentication to use if it’s not already specified.  
  
3.  Choose the **\<Add New Permission>** link, and then and enter `UpdatePersonalInfo`.  
  
    > [!NOTE]
    >  You can substitute a name that describes what your stored procedure does.  
  
4.  In **Solution Explorer**, open the shortcut menu for your stored procedure table, and then choose **Open**.  
  
5.  In the **Write Code** list, choose the **CanInsert** method.  
  
6.  Add code that resembles the following example:  
  
    ```vb  
    Private Sub UpdateEmployeePersonalInfoOperations_CanInsert(ByRef result As Boolean)  
        result = Me.Application.User.HasPermission(Permissions.UpdatePersonalInfo)  
    End Sub  
  
    ```  
  
    ```c#  
    partial void UpdateEmployeePersonalInfoOperations_CanInsert(ref bool result)  
    {  
        result = this.Application.User.HasPermission(Permissions.UpdatePersonalInfo);  
    }  
    ```  
  
## See Also  
 [Walkthrough: Updating Records Using Stored Procedures](../vs140/walkthrough--using-stored-procedures.md)   
 [Working with Data-Related Objects in Code](../vs140/working-with-data-related-objects-in-code.md)   
 [How to: Create a Role-based Application](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md)