---
title: "Compiler Error C2788"
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
  - "C2788"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2788"
ms.assetid: 8688fc5c-e652-43b4-b407-9c488c76f2db
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2788
'identifier' : more than one GUID associated with this object  
  
 The [__uuidof](../vs140/__uuidof-operator.md) operator takes a user-defined type with a GUID attached or an object of such a user-defined type. This error occurs when the argument is an object with multiple GUIDs.  
  
 The following sample generates C2788:  
  
```  
// C2788.cpp  
#include <windows.h>  
struct __declspec(uuid("00000001-0000-0000-0000-000000000000")) A {};  
struct __declspec(uuid("{00000002-0000-0000-0000-000000000000}")) B {};  
template <class T, class U> class MyClass {};  
  
typedef MyClass<A,B> MyBadClass;  
typedef MyClass<A,A> MyGoodClass;  
  
int main() {  
   __uuidof(MyBadClass);    // C2788  
   // try the following line instead  
   __uuidof(MyGoodClass);  
}  
```