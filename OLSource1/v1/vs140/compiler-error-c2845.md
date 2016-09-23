---
title: "Compiler Error C2845"
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
  - C2845
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2845
ms.assetid: 31b28ee9-978f-403b-94d8-dbaacd24cce0
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2845
'operator' : pointer arithmetic not allowed on this type  
  
 You cannot increment the pointer to a managed class.  
  
 **Managed Extensions for C++**  
  
 You cannot increment the pointer to a [__gc](../vs140/__gc.md) class.  Also, string operators are only valid with **/clr** (not **/clr:oldSyntax**).  
  
 The following sample generates C2845:  
  
```  
// C2845b.cpp  
// compile with: /clr:oldSyntax  
using namespace System;  
__gc class X {};  
  
int main() {  
   X *pX = new X;  
   pX++;   // C2845  
  
   String * a = new String("abc");  
   String * b = new String("def");  
   Console::WriteLine(a + b);   // C2845 not with /clr:oldSyntax  
}  
```