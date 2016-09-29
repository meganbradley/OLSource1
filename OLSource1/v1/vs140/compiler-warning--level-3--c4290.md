---
title: "Compiler Warning (level 3) C4290"
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
  - "C4290"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4290"
ms.assetid: d1c6d85b-28e0-4a1f-9d48-23593337a6fb
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4290
C++ exception specification ignored except to indicate a function is not __declspec(nothrow)  
  
 A function is declared using exception specification, which Visual C++ accepts but does not implement. Code with exception specifications that are ignored during compilation may need to be recompiled and linked to be reused in future versions supporting exception specifications.  
  
 For more information, see [Exception Specifications](../vs140/exception-specifications--throw---c---.md) .  
  
 You can avoid this warning by using the [warning](../vs140/warning.md) pragma:  
  
```  
#pragma warning( disable : 4290 )  
```  
  
 The following code sample generates C4290:  
  
```  
// C4290.cpp  
// compile with: /EHs /W3 /c  
void f1(void) throw(int) {}   // C4290  
  
// OK  
void f2(void) throw() {}  
void f3(void) throw(...) {}  
```