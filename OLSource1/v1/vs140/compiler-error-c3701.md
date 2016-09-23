---
title: "Compiler Error C3701"
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
  - C3701
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3701
ms.assetid: a7faaa87-d2f5-4d6a-9a2f-5cab2d24a648
caps.latest.revision: 11
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3701
'function' : event_source has no events  
  
 You attempted to use [event_source](../vs140/event_source.md) on a class that has no event methods. To fix this error, add one or more events to the class.  
  
 The following sample generates C3701:  
  
```  
// C3701.cpp  
[ event_source(native) ]  
class CEventSrc {  
public:  
   // uncomment the following line to resolve this C3701  
   // __event void fireEvent(int i);  
};   // C3701  
  
int main() {  
}  
```