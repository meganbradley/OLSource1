---
title: "Compiler Error C2541"
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
  - "C2541"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2541"
ms.assetid: ed95180f-00df-4e62-a8e9-1b6dab8281bf
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2541
'delete' : delete : cannot delete objects that are not pointers  
  
 The [delete](../vs140/delete-operator--c---.md) operator was used on an object that is not a pointer.  
  
 The following sample generates C2541:  
  
```  
// C2541.cpp  
int main() {  
   int i;  
   delete i;   // C2541 i not a pointer  
  
   // OK  
   int *ip = new int;  
   delete ip;  
}  
```