---
title: "Type character cannot be used in a type parameter declaration"
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
  - "vbc32041"
  - "bc32041"
helpviewer_keywords: 
  - "BC32041"
ms.assetid: 24f9a514-f3d4-46c3-805c-71225f6fec59
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type character cannot be used in a type parameter declaration
A type parameter declaration contains at least one identifier type character.  
  
 A type parameter of a generic type must be a valid Visual Basic name. The allowed characters do not include any of the identifier type characters (<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>). See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
 **Error ID:** BC32041  
  
### To correct this error  
  
-   Remove the type identifier character or characters from the type parameter declaration.  
  
## See Also  
 [Type Characters](../vs140/type-characters--visual-basic-.md)   
 [Declared Element Names](../vs140/declared-element-names--visual-basic-.md)   
 [Generic Types in Visual Basic](../vs140/generic-types-in-visual-basic--visual-basic-.md)   
 [Type List](../vs140/type-list--visual-basic-.md)