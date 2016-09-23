---
title: "Compiler Error C3912"
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
  - C3912
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3912
ms.assetid: 674e050c-11fb-4db1-8bdf-a3e95b41161d
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3912
'event': type of event must be a delegate type  
  
 An event was declared but was not of the proper type.  
  
 For more information, see [event](../vs140/event---c---component-extensions-.md).  
  
 The following sample generates C3912:  
  
```  
// C3912.cpp  
// compile with: /clr  
delegate void H();  
ref class X {  
   event int Ev;   // C3912  
   event H^ Ev2;   // OK  
};  
```