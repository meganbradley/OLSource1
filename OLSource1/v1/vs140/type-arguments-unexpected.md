---
title: "Type arguments unexpected"
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
  - "vbc32088"
  - "bc32088"
helpviewer_keywords: 
  - "BC32088"
ms.assetid: a0918e90-e7ad-4edc-81e1-584e6174bb6c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type arguments unexpected
An <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause supplies type arguments for the interface member it is implementing.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause should only identify the interface and member it is implementing. This means that if you are declaring a generic procedure, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause and the type arguments should appear in the main part of the declaration, just as they would if you were not implementing an interface procedure.  
  
 The following code can generate this error.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The declaration preceding the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause should look like the interface definition, except for the possible addition of access or procedure modifiers. The following code avoids the error.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Error ID:** BC32088  
  
### To correct this error  
  
-   Remove the type argument list from the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause.  
  
-   If you are implementing a generic member of the interface, then put the type argument list in the main part of the declaration, preceding the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword.  
  
## See Also  
 [Implements (Visual Basic)](../vs140/implements-clause--visual-basic-.md)   
 [NOT IN BUILD: Implements Keyword and Implements Statement](assetId:///b96560f7-6413-480f-a1e2-f80253bab5be)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Generic Procedures in Visual Basic](../vs140/generic-procedures-in-visual-basic.md)   
 [Type List](../vs140/type-list--visual-basic-.md)