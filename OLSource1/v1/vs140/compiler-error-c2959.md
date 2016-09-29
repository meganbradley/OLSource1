---
title: "Compiler Error C2959"
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
  - "C2959"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2959"
ms.assetid: d66bb2a8-70c3-4209-a358-b0c47f111a50
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2959
a generic class or function may not be a member of a template  
  
 For more information, see [Managed Templates](../vs140/windows-runtime-and-managed-templates--c---component-extensions-.md) and [Generics (C++)](../vs140/generics---c---component-extensions-.md).  
  
## Example  
 The following sample generates C2959.  
  
```  
// C2959.cpp  
// compile with: /clr /c  
template <class T> ref struct S {  
   generic <class U> ref struct GR1;   // C2959  
};  
```