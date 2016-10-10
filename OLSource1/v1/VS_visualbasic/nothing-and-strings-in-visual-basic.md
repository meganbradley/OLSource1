---
title: "Nothing and Strings in Visual Basic"
ms.custom: na
ms.date: "10/10/2016"
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
  - "strings [Visual Basic], Nothing"
ms.assetid: 261380af-2024-4ecf-823b-43b1034d92cd
caps.latest.revision: 8
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
# Nothing and Strings in Visual Basic
The [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] runtime and the [!INCLUDE[dnprdnshort](../VS_visualbasic/includes/dnprdnshort_md.md)] evaluate `Nothing` differently when it comes to strings.  
  
## Visual Basic Runtime and the .NET Framework  
 Consider the following example:  
  
 [!code[VbVbalrStrings#47](../VS_visualbasic/codesnippet/VisualBasic/nothing-and-strings-in-visual-basic_1.vb)]  
  
 The [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)] runtime usually evaluates `Nothing` as an empty string (""). The [!INCLUDE[dnprdnshort](../VS_visualbasic/includes/dnprdnshort_md.md)] does not, however, and throws an exception whenever an attempt is made to perform a string operation on `Nothing`.  
  
## See Also  
 [Introduction to Strings in Visual Basic](../VS_visualbasic/introduction-to-strings-in-visual-basic.md)