---
title: "Let Clause (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.QueryLet"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "queries [Visual Basic], Let"
  - "Let clause"
  - "Let statement"
ms.assetid: 981aa516-16eb-4c53-b1f1-5aa3e82f316e
caps.latest.revision: 16
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Let Clause (Visual Basic)
Computes a value and assigns it to a new variable within the query.  
  
## Syntax  
  
```  
Let variable = expression [, ...]  
```  
  
## Parts  
  
|||  
|-|-|  
|Term|Definition|  
|`variable`|Required. An alias that can be used to reference the results of the supplied expression.|  
|`expression`|Required. An expression that will be evaluated and assigned to the specified variable.|  
  
## Remarks  
 The `Let` clause enables you to compute values for each query result and reference them by using an alias. The alias can be used in other clauses, such as the `Where` clause. The `Let` clause enables you to create a query statement that is easier to read because you can specify an alias for an expression clause included in the query and substitute the alias each time the expression clause is used.  
  
 You can include any number of `variable` and `expression` assignments in the `Let` clause. Separate each assignment with a comma (,).  
  
## Example  
 The following code example uses the `Let` clause to compute a 10 percent discount on products.  
  
 [!code[VbSimpleQuerySamples#16](../VS_visualbasic/codesnippet/VisualBasic/let-clause--visual-basic-_1.vb)]  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../VS_visualbasic/introduction-to-linq-in-visual-basic.md)   
 [Queries](../VS_visualbasic/queries--visual-basic-.md)   
 [Select Clause](../VS_visualbasic/select-clause--visual-basic-.md)   
 [From Clause](../VS_visualbasic/from-clause--visual-basic-.md)   
 [Where Clause](../VS_visualbasic/where-clause--visual-basic-.md)