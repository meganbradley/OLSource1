---
title: "How to: Create a String from An Array of Char Values (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "examples [Visual Basic], arrays"
  - "examples [Visual Basic], Char data type"
ms.assetid: 69f94e85-d57c-4ccc-a62a-426e829f5c5e
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a String from An Array of Char Values (Visual Basic)
This example creates the string "abcd" from individual characters.  
  
## Example  
 [!code[VbVbalrStrings#61](../vs140/codesnippet/VisualBasic/how-to--create-a-string-from-an-array-of-char-values--visual-basic-_1.vb)]  
  
## Compiling the Code  
 This method has no special requirements.  
  
 The syntax <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, where a single <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> follows a single character in quotation marks, is used to create a character literal.  
  
## Robust Programming  
 Null characters (equivalent to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) in the string lead to unexpected results when using the string. The null character will be included with the string, but characters following the null character will not be displayed in some situations.  
  
## See Also  
 \<xref:System.String*>   
 [Char Data Type](../vs140/char-data-type--visual-basic-.md)   
 [Data Types](../vs140/data-types-in-visual-basic.md)