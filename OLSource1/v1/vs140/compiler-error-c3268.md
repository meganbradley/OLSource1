---
title: "Compiler Error C3268"
ms.custom: na
ms.date: 09/23/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - C3268
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3268
ms.assetid: d74a630c-daea-4e29-9759-83efef7fb184
caps.latest.revision: 9
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3268
'function' : a generic function or a member-function of a generic class cannot have a variable parameter list  
  
 See [Generics (C++)](../vs140/generics---c---component-extensions-.md) for more information.  
  
## Example  
 The following sample generates C3268.  
  
```  
// C3268.cpp  
// compile with: /clr:pure /c  
generic <class ItemType>  
void Test(ItemType item, ...) {}   // C3268  
// try the following line instead  
// void Test(ItemType item) {}  
  
generic <class ItemType2>  
ref struct MyStruct { void Test(...){} };   // C3268  
// try the following line instead  
// ref struct MyStruct { void Test2(){} };   // OK  
```