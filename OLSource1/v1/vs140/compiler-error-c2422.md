---
title: "Compiler Error C2422"
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
  - "C2422"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2422"
ms.assetid: ef0ec302-4028-4778-b134-0b8cea4bcad9
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2422
illegal segment override in 'operand'  
  
 Inline assembly code incorrectly uses a segment override operator (colon) on an operand.  Possible causes include:  
  
-   The register preceding the operator is not a segment register.  
  
-   The register preceding the operator is not the only segment register in the operand.  
  
-   The segment override operator appears within an indirection operator (brackets).  
  
-   The expression following the segment override operator is not an immediate operand or a memory operand.  
  
 The following sample generates C2422:  
  
```  
// C2422.cpp  
// processor: x86  
int main() {  
   _asm {  
      mov AX, [BX:ES]   // C2422  
      mov AX, ES   // OK  
   }  
}  
```