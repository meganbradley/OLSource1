---
title: "Compiler Error C3150"
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
  - C3150
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3150
ms.assetid: c1ff28f5-52fe-4fd4-81d0-2e0ad8548631
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3150
'element' : 'attribute' can only be applied to a class, interface, array or pointer  
  
 [__gc](../vs140/__gc.md) can only be used on a class, interface, or array.  
  
 C3150 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3150:  
  
```  
// C3150.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
  
__gc void f()   // C3150; function cannot be managed  
{  
}  
```