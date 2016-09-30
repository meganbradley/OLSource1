---
title: "Static (Visual Basic)"
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
  - "vb.Static"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "static modifier"
  - "Static keyword"
ms.assetid: 19013910-4658-47b6-a22e-1744b527979e
caps.latest.revision: 26
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Static (Visual Basic)
Specifies that one or more declared local variables are to continue to exist and retain their latest values after termination of the procedure in which they are declared.  
  
## Remarks  
 Normally, a local variable in a procedure ceases to exist as soon as the procedure stops. A static variable continues to exist and retains its most recent value. The next time your code calls the procedure, the variable is not reinitialized, and it still holds the latest value that you assigned to it. A static variable continues to exist for the lifetime of the class or module that it is defined in.  
  
## Rules  
  
-   **Declaration Context.** You can use <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> only on local variables. This means the declaration context for a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> variable must be a procedure or a block in a procedure, and it cannot be a source file, namespace, class, structure, or module.  
  
     You cannot use <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> inside a structure procedure.  
  
-   The data types of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> local variables cannot be inferred. For more information, see [Local Type Inference](../vs140/local-type-inference--visual-basic-.md).  
  
-   **Combined Modifiers.** You cannot specify <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> together with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in the same declaration.  
  
## Behavior  
 When you declare a static variable in a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> procedure, only one copy of the static variable is available for the whole application. You call a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> procedure by using the class name, not a variable that points to an instance of the class.  
  
 When you declare a static variable in a procedure that isn't <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, only one copy of the variable is available for each instance of the class. You call a non-shared procedure by using a variable that points to a specific instance of the class.  
  
## Example  
 The following example demonstrates the use of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrKeywords#5](../vs140/codesnippet/VisualBasic/static--visual-basic-_1.vb)]  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> variable <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is initialized to 0 only one time. Each time that you enter <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> still has the most recent value that you calculated for it.  
  
 The <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> modifier can be used in this context:  
  
 [Dim Statement](../vs140/dim-statement--visual-basic-.md)  
  
## See Also  
 [Shadows](../vs140/shadows--visual-basic-.md)   
 [Shared](../vs140/shared--visual-basic-.md)   
 [Lifetime in Visual Basic](../vs140/lifetime-in-visual-basic.md)   
 [Variable Declaration](../vs140/variable-declaration-in-visual-basic.md)   
 [Structures](../vs140/structures--visual-basic-.md)   
 [Local Type Inference](../vs140/local-type-inference--visual-basic-.md)   
 [Objects and Classes in Visual Basic](../vs140/objects-and-classes-in-visual-basic.md)