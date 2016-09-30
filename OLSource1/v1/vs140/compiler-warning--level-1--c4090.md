---
title: "Compiler Warning (level 1) C4090"
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
  - "C4090"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4090"
ms.assetid: baad469d-23d4-45aa-ad9c-305b32d61e9a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 1) C4090
'operation' : different 'modifier' qualifiers  
  
 A variable used in an operation is defined with a specified modifier that prevents it from being modified without detection by the compiler. The expression is compiled without modification.  
  
 This warning can be caused when a pointer to a **const** or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> item is assigned to a pointer not declared as pointing to **const** or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 This warning is issued for C programs. In a C++ program, the compiler issues an error: [C2440](../vs140/compiler-error-c2440.md).  
  
 The following sample generates C4090:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>