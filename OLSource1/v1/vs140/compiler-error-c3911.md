---
title: "Compiler Error C3911"
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
  - C3911
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3911
ms.assetid: b786da59-0e99-479d-bc0d-551126e940f2
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3911
'event_accessor_method': function must have type 'signature'  
  
 An event's accessor method was not properly declared.  
  
 For more information, see [event](../vs140/event---c---component-extensions-.md).  
  
 The following sample generates C3911:  
  
```  
// C3911.cpp  
// compile with: /clr  
using namespace System;  
delegate void H(String^, int);  
  
ref class X {  
   event H^ E1 {  
      void add() {}   // C3911  
      // try the following line instead  
      // void add(H ^ h) {}  
  
      void remove(){}  
      // try the following line instead  
      // void remove(H ^ h) {}  
  
      void raise(){}  
      // try the following line instead  
      // void raise(String ^ s, int i) {}  
   };  
};  
```