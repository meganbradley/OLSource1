---
title: "auto_gcroot::~auto_gcroot"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "auto_gcroot::~auto_gcroot"
  - "~auto_gcroot"
  - "auto_gcroot.~auto_gcroot"
  - "msclr::auto_gcroot::~auto_gcroot"
  - "msclr.auto_gcroot.~auto_gcroot"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_gcroot::~auto_gcroot"
ms.assetid: 3c970d43-0cb1-4b27-8bee-0394d91b4739
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_gcroot::~auto_gcroot
The `auto_gcroot` destructor.  
  
## Syntax  
  
```  
~auto_gcroot();  
```  
  
## Remarks  
 The destructor also destructs the owned object.  
  
## Example  
  
```  
// msl_auto_gcroot_dtor.cpp  
// compile with: /clr  
#include <msclr\auto_gcroot.h>  
  
using namespace System;  
using namespace msclr;  
  
ref class ClassA {  
public:  
   ClassA() { Console::WriteLine( "ClassA constructor" ); }  
   ~ClassA() { Console::WriteLine( "ClassA destructor" ); }  
};  
  
int main()  
{  
   // create a new scope for a:  
   {  
      auto_gcroot<ClassA^> a = gcnew ClassA;  
   }  
   // a goes out of scope here, invoking its destructor  
   // which in turns destructs the ClassA object.  
  
   Console::WriteLine( "done" );  
}  
```  
  
 **ClassA constructor**  
**ClassA destructor**  
**done**   
## Requirements  
 **Header file** <msclr\auto_gcroot.h>  
  
 **Namespace** msclr  
  
## See Also  
 [auto_gcroot Members](../vs140/auto_gcroot-members.md)   
 [auto_gcroot::release](../vs140/auto_gcroot--release.md)   
 [auto_gcroot::auto_gcroot](../vs140/auto_gcroot--auto_gcroot.md)