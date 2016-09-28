---
title: "Compiler Error C2657"
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
  - "C2657"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2657"
ms.assetid: f7cf29a9-684a-4605-9469-ecfee9ba4b03
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2657
'class::*' found at the start of a statement (did you forget to specify a type?)  
  
 The line began with a pointer-to-member identifier.  
  
 This error can be caused by a missing type specifier in the declaration of a pointer to a member.  
  
 The following sample generates C2657:  
  
```  
// C2657.cpp  
class C {};  
int main() {  
   C::* pmc1;        // C2657  
   int C::* pmc2;   // OK  
}  
```