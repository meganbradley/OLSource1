---
title: "Initializer expected"
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
  - "vbc30996"
  - "bc30996"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "BC30996"
ms.assetid: 6e183fe0-8888-43ed-a062-01571079455f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Initializer expected
You have tried to declare an instance of a class by using an object initializer in which the initialization list is empty, as shown in the following example.  
  
 `' Not valid.`  
  
 `' Dim aStudent As New Student With {}`  
  
 At least one field or property must be initialized in the initializer list, as shown in the following example.  
  
 `Dim aStudent As New Student With {.year = "Senior"}`  
  
 **Error ID:** BC30996  
  
### To correct this error  
  
1.  Initialize at least one field or property in the initializer, or do not use an object initializer.  
  
## See Also  
 [Object Initializers](../vs140/object-initializers--named-and-anonymous-types--visual-basic-.md)   
 [How to: Declare an Object by Using an Object Initializer](../vs140/how-to--declare-an-object-by-using-an-object-initializer--visual-basic-.md)