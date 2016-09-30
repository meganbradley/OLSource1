---
title: "Non-shared members in a Structure cannot be declared &#39;New&#39;"
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
  - "vbc30795"
  - "BC30795"
helpviewer_keywords: 
  - "BC30795"
ms.assetid: 8e4e1ad8-3bac-475f-82e8-e4f134692204
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Non-shared members in a Structure cannot be declared &#39;New&#39;
A nonshared variable in a structure is declared with a <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> clause.  
  
 You can initialize a shared reference variable in a structure, and you can have a nonshared reference variable without initialization, as the following code lines show.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 However, you cannot initialize a nonshared reference variable in a structure. The following code line is invalid.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 **Error ID:** BC30795  
  
### To correct this error  
  
-   Remove either the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> modifier or the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword from the reference variable declaration.  
  
## See Also  
 [Structure Statement](../vs140/structure-statement.md)   
 [Shared (Visual Basic)](../vs140/shared--visual-basic-.md)   
 [New (Visual Basic)](../vs140/new-operator--visual-basic-.md)