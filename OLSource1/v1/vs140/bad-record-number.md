---
title: "Bad record number"
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
  - "vbrID63"
ms.assetid: 1fcc33f8-822a-4de9-a6e3-228ddb5824a6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Bad record number
The record number in <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement is less than or equal to zero.  
  
### To correct this error  
  
1.  Check the calculations used in generating the record number. Verify spelling of the variables containing the record number or used in calculating record numbers. A misspelled variable name is implicitly declared and initialized to zero, unless you used <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in the module.  
  
## See Also  
 [Option Explicit Statement](../vs140/option-explicit-statement--visual-basic-.md)