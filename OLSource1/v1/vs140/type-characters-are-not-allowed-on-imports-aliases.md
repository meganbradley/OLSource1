---
title: "Type characters are not allowed on Imports aliases"
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
  - "vbc31398"
  - "BC31398"
helpviewer_keywords: 
  - "BC31398"
ms.assetid: 0620669d-b529-49f3-9deb-aeda4dacc58a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type characters are not allowed on Imports aliases
An import alias in an <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> statement contains at least one identifier type character.  
  
 An import alias must be a valid Visual Basic name. The allowed characters do not include any of the identifier type characters (<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>). See [Declared Element Names](../vs140/declared-element-names--visual-basic-.md).  
  
 **Error ID:** BC31398  
  
### To correct this error  
  
-   Remove the type identifier character or characters from the import alias.  
  
## See Also  
 [Type Characters](../vs140/type-characters--visual-basic-.md)   
 [Declared Element Names](../vs140/declared-element-names--visual-basic-.md)   
 [Imports Statement](../vs140/imports-statement--.net-namespace-and-type-.md)   
 [NOTINBUILD: Resolving a Reference When Multiple Variables Have the Same Name](assetId:///9601e39f-1911-44e1-ace5-3f6e090408b9)