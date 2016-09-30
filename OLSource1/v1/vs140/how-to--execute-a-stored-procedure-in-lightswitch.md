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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 To execute a different stored procedure, you must change the names and parameters to match it.  
  
### To execute a stored procedure  
  
1.  Create a table in the intrinsic database that contains the input parameters for the stored procedure.  
  
    1.  In **Solution Explorer**, open the shortcut menu for the **Data Sources** node, and then choose **Add Table**.  
  
    2.  In the **Properties** window, in the **Name** text box, enter <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
        > [!NOTE]
        >  You will typically replace <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> with the name of the stored procedure that you want to execute plus an identifier such as “Operation” to signify that this table is used for a stored procedure.  
  
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
  
2.  Add a reference to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class.  
  
    1.  In **Solution Explorer**, open the shortcut menu for the **Server** node, and then choose **Add Reference**.  
  
    2.  In the **Reference Manager** dialog box, expand the **Assemblies** node, choose the **Framework** node, and then select the **System.Configuration** check box.  
  
3.  In the **Write Code** list, choose the **Inserting** method (in this case, the **UpdateEmployeePersonalInfoOperations_Inserting** method).  
  
4.  Add code that resembles the following example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     This code creates a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object and gets the connection string from the web.config file. The code then creates a **SqlCommand** object with the required command text, adds the parameter values, and executes the command.  
  
    > [!NOTE]
    >  You must replace the **DataWorkspace** name and the parameter names and values with those for your own stored procedure.  
  
### To invoke the stored procedure from a screen  
  
1.  In the **Screen Designer**, open the shortcut menu for the **Screen Command Bar** node, and then choose **Add Button**.  
  
2.  In the **Add Button** dialog box, choose the **New Method** option button.  
  
3.  In the **Name** text box, enter <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
    > [!NOTE]
    >  You can substitute a name that describes what your stored procedure does.  
  
4.  In the **Screen Designer**, open the shortcut menu for the button node, and then choose **Edit Execute Code**.  
  
5.  Add code that resembles the following example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     This code first creates a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and then creates an **UpdateEmployeePersonalInfoOperation** by using the newly created DataWorkspace’s <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The values for the operation are assigned, and operation is invoked by calling <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. This step triggers the middle tier <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method that executes the stored procedure in the database.  
  
    > [!TIP]
    >  The screen data isn’t refreshed to reflect the changes when you call the stored procedure. To refresh the screen, you can either call <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> at the end of the button’s <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method. Note that <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> refreshes all the records, and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> refreshes only the item that you specify.  
  
### To define permissions for a stored procedure  
  
1.  In **Solution Explorer**, open the shortcut menu for the **Properties** node, and then choose **Open**.  
  
2.  On the **Access Control** tab, choose the type of authentication to use if it’s not already specified.  
  
3.  Choose the **\<Add New Permission>** link, and then and enter <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
    > [!NOTE]
    >  You can substitute a name that describes what your stored procedure does.  
  
4.  In **Solution Explorer**, open the shortcut menu for your stored procedure table, and then choose **Open**.  
  
5.  In the **Write Code** list, choose the **CanInsert** method.  
  
6.  Add code that resembles the following example:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## See Also  
 [Walkthrough: Updating Records Using Stored Procedures](../vs140/walkthrough--using-stored-procedures.md)   
 [Working with Data-Related Objects in Code](../vs140/working-with-data-related-objects-in-code.md)   
 [How to: Create a Role-based Application](../vs140/how-to--enable-authentication-in-a-silverlight-client-app.md)