---
title: "First Function (Report Builder and SSRS)"
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
ms.assetid: d0914520-30c5-4d63-9b59-8d9342ed63b9
caps.latest.revision: 8
manager: mblythe
---
# First Function (Report Builder and SSRS)
Returns the first value in the given scope of the specified expression.  
  
> [!NOTE]  
>  [!INCLUDE[ssRBRDDup](../../Topics/TopicNameContainA/includes/ssRBRDDup_md.md)]  
  
## Syntax  
  
```  
  
First(expression, scope)  
```  
  
#### Parameters  
 *expression*  
 (**Variant** or **Binary**) The expression on which to perform the aggregation, for example, `=Fields!FieldName.Value`.  
  
 *scope*  
 (**String**) Optional. The name of a dataset, group, or data region that contains the report items to which to apply the aggregate function. If *scope* is not specified, the current scope is used.  
  
## Return Type  
 Determined by the type of expression.  
  
## Remarks  
 The **First** function returns the first value in a set of data after all sorting and filtering have been applied at the specified scope.  
  
 The **First** function cannot be used in group filter expressions with anything except the current (default) scope.  
  
 You can also use **First** in a page header to return the first value from the **ReportItems** collection for a page in order to produce dictionary-style headings that display the first and last entries on a page.  
  
 The value of *scope* must be a string constant andcannot be an expression. For outer aggregates or aggregates that do not specify other aggregates, *scope* must refer to the current scope or a containing scope. For aggregates of aggregates, nested aggregates can specify a child scope.  
  
 *Expression* can contain calls to nested aggregate functions with the following exceptions and conditions:  
  
-   *Scope* for nested aggregates must be the same as, or contained by, the scope of the outer aggregate. For all distinct scopes in the expression, one scope must be in a child relationship to all other scopes.  
  
-   *Scope* for nested aggregates cannot be the name of a dataset.  
  
-   *Expression* must not contain **First**, **Last**, **Previous**, or **RunningValue** functions.  
  
-   *Expression* must not contain nested aggregates that specify *recursive*.  
  
 For more information, see [Aggregate Functions Reference (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Aggregate-Functions-Reference--Report-Builder-and-SSRS-.md) and [Expression Scope for Totals, Aggregates, and Built-in Collections (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Scope-for-Totals--Aggregates--and-Built-in-Collections--Report-Builder-and-SSRS-.md).  
  
 For more information about recursive aggregates, see [Creating Recursive Hierarchy Groups (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Creating-Recursive-Hierarchy-Groups--Report-Builder-and-SSRS-.md).  
  
## Example  
 The following code example returns the first product number in the `Category` group of a data region:  
  
```  
=First(Fields!ProductNumber.Value, "Category")  
```  
  
## See Also  
 [Expression Uses in Reports (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Uses-in-Reports--Report-Builder-and-SSRS-.md)   
 [Expression Examples (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Examples--Report-Builder-and-SSRS-.md)   
 [Data Types in Expressions (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Data-Types-in-Expressions--Report-Builder-and-SSRS-.md)   
 [Expression Scope for Totals, Aggregates, and Built-in Collections (Report Builder and SSRS)](../../Topics/TopicNameNotContainA/Expression-Scope-for-Totals--Aggregates--and-Built-in-Collections--Report-Builder-and-SSRS-.md)