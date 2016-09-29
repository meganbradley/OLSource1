---
title: "Compiler Error C2824"
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
  - "C2824"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2824"
ms.assetid: 5bd865f7-e0af-404e-80fe-e2b798b44a59
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2824
return type for 'operator new' must be 'void *'  
  
 With non-based pointers, overloads of operator `new` must return `void *`.  
  
 The following sample generates C2824:  
  
```  
// C2824.cpp  
// compile with: /c  
class   A {  
   A* operator new(size_t i, char *m);   // C2824  
   // try the following line instead  
   // void* operator new(size_t i, char *m);  
};  
```