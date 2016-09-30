---
title: "Erase Statement (Visual Basic)"
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
  - "vb.Erase"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Erase keyword"
  - "Erase statement"
ms.assetid: 7a8133d7-b750-4d74-8b66-ba1dd9778d4b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Erase Statement (Visual Basic)
Used to release array variables and deallocate the memory used for their elements.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Parts  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Required. List of array variables to be erased. Multiple variables are separated by commas.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement can appear only at procedure level. This means you can release arrays inside a procedure but not at class or module level.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> statement is equivalent to assigning <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to each array variable.  
  
## Example  
 The following example uses the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> statement to clear two arrays and free their memory (1000 and 100 storage elements, respectively). The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement then assigns a new array instance to the three-dimensional array.  
  
 [!code[VbVbalrStatements#19](../vs140/codesnippet/VisualBasic/erase-statement--visual-basic-_1.vb)]  
  
## See Also  
 [Nothing](../vs140/nothing--visual-basic-.md)   
 [ReDim Statement](../vs140/redim-statement--visual-basic-.md)