---
title: Min Function (Report Builder and SSRS)
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
ms.assetid: aa1ee96f-9fc4-4775-b9d4-c6187dc37e27
manager: mblythe
---
# Min Function (Report Builder and SSRS)
Returns the minimum value of all non-null numeric values specified by the expression, in the context of the given scope.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Syntax  
  
```  
  
Min(expression, scope, recursive)  
```  
  
#### Parameters  
 *expression*  
 (**Variant**) The expression on which to perform the aggregation.  
  
 *scope*  
 (**String**) Optional. The name of a dataset, group, or data region that contains the report items to which to apply the aggregate function. If *scope* is not specified, the current scope is used.  
  
 *recursive*  
 (**Enumerated Type**) Optional. **Simple** (default) or **RdlRecursive**. Specifies whether to perform the aggregation recursively.  
  
## Return Type  
 Determined by the type of the expression.  
  
## Remarks  
 The set of data specified in the expression must have the same data type. To convert data that has multiple numeric data types to the same data type, use conversion functions like **CInt**, **CDbl** or **CDec**. For more information, see [Type Conversion Functions](http://go.microsoft.com/fwlink/?LinkId=96142).  
  
 The value of *scope* must be a string constant and cannot be an expression. For outer aggregates or aggregates that do not specify other aggregates, *scope* must refer to the current scope or a containing scope. For aggregates of aggregates, nested aggregates can specify a child scope.  
  
 *Expression* can contain calls to nested aggregate functions with the following exceptions and conditions:  
  
-   *Scope* for nested aggregates must be the same as, or contained by, the scope of the outer aggregate. For all distinct scopes in the expression, one scope must be in a child relationship to all other scopes.  
  
-   *Scope* for nested aggregates cannot be the name of a dataset.  
  
-   *Expression* must not contain **First**, **Last**, **Previous**, or **RunningValue** functions.  
  
-   *Expression* must not contain nested aggregates that specify *recursive*.  
  
 For more information, see [Aggregate Functions Reference (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Aggregate-Functions-Reference--Report-Builder-and-SSRS-.md) and [Expression Scope for Totals, Aggregates, and Built-in Collections (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Scope-for-Totals--Aggregates--and-Built-in-Collections--Report-Builder-and-SSRS-.md).  
  
 For more information about recursive aggregates, see [Creating Recursive Hierarchy Groups (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Creating-Recursive-Hierarchy-Groups--Report-Builder-and-SSRS-.md).  
  
## Example  
 The following code example provides the lowest total in the current scope.  
  
```  
=Min(Fields!OrderTotal.Value)  
```  
  
## See Also  
 [Expression Uses in Reports (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Uses-in-Reports--Report-Builder-and-SSRS-.md)   
 [Expression Examples (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Examples--Report-Builder-and-SSRS-.md)   
 [Data Types in Expressions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Types-in-Expressions--Report-Builder-and-SSRS-.md)   
 [Expression Scope for Totals, Aggregates, and Built-in Collections (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Scope-for-Totals--Aggregates--and-Built-in-Collections--Report-Builder-and-SSRS-.md)