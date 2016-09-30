---
title: "&#39;New&#39; cannot be used on a class that is declared &#39;MustInherit&#39;"
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
  - "vbc30569"
  - "bc30569"
helpviewer_keywords: 
  - "BC30569"
ms.assetid: 94c9e6a3-6489-4d58-b7e5-7b4203677e3b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;New&#39; cannot be used on a class that is declared &#39;MustInherit&#39;
A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class cannot be instantiated directly, and therefore the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator cannot be used on a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class. Although it's possible to have variables and values whose compile time types are <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, such variables and values will necessarily either be a null value or contain references to instances of regular classes derived from the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> types.  
  
 **Error ID:** BC30569  
  
### To correct this error  
  
-   Remove the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operator.  
  
## See Also  
 [MustInherit](../vs140/mustinherit--visual-basic-.md)   
 [New Operator](../vs140/new-operator--visual-basic-.md)