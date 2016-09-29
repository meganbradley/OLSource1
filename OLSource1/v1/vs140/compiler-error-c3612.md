---
title: "Compiler Error C3612"
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
  - "C3612"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3612"
ms.assetid: aa6e3a2b-4afa-481c-98c1-1b6d1f82f869
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3612
'type': a sealed class cannot be abstract  
  
 Types defined with `value` (or [__value](../vs140/__value.md)) are sealed by default and a class is abstract unless it implements all methods of its base. A sealed abstract class can neither be a base class nor can it be instantiated.  
  
 For more information, see [Classes and Structs (Managed)](../vs140/classes-and-structs---c---component-extensions-.md).  
  
 The following sample generates C3612:  
  
```  
// C3612.cpp  
// compile with: /clr /c  
value struct V: public System::ICloneable {};   // C3612  
  
// OK  
value struct V2: public System::ICloneable {  
   Object^ Clone();  
};  
```