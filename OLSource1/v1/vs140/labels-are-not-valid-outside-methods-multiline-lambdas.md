---
title: "Labels are not valid outside methods-multiline lambdas"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Labels are not valid outside methods/multiline lambdas"
f1_keywords: 
  - "vbc30016"
  - "bc30016"
helpviewer_keywords: 
  - "BC30016"
ms.assetid: 17d12a96-d759-4df9-882c-5e45c1d814a5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Labels are not valid outside methods-multiline lambdas
You can add a label to a statement only within a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, property <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, or property <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> procedure. Only an executable statement can have a label, and all executable statements must be inside procedures.  
  
 **Error ID:** BC30016  
  
### To correct this error  
  
1.  Remove the label from the statement, or move the statement inside a procedure.  
  
## See Also  
 [How to: Label Statements](../vs140/how-to--label-statements--visual-basic-.md)   
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)   
 [Function Statement](../vs140/function-statement--visual-basic-.md)   
 [Get Statement](../vs140/get-statement.md)   
 [Set Statement](../vs140/set-statement--visual-basic-.md)