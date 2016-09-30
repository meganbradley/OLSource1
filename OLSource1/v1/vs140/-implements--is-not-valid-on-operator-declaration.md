---
title: "&#39;Implements&#39; is not valid on operator declaration"
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
  - "vbc33004"
  - "bc33004"
helpviewer_keywords: 
  - "BC33004"
ms.assetid: 22f27f4d-4bbd-4f8f-a6e8-0fc10efb268d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &#39;Implements&#39; is not valid on operator declaration
An [Operator Statement](../vs140/operator-statement.md) specifies the [Implements (Visual Basic)](../vs140/implements-clause--visual-basic-.md) keyword.  
  
 Only a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> procedure, a property, or an event can implement an interface member. For more information on implementation, see [NOT IN BUILD: Interface Implementation Examples in Visual Basic](assetId:///50bf2a30-73b6-4126-a921-075fd6eec278).  
  
 An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> procedure requires both the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keywords, and a conversion operator requires either the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> keyword. For more information, see [Operator Procedures](../vs140/operator-procedures--visual-basic-.md).  
  
 **Error ID:** BC33004  
  
### To correct this error  
  
-   If you intend this procedure to implement an interface member, rewrite it as a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> procedure, a property, or an event.  
  
-   If you intend this procedure to define an operator, remove the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword from its declaration.  
  
## See Also  
 [Operator Statement](../vs140/operator-statement.md)   
 [How to: Define an Operator](../vs140/how-to--define-an-operator--visual-basic-.md)   
 [How to: Define a Conversion Operator](../vs140/how-to--define-a-conversion-operator--visual-basic-.md)