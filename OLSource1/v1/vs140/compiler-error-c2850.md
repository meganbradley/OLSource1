---
title: "Compiler Error C2850"
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
  - "C2850"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2850"
ms.assetid: f3efe86c-4168-4e76-a133-3f8314c69f51
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2850
'construct' : only allowed at file scope; may not be in a nested construct  
  
 Constructs, such as some pragmas, can only appear at global scope.  
  
 The following sample generates C2850:  
  
```  
// C2850.cpp  
// compile with: /c /Yc  
// try the following line instead  
// #pragma hdrstop  
namespace X {  
   #pragma hdrstop   // C2850  
};  
```