---
title: "Instance members and &#39;Me&#39; cannot be used in a query expression"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vbc36535"
  - "bc36535"
helpviewer_keywords: 
  - "BC36535"
ms.assetid: afb5281b-70a7-48c7-a46d-39522b96b1ff
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Instance members and &#39;Me&#39; cannot be used in a query expression
A LINQ query in a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> includes a reference to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or to an instance member of the structure. References to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or instance members are not allowed in query expressions within a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 **Error ID:** BC36535  
  
### To correct this error  
  
1.  Create a copy of the instance member or the value returned by the reference to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and use the copy in the query expression, as shown in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 [Introduction to LINQ in Visual Basic](../vs140/introduction-to-linq-in-visual-basic.md)   
 [LINQ in Visual Basic](../vs140/linq-in-visual-basic.md)   
 [Me](assetId:///a65973c7-cf06-4547-9b25-9fba885525c2)   
 [Structure (Visual Basic)](assetId:///263ce115-ac36-4c05-8cb7-0e0eead5c6d0)