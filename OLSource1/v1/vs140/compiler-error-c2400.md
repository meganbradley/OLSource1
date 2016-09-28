---
title: "Compiler Error C2400"
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
  - "C2400"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2400"
ms.assetid: 1ba441ee-73f9-42a5-bfe9-fbeab93808eb
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2400
inline assembler syntax error in 'context'; found 'token'  
  
 The token caused a syntax error in the specified context.  
  
 The following sample generates C2400:  
  
```  
// C2400.cpp  
// processor: x86  
int main() {  
   __asm {  
      heh ax,bx;   // C2400, heh is not a valid x86 instruction  
      mov ax,bx;   // OK  
   }  
}  
```