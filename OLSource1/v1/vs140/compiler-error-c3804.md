---
title: "Compiler Error C3804"
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
  - "C3804"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3804"
ms.assetid: 7c4cda28-ec96-4d04-937b-36dbd9944722
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3804
'property_accessor': the accessor methods for a property must either be all static or all non-static  
  
 When defining a non-trivial property, the accessor functions can be either static or instance, but not both.  
  
 See [property](../vs140/property---c---component-extensions-.md) for more information.  
  
## Example  
 The following sample generates C3804.  
  
```  
// C3804.cpp  
// compile with: /c /clr  
ref struct A {  
  
   property int i {  
      static int get() {}  
      void set(int i) {}  
   }   // C3804 error  
  
   // OK  
   property int j {  
      int get() { return 0; }  
      void set(int i) {}  
   }  
  
   property int k {  
      static int get() { return 0; }  
      static void set(int i) {}  
   }  
};  
```