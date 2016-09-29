---
title: "Compiler Error C2912"
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
  - "C2912"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2912"
ms.assetid: bd55cecd-ab1a-4636-ab8a-a00393fe7b3d
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2912
explicit specialization 'declaration' is not a specialization of a function template  
  
 You cannot specialize a non-template function.  
  
 The following sample generates C2912:  
  
```  
// C2912.cpp  
// compile with: /c  
void f(char);  
template<> void f(char);   // C2912  
template<class T> void f(T);   // OK  
```  
  
 This error will also be generated as a result of compiler conformance work that was done in Visual Studio .NET 2003: for every explicit specialization, you must choose the parameters of the explicit specialization, such that, they match the parameters of the primary template.  
  
```  
// C2912b.cpp  
class CF {  
public:  
   template <class A> CF(const A& a) {}   // primary template  
  
   // attempted explicit specialization  
   template <> CF(const char* p) {}   // C2912  
  
   // try the following line instead  
   // template <> CF(const char& p) {}  
};  
```