---
title: "Operator &#39;&lt;operatorname&gt;&#39; is not defined for types &#39;&lt;typename1&gt;&#39; and &#39;&lt;typename2&gt;&#39;"
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
  - "vbc31080"
  - "bc31080"
helpviewer_keywords: 
  - "BC31080"
ms.assetid: d2f77450-2bf2-4b1e-b95f-dbc7878f2777
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Operator &#39;&lt;operatorname&gt;&#39; is not defined for types &#39;&lt;typename1&gt;&#39; and &#39;&lt;typename2&gt;&#39;
Operator '\<operatorname>' is not defined for types '\<typename1>' and '\<typename2>'. Use 'Is' operator to compare two reference types.  
  
 An attempt was made to use an operator in a way that is inappropriate for the specified types. This error can be caused by using the "=" operator instead of using the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> operator to compare two objects.  
  
 **Error ID:** BC31080  
  
### To correct this error  
  
1.  Use <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> operator to compare two reference types.  
  
2.  Use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator in conjunction with the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> operator to denote inequality. For example:  
  
     [!code[VbVbalrOOP#89](../vs140/codesnippet/VisualBasic/operator---operatorname---is-not-defined-for-types---typename1---and---typename2--_1.vb)]  
  
## See Also  
 [Is Operator](../vs140/is-operator--visual-basic-.md)   
 [= Operator](../vs140/=-operator--visual-basic-.md)   
 [Not Operator](../vs140/not-operator--visual-basic-.md)