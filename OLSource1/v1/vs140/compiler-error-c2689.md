---
title: "Compiler Error C2689"
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
  - "C2689"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2689"
ms.assetid: b5216fba-524d-4194-9168-26e9dc5210ce
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2689
'function' : a friend function cannot be defined within a local class  
  
 You can declare but not define a friend function in a local class.  
  
 The following sample generates C2689:  
  
```  
// C2689.cpp  
// compile with: /c  
void g() {  
   void f2();  
   class X {  
      friend void f2(){}   // C2689  
      friend void f2();   // OK  
   };  
}  
```