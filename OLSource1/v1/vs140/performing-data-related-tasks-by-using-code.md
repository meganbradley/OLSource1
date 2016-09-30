---
title: "Performing Data-Related Tasks by Using Code"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "lightswitch"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "automating [Visual Studio LightSwitch]"
  - "data [Visual Studio LightSwitch], extending"
  - "data [Visual Studio LightSwitch], custom code"
  - "extending [Visual Studio LightSwitch]"
  - "data [Visual Studio LightSwitch], automating"
  - "custom code [Visual Studio LightSwitch]"
ms.assetid: 6531546b-8435-4200-82c0-5d7a4f9f4a49
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Performing Data-Related Tasks by Using Code
You can use the designers and tool windows in [!INCLUDE[smb_current_long](../vs140/includes/smb_current_long_md.md)] to accomplish many data-related design tasks.  However, certain tasks can only be accomplished by adding code to an application. For example, to validate a field by applying custom conditions, you must write code.  This document shows how to accomplish data-related tasks by using the data runtime object model. For more information about where you can write code in an application, see the following topics:  
  
-   [How to: Handle Data Entity Events](../vs140/how-to--handle-data-events.md)  
  
-   [How to: Handle Screen Events](../vs140/how-to--handle-silverlight-screen-events.md)  
  
-   [How to: Handle Query Events](../vs140/how-to--handle-query-events.md)  
  
## Common Tasks  
 The following list shows common data-related tasks that you can accomplish by using the data runtime object model. The tasks are described later in this document.  
  
-   [Reading Data](#ReadingData)  
  
-   [Updating Data](#UpdatingData)  
  
-   [Deleting Data](#DeletingData)  
  
-   [Adding Data](#CreatingAnd)  
  
-   [Saving Data](#SavingData)  
  
-   [Validating Data](#ValidatingFields)  
  
-   [Setting Permissions on Data](#SettingPermissions)  
  
-   [Working with Change Sets](#WorkingWith)  
  
-   [Extending Queries](#ExtendingModeled)  
  
##  \<a name="ReadingData">\</a> Reading Data  
 You can read individual data items or collections of data items from any data source in your application.  
  
 The following example retrieves the customer that is currently selected in a screen.  
  
 [!code[LS_Data#5](../vs140/codesnippet/CSharp/performing-data-related-tasks-by-using-code_1.cs)]
[!code[LS_Data#5](../vs140/codesnippet/VisualBasic/performing-data-related-tasks-by-using-code_1.vb)]  
  
 The following example iterates over a collection of customers.  
  
 [!code[LS_Data#6](../vs140/codesnippet/CSharp/performing-data-related-tasks-by-using-code_2.cs)]
[!code[LS_Data#6](../vs140/codesnippet/VisualBasic/performing-data-related-tasks-by-using-code_2.vb)]  
  
### Navigating Data Relationships  
 You can read data from related entities. For example, a Customer entity might have a one-to-many relationship with an Orders entity. You could iterate over all orders that have been placed by a customer by using the **Orders** property of the Customer entity.  
  
 The following example iterates over the collection of orders that are related to a customer.  
  
 [!code[LS_Data#7](../vs140/codesnippet/CSharp/performing-data-related-tasks-by-using-code_3.cs)]
[!code[LS_Data#7](../vs140/codesnippet/VisualBasic/performing-data-related-tasks-by-using-code_3.vb)]  
  
 The following example gets the customer who placed a specific order.  
  
 [!code[LS_Data#8](../vs140/codesnippet/CSharp/performing-data-related-tasks-by-using-code_4.cs)]
[!code[LS_Data#8](../vs140/codesnippet/VisualBasic/performing-data-related-tasks-by-using-code_4.vb)]  
  
### Reading Data by Executing a Query  
 You can retrieve queries from the model and then execute them in your code. To view an example, see [How to: Retrieve Data from a Query by Using Code](../vs140/how-to--retrieve-data-from-a-query-by-using-code.md).  
  
##  \<a name="UpdatingData">\</a> Updating Data  
 You can update data for any entity by using code. The following example shows code that runs when a user creates an order in the Order entity in a screen and then clicks the **Save** button. The code updates a field in the Products entity by using a field in the Order Details entity.  
  
 [!code[LS_Data#9](../vs140/codesnippet/CSharp/performing-data-related-tasks-by-using-code_5.cs)]
[!code[LS_Data#9](../vs140/codesnippet/VisualBasic/performing-data-related-tasks-by-using-code_5.vb)]  
  
> [!NOTE]
>  If your code modifies data from other data sources, you must commit those changes by calling the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> method of that data source.  
  
##  \<a name="DeletingData">\</a> Deleting Data  
 You can delete data by calling the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> method of any entity. The following example deletes a customer from the NorthwindData data source.  
  
 [!code[LS_Data#10](../vs140/codesnippet/CSharp/performing-data-related-tasks-by-using-code_6.cs)]
[!code[LS_Data#10](../vs140/codesnippet/VisualBasic/performing-data-related-tasks-by-using-code_6.vb)]  
  
##  \<a name="CreatingAnd">\</a> Adding Data  
 The following example adds a new customer to the NorthwindData data source.  This example populates the fields that describe the new customer by using information from a contact that was recently added to a SharePoint list. The example calls a query named <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to determine which contacts in the SharePoint list have not yet been imported to the NorthwindData data source.  
  
 [!code[LS_Data#11](../vs140/codesnippet/CSharp/performing-data-related-tasks-by-using-code_7.cs)]
[!code[LS_Data#11](../vs140/codesnippet/VisualBasic/performing-data-related-tasks-by-using-code_7.vb)]  
  
##  \<a name="SavingData">\</a> Saving Data  
 Typically, pending changes are committed to a data source when the user clicks the **Save** button in a screen. However, you can also commit pending changes by adding code that calls the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> method of a data source. You must add this code if you want to accomplish either of these tasks:  
  
-   Commit changes that you make to data that is located in other data sources.  
  
-   Override the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> event of a screen.  
  
### Committing Changes That You Make to Data That Is Located in Other Data Sources  
 The files in which you write custom code have a primary data source. If you add custom code that modifies data from another data source in your [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] solution, you must commit those changes by calling the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method of that data source.  
  
 The following example shows code that runs when a user creates an order in an Order entity in a screen and then clicks the **Save** button. The code updates a field in the Products entity by using a field in the Order Details entity.  Because the Products entity is located in another data source, this code calls the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method of that data source to commit the changes.  
  
 [!code[LS_Data#16](../vs140/codesnippet/CSharp/performing-data-related-tasks-by-using-code_8.cs)]
[!code[LS_Data#16](../vs140/codesnippet/VisualBasic/performing-data-related-tasks-by-using-code_8.vb)]  
  
### Overriding the Save Event of a Screen  
 You can change the behavior of the **Save** button on a screen by overriding the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> event. Because you are replacing the behavior of the **Save** button, your code must call the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method when you want to commit pending changes.  
  
 The following example overrides the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> event of a customer screen to catch and handle a specific exception that might be thrown if the save operation fails.  
  
 [!code[LS_Data#12](../vs140/codesnippet/CSharp/performing-data-related-tasks-by-using-code_9.cs)]
[!code[LS_Data#12](../vs140/codesnippet/VisualBasic/performing-data-related-tasks-by-using-code_9.vb)]  
  
##  \<a name="ValidatingFields">\</a> Validating Data  
 You can apply custom validation rules to the fields of an entity. You can add custom error messages that appear when users modify the value of properties in ways that do not conform to your validation rules. For more information, see [How to: Validate an Entity](../vs140/how-to--validate-data-in-a-lightswitch-application.md)  
  
##  \<a name="SettingPermissions">\</a> Setting Permissions on Data  
 By default, all users can view, insert, delete, or update data that appears in a screen. However, you can restrict these permissions by adding code to one of the following methods:  
  
-   <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 If you restrict an operation by using these methods, [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] makes the operation unavailable to users who do not have unrestricted permissions. For more information, see [How to: Handle Data Entity Events](../vs140/how-to--handle-data-events.md).  
  
 The following example enables a user to update customer information if the user has update permission. This code example requires a permissions group named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. For more information about how to add a permissions group to your application, see [Creating Roles and Permissions](../vs140/enabling-authorization-and-creating-permissions-in-lightswitch.md).  
  
 [!code[LS_Data#13](../vs140/codesnippet/CSharp/performing-data-related-tasks-by-using-code_10.cs)]
[!code[LS_Data#13](../vs140/codesnippet/VisualBasic/performing-data-related-tasks-by-using-code_10.vb)]  
  
 By default, [!INCLUDE[smb_current_short](../vs140/includes/smb_current_short_md.md)] calls these methods when a user attempts to view, insert, delete, or update information. You can also call these methods in your custom code before data is read or modified.  
  
##  \<a name="WorkingWith">\</a> Working with Change Sets  
 You can identify and discard pending changes before they are committed to a data source. The following example shows three user methods that identify and discard pending changes. The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method discards all changes made to all customers. The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method discards all changes made to the data source. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method discards changes made to the currently selected row of data in a customer screen.  
  
 [!code[LS_Data#14](../vs140/codesnippet/CSharp/performing-data-related-tasks-by-using-code_11.cs)]
[!code[LS_Data#14](../vs140/codesnippet/VisualBasic/performing-data-related-tasks-by-using-code_11.vb)]  
  
##  \<a name="ExtendingModeled">\</a> Extending Modeled Queries  
 If you want to modify a query beyond the capabilities of the Query Designer, you can extend the query by adding code to the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> method of the query. For more information, see [How to: Extend a Query by Using Code](../vs140/how-to--extend-a-query-by-using-code.md).