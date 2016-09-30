---
title: "Compiler Error C2690"
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
  - "C2690"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2690"
ms.assetid: f165a806-14bd-4942-99b7-8a9fc7dea227
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2690
'operator' : cannot perform pointer arithmetic on a managed or WinRT array  
  
 Pointer arithmetic is not allowed on a managed or WinRT array. Use array index notation to traverse the array.  
  
 **Managed Extensions for C++**  
  
 Pointer arithmetic is not allowed on a [__gc](../vs140/__gc.md) array. Use array index notation to traverse the array.  
  
 The following sample generates C2690:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>