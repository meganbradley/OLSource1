---
title: "Compiler Error C2070"
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
  - "C2070"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2070"
ms.assetid: 4c8dea63-1227-4aba-be26-2462537f86fb
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2070
'type': illegal sizeof operand  
  
 The [sizeof](../vs140/sizeof-operator.md) operator requires an expression or type name.  
  
 The following sample generates C2070:  
  
```  
// C2070.cpp  
void func() {}  
int main() {  
   int a;  
   a = sizeof(func);   // C2070  
}  
```  
  
 Possible resolution:  
  
```  
// C2070b.cpp  
void func() {}  
int main() {  
   int a;  
   a = sizeof(a);  
}  
```