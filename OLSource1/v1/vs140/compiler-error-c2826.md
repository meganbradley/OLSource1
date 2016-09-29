---
title: "Compiler Error C2826"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C2826"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2826"
ms.assetid: 55862a2c-7b26-4e22-b514-1e02bb9530c0
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2826
'operator' must be declared static  
  
 Methods must be declared as static if they implement a managed operator.  
  
 C2826 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C2826:  
  
```  
// C2826.cpp  
// compile with: /clr:oldSyntax /c  
#using<mscorlib.dll>  
using namespace System;  
  
__value struct M {  
   M op_Addition(M m1, M m2) {   // C2826  
   // try the following line instead  
   // static M op_Addition(M m1, M m2) {  
      return m1;  
   }  
};  
```