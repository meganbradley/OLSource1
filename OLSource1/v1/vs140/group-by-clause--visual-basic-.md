---
title: "Group By Clause (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.QueryGroupByInto"
  - "vb.QueryGroupBy"
  - "vb.QueryGroupRef"
  - "vb.QueryGroupInto"
  - "vb.QueryGroup"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "queries [Visual Basic], Group By"
  - "Group By statement"
  - "Group By clause"
ms.assetid: b1b5dcea-6654-473b-a2db-01f7e4c265d7
caps.latest.revision: 24
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Group By Clause (Visual Basic)
Groups the elements of a query result. Can also be used to apply aggregate functions to each group. The grouping operation is based on one or more keys.  
  
## Syntax  
  
```  
Group [ listField1 [, listField2 [...] ] By keyExp1 [, keyExp2 [...] ]  
  Into aggregateList  
```  
  
## Parts  
  
-   `listField1`, `listField2`  
  
     Optional. One or more fields of the query variable or variables that explicitly identify the fields to be included in the grouped result. If no fields are specified, all fields of the query variable or variables are included in the grouped result.  
  
-   `keyExp1`  
  
     Required. An expression that identifies the key to use to determine the groups of elements. You can specify more than one key to specify a composite key.  
  
-   `keyExp2`  
  
     Optional. One or more additional keys that are combined with `keyExp1` to create a composite key.  
  
-   `aggregateList`  
  
     Required. One or more expressions that identify how the groups are aggregated. To identify a member name for the grouped results, use the `Group` keyword, which can be in either of the following forms:  
  
    ```  
    Into Group  
    ```  
  
     -or-  
  
    ```  
    Into <alias> = Group  
    ```  
  
     You can also include aggregate functions to apply to the group.  
  
## Remarks  
 You can use the `Group By` clause to break the results of a query into groups. The grouping is based on a key or a composite key consisting of multiple keys. Elements that are associated with matching key values are included in the same group.  
  
 You use the `aggregateList` parameter of the `Into` clause and the `Group` keyword to identify the member name that is used to reference the group. You can also include aggregate functions in the `Into` clause to compute values for the grouped elements. For a list of standard aggregate functions, see [Aggregate Clause](../vs140/aggregate-clause--visual-basic-.md).  
  
## Example  
 The following code example groups a list of customers based on their location (country) and provides a count of the customers in each group. The results are ordered by country name. The grouped results are ordered by city name.  
  
 [!code[VbSimpleQuerySamples#11](../vs140/codesnippet/VisualBasic/group-by-clause--visual-basic-_1.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [Queries (Visual Basic)](../vs140/queries--visual-basic-.md)   
 [Select Clause](../vs140/select-clause--visual-basic-.md)   
 [From Clause](../vs140/from-clause--visual-basic-.md)   
 [Order By Clause](../vs140/order-by-clause--visual-basic-.md)   
 [Aggregate Clause](../vs140/aggregate-clause--visual-basic-.md)   
 [Group Join Clause (Visual Basic)](../vs140/group-join-clause--visual-basic-.md)