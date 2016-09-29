---
title: "Range variable name can be inferred only from a simple or qualified name with no arguments"
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
  - "vbc36599"
  - "bc36599"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC36599"
ms.assetid: 17763dbe-f74f-4ccb-8086-cb7e45ec4d12
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Range variable name can be inferred only from a simple or qualified name with no arguments
A programming element that takes one or more arguments is included in a LINQ query. The compiler is unable to infer a range variable from that programming element.  
  
 **Error ID:** BC36599  
  
### To correct this error  
  
1.  Supply an explicit variable name for the programming element, as shown in the following code:  
  
```  
Dim query = From var1 In collection1   
            Select VariableAlias= SampleFunction(var1), var1  
```  
  
## See Also  
 [Introduction to LINQ in Visual Basic](../VS_csharp/introduction-to-linq-in-visual-basic.md)   
 [Select Clause (Visual Basic)](../VS_csharp/select-clause--visual-basic-.md)