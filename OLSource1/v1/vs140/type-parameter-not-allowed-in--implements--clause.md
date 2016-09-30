---
title: "Type parameter not allowed in &#39;Implements&#39; clause"
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
  - "vbc32056"
  - "bc32056"
helpviewer_keywords: 
  - "BC32056"
ms.assetid: a62d773b-e878-4817-8638-da49849477d7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type parameter not allowed in &#39;Implements&#39; clause
An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause in a generic type specifies a type parameter as the member to be implemented.  
  
 An <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause must specify an interface and a member. It can pass a type parameter to the interface, but it cannot pass it to the member, nor use it as the name of the member.  
  
 The following statements can generate this error.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Error ID:** BC32056  
  
### To correct this error  
  
-   Specify the interface name and a genuine member of the interface following the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword. You can pass the type parameter to the interface if appropriate.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Implements (Visual Basic)](../vs140/implements-clause--visual-basic-.md)   
 [NOT IN BUILD: Implements Keyword and Implements Statement](assetId:///b96560f7-6413-480f-a1e2-f80253bab5be)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)