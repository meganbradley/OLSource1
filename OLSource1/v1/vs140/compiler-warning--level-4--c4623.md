---
title: "Compiler Warning (level 4) C4623"
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
  - "C4623"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4623"
ms.assetid: e630d8d0-f6ea-469c-a74f-07b027587225
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4623
'<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>' : default constructor was implicitly defined as deleted because a base class default constructor is inaccessible or deleted  
  
 A constructor was not accessible in a base class and was not generated for the derived class. Any attempt to create an object of this type on the stack will cause a compiler error.  
  
 This warning is off by default. See [Compiler Warnings That Are Off by Default](../vs140/compiler-warnings-that-are-off-by-default.md) for more information.  
  
## Example  
 The following sample generates C4623.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>