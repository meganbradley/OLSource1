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
 When a variable is defined using `WithEvents`, you can declaratively specify that a method handles the variable's events using the `Handles` keyword.  
  
 You can use `WithEvents` only at class or module level. This means the declaration context for a `WithEvents` variable must be a class or module and cannot be a source file, namespace, structure, or procedure.  
  
 You cannot use `WithEvents` on a structure member.  
  
 You can declare only individual variables—not arrays—with `WithEvents`.  
  
## Rules  
  
-   **Element Types.** You must declare `WithEvents` variables to be object variables so that they can accept class instances. However, you cannot declare them as `Object`. You must declare them as the specific class that can raise the events.  
  
 The `WithEvents` modifier can be used in this context: [Dim Statement](../VS_csharp/dim-statement--visual-basic-.md)  
  
## See Also  
 [Handles](../VS_csharp/handles-clause--visual-basic-.md)   
 [Keywords (Visual Basic)](../VS_csharp/keywords--visual-basic-.md)   
 [Events in Visual Basic](../VS_csharp/events--visual-basic-.md)