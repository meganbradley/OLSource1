---
title: "Compiler Error C2521"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: error-reference
f1_keywords: 
  - C2521
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2521
ms.assetid: 6042821b-e345-4a54-a7e9-a2c9019ea016
caps.latest.revision: 14
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2521
function does not take any arguments  
  
 You attempted to use arguments with a destructor or finalizer.  
  
 For more information, see [Destructors and Finalizers](../vs140/how-to--define-and-consume-classes-and-structs--c---cli-.md#BKMK_Destructors_and_finalizers).  
  
## Example  
 The following sample generates C2521.  
  
```  
// C2521.cpp  
// compile with: /clr  
ref class R {  
protected:  
   !R() {}  
  
public:  
   void CleanUp() {  
      this->!R(4);   // C2521  
      this->!R();   // OK  
   }  
};  
  
int main() {  
   R^ r = gcnew R();  
   r->CleanUp();  
}  
```