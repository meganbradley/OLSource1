---
title: "Compiler Error C2650"
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
  - "C2650"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2650"
ms.assetid: 49a8ac6e-aa6d-4616-917c-a3cfcdbad5a4
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2650
'operator' : cannot be a virtual function  
  
 A `new` or `delete` operator is declared `virtual`. These operators are `static` member functions and cannot be `virtual`.  
  
## Example  
 The following sample generates C2650:  
  
```  
// C2650.cpp  
// compile with: /c  
class A {  
   virtual void* operator new( unsigned int );   // C2650  
   // try the following line instead  
   // void* operator new( unsigned int );  
};  
```