---
title: "&#39;Return&#39; statement in a Sub or a Set cannot return a value"
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
  - "bc30647"
  - "vbc30647"
helpviewer_keywords: 
  - "BC30647"
ms.assetid: d4c05c28-d650-4f49-976e-650d84802036
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Return&#39; statement in a Sub or a Set cannot return a value
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder> procedures and property <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> procedures cannot return values.  
  
 **Error ID:** BC30647  
  
### To correct this error  
  
-   Change the current procedure to a function, or to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> property procedure if the current procedure is part of a property.  
  
-   You can effectively return values from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> procedures by modifying the value of parameters passed by reference using the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword.  
  
## See Also  
 [Return Statement](../vs140/return-statement--visual-basic-.md)   
 [Sub Procedures](../vs140/sub-procedures--visual-basic-.md)   
 [Function Procedures](../vs140/function-procedures--visual-basic-.md)   
 [Property Procedures](../vs140/property-procedures--visual-basic-.md)