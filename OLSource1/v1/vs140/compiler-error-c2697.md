---
title: "Compiler Error C2697"
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
  - C2697
dev_langs: 
  - C++
helpviewer_keywords: 
  - C2697
ms.assetid: 0f55b263-4fe0-410c-8e6a-a0943bc61ff4
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C2697
'array' : must explicitly specify __gc or \__nogc for an array declared in a managed type  
  
 This error indicates that an array was not explicitly marked as unmanaged or managed in a [__gc](../vs140/__gc.md) class.  
  
 C2697 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C2697:  
  
```  
// C2697.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
__gc class a {  
public:  
   int gc_arr[12];  // C2697  
   // try the following line instead  
   // int gc_arr __gc [];  
  
   // example of a static array  
   static int * static_gcarr = gc new int [10];  
  
   // example of a __nogc array  
   int nogc_arr __nogc [2];  
};  
  
int main() {  
   a *mya = new a;  
   mya -> gc_arr = new int __gc [2];  
  
   mya -> gc_arr[0] = 33;  
   System::Console::WriteLine(mya -> gc_arr[0]);  
  
   mya -> static_gcarr[0] = 44;  
   System::Console::WriteLine(mya -> static_gcarr[0]);  
  
   mya -> gc_arr[0] = 55;  
   System::Console::WriteLine(mya -> gc_arr[0]);  
}  
```