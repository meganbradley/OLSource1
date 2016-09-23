---
title: "Compiler Error C3616"
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
  - C3616
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3616
ms.assetid: 85dcc5e3-5648-4f54-9c09-8e26c8fc61d0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3616
'number' : a size cannot be specified in a __gc array declaration  
  
 A [__gc](../vs140/__gc.md) array was incorrectly declared. Subscript values are allowed on the right side of the expression but not on the left.  
  
 C3616 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3616 and shows one way to resolve the error:  
  
```  
// C3616.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
int main()  
{  
   int a  __gc[2] = new int __gc [];   // C3616  
   int b __gc [] = new int __gc [12];   // ok  
}  
```