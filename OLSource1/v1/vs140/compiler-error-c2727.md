---
title: "Compiler Error C2727"
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
  - "C2727"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2727"
ms.assetid: 68127a8e-c090-440e-9e87-c36f65651a35
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2727
'type' : a native array cannot contain a value type with private data members or managed pointer members  
  
 **Managed Extensions for C++**  
  
 A [__nogc](../vs140/__nogc.md) array cannot be of a type that contains [__gc](../vs140/__gc.md) types.  
  
 C2727 is only reachable using **/clr:oldSyntax**  
  
 The following sample generates C2727  
  
```  
// C2727b.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
using namespace System;  
__value struct V {  
   String * s;  
};  
  
__value struct V2 {  
   char s;  
};  
  
int main() {  
   V v __nogc[5];   // C2727  
   V2 v2 __nogc[5];   // OK  
}  
```