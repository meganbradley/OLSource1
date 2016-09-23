---
title: "Compiler Warning (level 4) C4295"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C4295
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4295
ms.assetid: 20dbff85-9f62-4ca3-8fe9-079d4512006d
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning (level 4) C4295
**'**   
 ***array* ' : array is too small to include a terminating null character**  
  
 An array was initialized but the last character in the array is not a null; accessing the array may produce unexpected results.  
  
 The following sample generates C4295:  
  
```  
// C4295.c  
// compile with: /W4  
  
int main() {  
   char a[3] = "abc";   // C4295  
}  
```