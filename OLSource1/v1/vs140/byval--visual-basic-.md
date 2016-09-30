---
title: "ByVal (Visual Basic)"
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
  - "vb.ByVal"
  - "ByVal"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "ByVal keyword, contexts"
  - "ByVal keyword"
ms.assetid: 1eaf4e58-b305-4785-9e3d-e416b9c75598
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ByVal (Visual Basic)
Specifies that an argument is passed in such a way that the called procedure or property cannot change the value of a variable underlying the argument in the calling code.  
  
## Remarks  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> modifier can be used in these contexts:  
  
 [Declare Statement](../vs140/declare-statement.md)  
  
 [Function Statement](../vs140/function-statement--visual-basic-.md)  
  
 [Operator Statement](../vs140/operator-statement.md)  
  
 [Property Statement](../vs140/property-statement.md)  
  
 [Sub Statement](../vs140/sub-statement--visual-basic-.md)  
  
## Example  
 The following example demonstrates the use of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter passing mechanism with a reference type argument. In the example, the argument is <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, an instance of class <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> prevents the code in the procedures from changing the underlying value of the reference argument, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, but does not protect the accessible fields and properties of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [!code[VbVbalrKeywords#10](../vs140/codesnippet/VisualBasic/byval--visual-basic-_1.vb)]  
  
## See Also  
 [Keywords (Visual Basic)](../vs140/keywords--visual-basic-.md)   
 [Passing Arguments by Value and by Reference](../vs140/passing-arguments-by-value-and-by-reference--visual-basic-.md)