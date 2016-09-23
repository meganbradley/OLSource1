---
title: "Compiler Error C3278"
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
  - C3278
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3278
ms.assetid: 56f818f5-85a6-4792-843b-54fe16327658
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3278
direct call of interface or pure method 'method' will fail at runtime  
  
 A call was made to an interface method or a pure method, which is not allowed.  
  
 The following sample generates C3278:  
  
```  
// C3278_2.cpp  
// compile with: /clr  
using namespace System;  
interface class I  
{  
   void vmf();  
};  
  
public ref class C: public I  
{  
public:  
   void vmf()  
   {  
      Console::WriteLine( "In C::vmf()" );  
      I::vmf(); // C3278  
   }  
  
};  
  
int main()  
{  
   C^ pC = gcnew C;  
   pC->vmf();  
}  
```