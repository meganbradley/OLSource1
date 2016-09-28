---
title: "auto_handle::~auto_handle"
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
  - "auto_handle.~auto_handle"
  - "msclr.auto_handle.~auto_handle"
  - "auto_handle::~auto_handle"
  - "~auto_handle"
  - "msclr::auto_handle::~auto_handle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "auto_handle::~auto_handle"
ms.assetid: e83e95a8-015b-4f27-ad63-70efb3690726
caps.latest.revision: 11
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# auto_handle::~auto_handle
The `auto_handle` destructor.  
  
## Syntax  
  
```  
~auto_handle();  
```  
  
## Remarks  
 The destructor also destructs the owned object.  
  
## Example  
  
```  
// msl_auto_handle_dtor.cpp  
// compile with: /clr  
#include "msclr\auto_handle.h"  
  
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
      auto_handle<ClassA> a = gcnew ClassA;  
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
 **Header file** <msclr\auto_handle.h>  
  
 **Namespace** msclr  
  
## See Also  
 [auto_handle Members](../vs140/auto_handle-members.md)   
 [auto_handle::release](../vs140/auto_handle--release.md)   
 [auto_handle::auto_handle](../vs140/auto_handle--auto_handle.md)