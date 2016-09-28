---
title: "How to: Add a Computed Field in a LightSwitch Database"
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
  - "calculated field [Visual Studio LightSwitch]"
  - "data [Visual Studio LightSwitch], calculated field"
  - "computed field [Visual Studio LightSwitch]"
  - "data [Visual Studio LightSwitch], computed field"
ms.assetid: 6f17fd57-a8d8-4e88-8b94-aa3b77bf73d8
caps.latest.revision: 23
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Add a Computed Field in a LightSwitch Database
You can create fields that derive their values from the values of other fields in a database for a Visual Studio LightSwitch application. For example, you can add a field that's named `Subtotal` to an `Order_Details` entity. You can specify that the value of the `Subtotal` field is derived by multiplying the value of the `UnitPrice` field by the value of the `OrderQuantity` field.  
  
> [!NOTE]
>  You can't include a computed field as part of a filter condition or sort term in a query. Also, you can't sort information in a screen by choosing the column heading of a computed field.  
  
 ![link to video](../vs140/media/playvideo.gif "PlayVideo") For a related video demonstration, see [How Do I: Write business rules for validation and calculated fields in a LightSwitch Application?](http://go.microsoft.com/fwlink/?LinkID=205132).  
  
#### To define a computed field  
  
1.  In **Solution Explorer**, open the shortcut menu for an entity or table, and then choose **Open**.  
  
     The entity or table opens in the **Data Designer**.  
  
    > [!NOTE]
    >  For applications that have been upgraded to [!INCLUDE[vs2012_upd02](../vs140/includes/vs2012_upd02_md.md)], on the **Perspective** bar, choose the **Server** tab.  
  
2.  In the **Data Designer**, on the command bar, choose **Computed Property**.  
  
     A new field appears in the bottom row of the entity or table.  
  
3.  In the **Name** column, enter a name for the new field (for example, **Subtotal**).  
  
4.  In **Type** column, choose a data type for the new field (for example, **Money**).  
  
5.  In the **Properties** window, choose the **Edit Method** link.  
  
     The **Code Editor** opens and generates a method that's named *FieldName*`_Compute`.  
  
6.  Add code to the *FieldName*`_Compute` method that sets the value of the `result` parameter. The following example sets the value of the `Subtotal` field by multiplying the value of the `UntiPrice` field by the value of the `OrderQuantity` field.  
  
     [!code[LS_Data#1](../vs140/codesnippet/CSharp/how-to--add-a-computed-field-in-a-lightswitch-database_1.cs)][!code[LS_Data#1](../vs140/codesnippet/VisualBasic/how-to--add-a-computed-field-in-a-lightswitch-database_1.vb)]  
  
 A computed field isn't saved to the data source. A computed field appears only in screens that consume the entity or table. In the data designer, a small icon that resembles a calculator appears next to computed fields. This icon indicates that the field is used for display purposes only and doesn't affect the data source of the entity or table.  
  
 In most cases, the value of a computed field is recalculated based on changes to any field that you use to derive the value of the computed field. If the value of the computed field doesn't update, users can refresh the screen to view the updated value. You can also write custom code that refreshes the screen when certain events occur. See [How to: Handle Data Events](../vs140/how-to--handle-data-events.md).  
  
## See Also  
 [Data and Entities: The Information Behind Your Application](../vs140/data--the-information-behind-your-application.md)   
 [How to: Define the Fields of an Entity](../vs140/how-to--define-data-fields-in-a-lightswitch-database.md)   
 [How to: Create a Choice List for an Entity Field](../vs140/how-to--create-a-list-of-values-for-a-field-in-a-lightswitch-application.md)