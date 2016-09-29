---
title: "Compiler Error C3823"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "error-reference"
f1_keywords: 
  - "C3823"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3823"
ms.assetid: 3df1dc87-fd30-41e5-9c29-aaf8f8f01898
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3823
'modifier' : storage class modifier can only be applied to a pointer  
  
 `modifier` can only be applied to pointers.  
  
 C3823 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3823:  
  
```  
// C3823.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
  
__pin struct A {   // C3823, cannot use __pin on a struct  
};  
  
struct B {  
};  
  
int main() {  
   __pin B *a1;   // C3823  
   // try ..  
   // B __pin* a2;  
}  
```