---
title: "Compiler Error C3919"
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
  - "C3919"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3919"
ms.assetid: 5f8eddda-d751-478b-930d-e18f7191ddfb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3919
'event_method': function must have type 'type'  
  
 An event accessor method was not declared correctly.  
  
 For more information about events, see [event](../vs140/event---c---component-extensions-.md).  
  
 The following sample generates C3919:  
  
```  
// C3919.cpp  
// compile with: /clr /c  
using namespace System;  
delegate void D(String^);  
ref class R {  
   event D^ e {  
      int add(int);   // C3919  
      int remove(int);   // C3919  
  
      void add(D^);   // OK  
      void remove(D^);   // OK  
   }  
};  
```