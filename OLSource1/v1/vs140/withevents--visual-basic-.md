---
title: "WithEvents (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.WithEvents"
  - "WithEvents"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "WithEvents keyword"
ms.assetid: 19d461f5-d72f-4de9-8c1d-0a6650316990
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# WithEvents (Visual Basic)
Specifies that one or more declared member variables refer to an instance of a class that can raise events.  
  
## Remarks  
 When a variable is defined using <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, you can declaratively specify that a method handles the variable's events using the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> keyword.  
  
 You can use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> only at class or module level. This means the declaration context for a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variable must be a class or module and cannot be a source file, namespace, structure, or procedure.  
  
 You cannot use <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on a structure member.  
  
 You can declare only individual variables—not arrays—with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Rules  
  
-   **Element Types.** You must declare <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> variables to be object variables so that they can accept class instances. However, you cannot declare them as <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. You must declare them as the specific class that can raise the events.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> modifier can be used in this context: [Dim Statement](../vs140/dim-statement--visual-basic-.md)  
  
## See Also  
 [Handles](../vs140/handles-clause--visual-basic-.md)   
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)   
 [Events in Visual Basic](../vs140/events--visual-basic-.md)