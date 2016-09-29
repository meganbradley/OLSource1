---
title: "Compiler Error C2892"
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
  - "C2892"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2892"
ms.assetid: c22a5084-2f50-42c2-a56b-6dfe5442edc9
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2892
local class shall not have member templates  
  
 Templated member functions are not valid in a class that is defined in a function.  
  
 The following sample generates C2892:  
  
```  
// C2892.cpp  
int main() {  
   struct local {  
      template<class T>   // C2892  
      void f() {}  
   };  
}  
```