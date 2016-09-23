---
title: "Full width characters are not valid as XML delimiters"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc31197
  - bc31197
helpviewer_keywords: 
  - BC31197
ms.assetid: f5d724f8-545b-4cf8-9606-12c63814c6e8
caps.latest.revision: 10
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Full width characters are not valid as XML delimiters
An XML literal has been defined that includes a full-width character as a delimiter. Full-width characters are also referred to as wide or multi-byte characters.  
  
 **Error ID:** BC31197  
  
### To correct this error  
  
-   Remove the full-width character from the XML literal definition and replace it with a valid ANSI delimiter character. Valid delimiter characters include the following: `<`, `>`, `=`, `:`, `/`.  
  
## See Also  
 [XML Literals](../vs140/xml-literals--visual-basic-.md)   
 [Understanding Encodings](assetId:///bf6d9823-4c2d-48af-b280-919c5af66ae9)   
 [XML in Visual Basic](../vs140/xml-in-visual-basic.md)