---
title: "Compiler Error C2752"
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
  - C2752
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2752
ms.assetid: ae42b3ec-84a9-4e9d-8d59-3d208132d0b2
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2752
'template' : more than one partial specialization matches the template argument list  
  
 An instantiation was ambiguous.  
  
 The following sample generates C2752:  
  
```  
// C2752.cpp  
template<class T, class U>   
struct A {};  
  
template<class T, class U>   
struct A<T*, U> {};  
  
template<class T, class U>   
struct A<T,U*> {};  
  
// try the following line instead  
// template<class T, class U> struct A<T*,U*> {};  
  
int main() {  
   A<char*,int*> a;   // C2752 an instantiation  
  
   // OK  
   A<char*,int> a1;  
   A<char,int*> a2;  
   A<char,int> a3;  
}  
```