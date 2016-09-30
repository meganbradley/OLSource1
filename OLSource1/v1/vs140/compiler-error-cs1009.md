---
title: "Compiler Error CS1009"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "CS1009"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "CS1009"
ms.assetid: 348f500c-0e4f-44d7-95a8-e215ac49940a
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error CS1009
Unrecognized escape sequence  
  
 An unexpected character follows a backslash (\\) in a [string](../vs140/string--csharp-reference-.md). The compiler expects one of the valid escape characters. For more information, see [Character Escapes](assetId:///f49cc9cc-db7d-4058-8b8a-422bc08b29b0).  
  
 The following sample generates CS1009.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 A common cause of this error is using the backslash character in a file name, as the following example shows.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To resolve this error, use "\\\\" or the @-quoted string literal, as the following example shows.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [string (C# Reference)](../vs140/string--csharp-reference-.md)