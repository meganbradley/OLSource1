---
title: "&#39;&lt;methodname&gt;&#39; cannot shadow a method declared &#39;MustOverride&#39;"
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
  - "vbc31404"
  - "bc31404"
helpviewer_keywords: 
  - "BC31404"
ms.assetid: 3e7bb4a0-14af-46ba-bc62-2234c16f1827
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;&lt;methodname&gt;&#39; cannot shadow a method declared &#39;MustOverride&#39;
A property or method with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> modifier and the same name is declared in a deriving class.  
  
 **Error ID:** BC31404  
  
### To correct this error  
  
1.  Add the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> modifier to the overriding property or method in the derived class.  
  
2.  Remove the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> modifier from the property or method in the base class.  
  
## See Also  
 [MustOverride](../vs140/mustoverride--visual-basic-.md)