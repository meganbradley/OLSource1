---
title: "Compiler Warning (level 4) C4837"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C4837"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4837"
ms.assetid: 9a3c7b6b-ffe4-443d-96af-43deb80d85b4
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4837
trigraph detected: '??%c' replaced by '%c'  
  
 The detected trigraph is replaced by the indicated character.  
  
 The compiler translates trigraphs before any other processing is completed. Use the character escape sequence, `\?`, to prevent the misinterpretation of a character sequence that resembles a trigraph. For more information about trigraphs, see [Trigraphs](../vs140/trigraphs.md). For more information about escape sequences, see [Escape Sequences](../vs140/escape-sequences.md).  
  
 C4837 is off by default. See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.  
  
### To correct this error  
  
1.  Use the character escape sequence, `\?`, instead of one of the '?' characters in the source code.  
  
## See Also  
 [Trigraphs](../vs140/trigraphs.md)   
 [Sequences](../vs140/escape-sequences.md)   
 [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md)