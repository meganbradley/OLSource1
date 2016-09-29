---
title: "Storage of String Literals"
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
  - "string literals, storage"
ms.assetid: ba5e4d2c-d456-44b3-a8ca-354af547ac50
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Storage of String Literals
The characters of a literal string are stored in order at contiguous memory locations. An escape sequence (such as **\\\\** or **\\"**) within a string literal counts as a single character. A null character (represented by the **\0** escape sequence) is automatically appended to, and marks the end of, each string literal. (This occurs during [translation phase](../VS_csharp/phases-of-translation.md) 7.) Note that the compiler may not store two identical strings at two different addresses. [/GF](../VS_csharp/-gf--eliminate-duplicate-strings-.md) forces the compiler to place a single copy of identical strings into the executable file.  
  
## Remarks  
 **Microsoft Specific**  
  
 Strings have static storage duration. See [Storage Classes](../VS_csharp/c-storage-classes.md) for information about storage duration.  
  
 **END Microsoft Specific**  
  
## See Also  
 [C String Literals](../VS_csharp/c-string-literals.md)