---
title: "Compiler Error C3826"
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
  - "C3826"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3826"
ms.assetid: 243a32f1-c999-46d9-95a1-45cd6e993dfe
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3826
'type': declaring pinned formal parameters is illegal  
  
 A function parameter cannot be decorated with the [__pin](../vs140/__pin.md) keyword.  
  
 C3826 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3826:  
  
```  
// C3826.cpp  
// compile with: /clr:oldSyntax /c  
__gc class G {};  
  
typedef G __pin * GPinPtrType;  
typedef G * GPinPtrType2;  
  
void func1(G __pin * x) {}   // C3826  
void func1b(G * x) {}   // OK  
  
void func2(GPinPtrType x) {}   // C3826  
void func2(GPinPtrType2 x) {}   // OK  
```