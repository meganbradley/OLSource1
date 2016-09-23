---
title: "Compiler Error C3797"
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
  - C3797
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3797
ms.assetid: ab27ff34-8c1d-4297-b004-9e39bd3a4f25
caps.latest.revision: 8
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3797
'override': event declaration cannot have override specifier (should be placed on event add/remove/raise methods instead)  
  
 You cannot override a trivial event (an event without explicitly defined accessor methods) with another trivial event. The overriding event must define its behavior with accessor functions.  
  
 For more information, see [event](../vs140/event---c---component-extensions-.md).  
  
## Example  
 The following sample generates C3797.  
  
```  
// C3797.cpp  
// compile with: /clr /c  
delegate void MyDel();  
  
ref class Class1 {  
public:  
   virtual event MyDel ^ E;  
};  
  
ref class Class2 : public Class1 {  
public:  
   virtual event MyDel ^ E override;   // C3797  
};  
  
// OK  
ref class Class3 : public Class1 {  
public:  
   virtual event MyDel ^ E {  
      void add(MyDel ^ d) override {}  
      void remove(MyDel ^ d) override {}  
   }  
};  
```