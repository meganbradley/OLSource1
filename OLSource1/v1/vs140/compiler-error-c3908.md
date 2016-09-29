---
title: "Compiler Error C3908"
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
  - "C3908"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3908"
ms.assetid: 3c322482-c79e-4197-a578-2ad9bc379d1a
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3908
access level less restrictive than 'construct'  
  
 A property accessor method (get or set) cannot have less restrictive access than the access specified on the property itself.  Similarly, for event accessor methods.  
  
 For more information, see [property](../vs140/property---c---component-extensions-.md) and [event](../vs140/event---c---component-extensions-.md).  
  
 The following sample generates C3908:  
  
```  
// C3908.cpp  
// compile with: /clr  
ref class X {  
protected:  
   property int i {  
   public:   // C3908 property i is protected   
      int get();  
   private:  
      void set(int);   // OK more restrictive  
   };  
};  
```