---
title: "How to: Search Within a String (Visual Basic)"
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
  - "strings [Visual Basic], finding"
  - "strings [Visual Basic], searching"
  - "examples [Visual Basic], strings"
ms.assetid: ae4c79e0-08ea-489f-bdb2-5eb6d355f284
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Search Within a String (Visual Basic)
This example calls the [IndexOf](assetId:///M:System.String.IndexOf(System.String)?qualifyHint=False&autoUpgrade=True) method on a <xref:System.String*> object to report the index of the first occurrence of a substring.  
  
## Example  
 [!code[VbVbalrStrings#71](../vs140/codesnippet/VisualBasic/how-to--search-within-a-string--visual-basic-_1.vb)]  
  
## Compiling the Code  
 This example requires:  
  
-   An `Imports` statement specifying the <xref:System*> namespace. For more information, see [Imports Statement](../vs140/imports-statement--.net-namespace-and-type-.md).  
  
## Robust Programming  
 The assetId:///M:System.String.IndexOf(System.String)?qualifyHint=False&autoUpgrade=True method reports the location of the first character of the first occurrence of the substring. The index is 0-based, which means the first character of a string has an index of 0.  
  
 If assetId:///M:System.String.IndexOf(System.String)?qualifyHint=False&autoUpgrade=True does not find the substring, it returns -1.  
  
 The assetId:///M:System.String.IndexOf(System.String)?qualifyHint=False&autoUpgrade=True method is case-sensitive and uses the current culture.  
  
 For optimal error control, you might want to enclose the string search in the `Try` block of a [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md) construction.  
  
## See Also  
 assetId:///M:System.String.IndexOf(System.String)?qualifyHint=False&autoUpgrade=True   
 [Try...Catch...Finally Statement (Visual Basic)](../vs140/try...catch...finally-statement--visual-basic-.md)   
 [Introduction to Strings in Visual Basic](../vs140/introduction-to-strings-in-visual-basic.md)   
 [Strings in Visual Basic](../vs140/strings-in-visual-basic.md)