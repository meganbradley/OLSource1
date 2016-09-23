---
title: "Compiler Warning C4957"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C4957
dev_langs: 
  - C++
helpviewer_keywords: 
  - C4957
ms.assetid: a18c52d4-23e2-44f1-b4b5-f7fa5a7f3987
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Warning C4957
'cast' : explicit cast from 'cast_from' to 'cast_to' is not verifiable  
  
 A cast will result in an unverifiable image.  
  
 Some casts are safe (for example, a `static_cast` that triggers user-defined conversions and a `const_cast`). A [safe_cast](../vs140/safe_cast--c---component-extensions-.md) is guaranteed to produce verifiable code.  
  
 For more information, see [Pure / Verifiable](../vs140/pure-and-verifiable-code--c---cli-.md).  
  
 This warning is issued as an error and can be disabled with the [warning](../vs140/warning.md) pragma or the [/wd](../vs140/-w---w0---w1---w2---w3---w4---w1---w2---w3---w4---wall---wd---we---wo---wv---wx--warning-level-.md) compiler option.  
  
 The following sample generates C4957:  
  
```  
// C4957.cpp  
// compile with: /clr:safe  
// #pragma warning( disable : 4957 )  
using namespace System;  
int main() {  
   Object ^ o = "Hello, World!";  
   String ^ s = static_cast<String^>(o);   // C4957  
   String ^ s2 = safe_cast<String^>(o);   // OK  
}  
```