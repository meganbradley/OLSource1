---
title: "How to: Convert Hexadecimal Strings to Numbers (Visual Basic)"
ms.custom: na
ms.date: "09/21/2016"
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
  - "numbers, hexadecimals"
  - "hexadecimals, decimals"
  - "examples [Visual Basic], string conversion"
  - "decimals, hexadecimals"
  - "string conversion, hexadecimal to numbers"
ms.assetid: 76675807-eadb-4c08-bd50-e6c6ff4b8ced
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert Hexadecimal Strings to Numbers (Visual Basic)
This example converts a hexadecimal string to an integer using the \<xref:System.Convert.ToInt32*> method.  
  
### To convert a hexadecimal string to a number  
  
-   Use the \<xref:System.Convert.ToInt32*> method to convert the number expressed in base-16 to an integer.  
  
     The first argument of the \<xref:System.Convert.ToInt32*> method is the string to convert. The second argument describes what base the number is expressed in; hexadecimal is base 16.  
  
     [!code[VbVbalrStrings#62](../vs140/codesnippet/VisualBasic/how-to--convert-hexadecimal-strings-to-numbers--visual-basic-_1.vb)]  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Conversion.Hex*>   
 \<xref:System.Convert.ToInt32*>