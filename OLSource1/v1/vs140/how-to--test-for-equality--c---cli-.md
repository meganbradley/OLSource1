---
title: "How to: Test for Equality (C++-CLI)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
H1: How to: Test for Equality (C++/CLI)
dev_langs: 
  - C++
helpviewer_keywords: 
  - equality, testing for
ms.assetid: 9115e298-9f75-452d-bdfb-6eeb0fa0b3c6
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# How to: Test for Equality (C++-CLI)
In the following sample, a test for equality that uses Managed Extensions for C++ is based on what the handles refer to.  
  
## Example  
  
```  
// mcppv2_equality_test.cpp  
// compile with: /clr /LD  
using namespace System;  
  
bool Test1() {  
   String ^ str1 = "test";  
   String ^ str2 = "test";  
   return (str1 == str2);  
}  
```  
  
 The IL for this program shows that the return value is implemented by using a call to op_Equality.  
  
```  
IL_0012:  call       bool [mscorlib]System.String::op_Equality(string,  
                                                               string)  
```  
  
## See Also  
 [Managed Types](../vs140/managed-types--c---cli-.md)