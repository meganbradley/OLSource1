---
title: "Compiler Error C2787"
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
  - "C2787"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2787"
ms.assetid: 34cb57e6-cafe-4ce7-bcc6-53d194629bd0
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2787
'identifier' : no GUID has been associated with this object  
  
 The [__uuidof](../vs140/__uuidof-operator.md) operator takes a user-defined type with a GUID attached or an object of such a user-defined type. This error occurs when the argument is a user-defined type with no GUID.  
  
 The following sample generates C2787:  
  
```  
// C2787.cpp  
#include <windows.h>  
struct F {};  
  
struct __declspec(uuid("00000000-0000-0000-c000-000000000046")) F2;  
  
int main() {  
   __uuidof(F);   // C2787  
   __uuidof(F2);   // OK  
}  
```