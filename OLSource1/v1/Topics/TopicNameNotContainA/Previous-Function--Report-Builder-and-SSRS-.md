---
title: "Previous Function (Report Builder and SSRS)"
ms.custom: na
ms.date: 06/29/2016
ms.prod: sql-server-2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - reporting-services-sharepoint
  - reporting-services-native
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 403a9384-6ca4-42e8-97ca-ac3f6fe4316b
caps.latest.revision: 9
manager: mblythe
---
# Previous Function (Report Builder and SSRS)
Returns the value or the specified aggregate value for the previous instance of an item within the specified scope.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Syntax  
  
```  
  
Previous(expression, scope)  
```  
  
#### Parameters  
 *expression*  
 (**Variant** or **Binary**) The expression to use to identify the data and for which to retrieve the previous value, for example, `Fields!Fieldname.Value` or `Sum(Fields!Fieldname.Value)`.  
  
 *scope*  
 (**String**) Optional. The name of a group or data region, or null (**Nothing** in [!INCLUDE[vbprvb](../../Topics/TopicNameContainA/includes/vbprvb_md.md)]), that specifies the scope from which to retrieve the previous value specified by *expression*.  
  
## Return Type  
 Returns a **Variant** or **Binary**.  
  
## Remarks  
 The **Previous** function returns the previous value for the expression evaluated in the specified scope after all sorting and filtering have been applied.  
  
 If *expression* does not contain an aggregate, the **Previous** function defaults to the current scope for the report item.  
  
 In a details group, use **Previous** to specify the value of a field reference in the previous instance of the detail row.  
  
> [!NOTE]  
>  The **Previous** function only supports field references in the details group. For example, in a text box in the details group, `=Previous(Fields!Quantity.Value)` returns the data for the field `Quantity` from the previous row. In the first row, this expression returns a null (**Nothing** in [!INCLUDE[vbprvb](../../Topics/TopicNameContainA/includes/vbprvb_md.md)]).  
  
 If *expression* contains an aggregate function that uses a default scope, **Previous** aggregates the data within the previous instance of the scope specified in the aggregate function call.  
  
 If *expression* contains an aggregate function that specifies a scope other than the default, the *scope* parameter for the **Previous** function must be a containing scope for the scope specified in the aggregate function call.  
  
 The functions **Level**, **InScope**, **Aggregate** and **Previous** cannot be used in the *expression*parameter. Specifying the *recursive* parameter for any aggregate function is not supported.  
  
 For more information, see [Aggregate Functions Reference (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Aggregate-Functions-Reference--Report-Builder-and-SSRS-.md) and [Expression Scope for Totals, Aggregates, and Built-in Collections (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Scope-for-Totals--Aggregates--and-Built-in-Collections--Report-Builder-and-SSRS-.md).  
  
## Examples  
  
### Description  
 The following code example, when placed in the default data row of a data region, provides the value for the field `LineTotal` in the previous row.  
  
### Code  
  
```  
=Previous(Fields!LineTotal.Value)  
```  
  
### Description  
 The following example shows an expression that calculates the sum of sales on a specific day of the month and the previous value for that day of the month in a previous year. The expression is added to a cell in a row that belongs to the child group `GroupbyDay`. Its parent group is `GroupbyMonth`, which has a parent group `GroupbyYear`. The expression displays the results for GroupbyDay (the default scope) and then for `GroupbyYear` (the parent of the parent group `GroupbyMonth`).  
  
 For example, for a data region with a parent group named `Year`, its child group named `Month`, and its child group named `Day` (3 nested levels). The expression `=Previous(Sum(Fields!Sales.Value,"Day"),"Year")` in a row associated with the group `Day` returns the sales value for the same day and month for the previous year.  
  
### Code  
  
```  
=Sum(Fields!Sales.Value) & " " & Previous(Sum(Fields!Sales.Value,"GroupbyDay"),"GroupbyYear")  
```  
  
## See Also  
 [Expression Uses in Reports (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Uses-in-Reports--Report-Builder-and-SSRS-.md)   
 [Expression Examples (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Examples--Report-Builder-and-SSRS-.md)   
 [Data Types in Expressions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Types-in-Expressions--Report-Builder-and-SSRS-.md)   
 [Expression Scope for Totals, Aggregates, and Built-in Collections (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Scope-for-Totals--Aggregates--and-Built-in-Collections--Report-Builder-and-SSRS-.md)