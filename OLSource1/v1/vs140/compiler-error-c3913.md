---
title: "Compiler Error C3913"
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
  - "C3913"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C3913"
ms.assetid: a678bfce-9524-470d-9f23-7d08ecb972c8
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C3913
default property must be indexed  
  
 A default property was defined incorrectly.  
  
 For more information, see [property](../vs140/property---c---component-extensions-.md).  
  
 The following sample generates C3913:  
  
```  
// C3913.cpp  
// compile with: /clr /c  
ref struct X {  
   property int default {   // C3913  
   // try the following line instead  
   // property int default[int] {  
      int get(int) { return 0; }  
      void set(int, int) {}  
   }  
};  
```