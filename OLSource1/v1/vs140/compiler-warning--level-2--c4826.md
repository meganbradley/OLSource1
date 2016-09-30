---
title: "Compiler Warning (level 2) C4826"
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
  - "C4826"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4826"
ms.assetid: 286f5c1d-8c14-43f7-aaa6-a891db2fdc64
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 2) C4826
Conversion from 'type1 ' to 'type_2' is sign-extended. This may cause unexpected runtime behavior.  
  
 This warning indicates that the compiler performed sign extension when a 32-bit pointer was cast to a 64-bit variable.  
  
 If the extension was performed on a windows HANDLE type, it is safe to ignore this warning. If the extension was performed on a pointer type, you should modify the cast to prevent the sign extension (see example below).  
  
 C4826 is off by default. See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.  
  
## Example  
 The following sample generates C4826.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>