---
title: "Type for String Literals"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "string literals, type"
  - "types [C], string literals"
ms.assetid: f50a28af-20c1-4440-bdc6-564c86a309c8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Type for String Literals
String literals have type array of `char` (that is, **char[ ]**). (Wide-character strings have type array of `wchar_t` (that is, **wchar_t[ ]**).) This means that a string is an array with elements of type `char`. The number of elements in the array is equal to the number of characters in the string plus one for the terminating null character.  
  
## See Also  
 [C String Literals](../vs140/c-string-literals.md)