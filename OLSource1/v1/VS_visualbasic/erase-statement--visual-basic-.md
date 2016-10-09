---
title: "Erase Statement (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 9
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Erase Statement (Visual Basic)
Used to release array variables and deallocate the memory used for their elements.  
  
## Syntax  
  
```  
Erase arraylist  
```  
  
## Parts  
 `arraylist`  
 Required. List of array variables to be erased. Multiple variables are separated by commas.  
  
## Remarks  
 The `Erase` statement can appear only at procedure level. This means you can release arrays inside a procedure but not at class or module level.  
  
 The `Erase` statement is equivalent to assigning `Nothing` to each array variable.  
  
## Example  
 The following example uses the `Erase` statement to clear two arrays and free their memory (1000 and 100 storage elements, respectively). The `ReDim` statement then assigns a new array instance to the three-dimensional array.  
  
 [!code[VbVbalrStatements#19](../VS_visualbasic/codesnippet/VisualBasic/erase-statement--visual-basic-_1.vb)]  
  
## See Also  
 [Nothing](../VS_visualbasic/nothing--visual-basic-.md)   
 [ReDim Statement](../VS_visualbasic/redim-statement--visual-basic-.md)