---
title: "Compiler Error CS0623"
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
  - "CS0623"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS0623"
ms.assetid: c9fd6888-b9c5-48bf-b25b-2fae1446ad24
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS0623
Array initializers can only be used in a variable or field initializer. Try using a new expression instead.  
  
 An attempt was made to initialize an array by using an array initializer in a context where it is not allowed.  
  
## Example  
 The following example produces CS0623 because the compiler interprets the {4} as embedded array initializer inside the outer array initializer:  
  
```  
//cs0632.cs  
using System;  
  
class X  
{  
    public int[] x = { 2, 3, {4}}; //CS0623  
}  
```  
  
## See Also  
 [Arrays (C# Programming Guide)](../vs140/arrays--csharp-programming-guide-.md)