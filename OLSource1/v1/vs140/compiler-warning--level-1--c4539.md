---
title: "Compiler Warning (level 1) C4539"
ms.custom: na
ms.date: 09/21/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C4539
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4539
ms.assetid: a47ebf87-5e6a-43c9-89fd-f80c40b3a7f5
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 1) C4539
'char': a universal-character-name specifies an invalid character  
  
 A character was specified out of Unicode range.  
  
 The character must be in the Unicode range, or be a valid surropate pair.  
  
## Example  
 The following sample generates C4539  
  
```  
// C4539.cpp  
// compile with: /W1  
int main() {  
   char \U12345678 = 'x';   // C4539  
   char \u2134 = 'x';   // OK 16-bit Unicode char  
   char \UD808DF45 = 'x';   // OK 32-bit Unicode value  
}  
```