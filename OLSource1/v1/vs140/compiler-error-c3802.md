---
title: "Compiler Error C3802"
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
  - C3802
dev_langs: 
  - C++
helpviewer_keywords: 
  - C3802
ms.assetid: 42504e06-87be-4763-9b5c-2af8f7360ed4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Compiler Error C3802
'name': invalid name for a property  
  
 A [__property](../vs140/__property.md) was declared with an invalid name.  
  
 C3802 is only reachable using **/clr:oldSyntax**.  
  
 The following sample generates C3802  
  
```  
// C3802.cpp  
// compile with: /clr:oldSyntax  
#using <mscorlib.dll>  
using namespace System;  
  
__gc class Test {  
public:  
   __property int get_() {       // C3802, empty name for a property  
      return 0;  
   }  
  
   __property int get_Test() {   // C3802, 'Test' -- parent class name  
      return 0;  
   }  
  
   __property int get_val() {  // OK  
      return _mValue;  
   }  
  
private:  
   int _mValue;  
};  
  
int main() {  
}  
```