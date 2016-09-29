---
title: "Compiler Warning (level 3) C4316"
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
  - "C4316"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4316"
ms.assetid: 10371f01-aeb8-40ac-a290-59e63efa5ad4
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 3) C4316
Object allocated on the heap may not be aligned for this type.  
  
 An over-aligned object allocated by using `operator new` may not have the specified alignment. Override [operator new](../vs140/operator-new--crt-.md) and [operator delete](../vs140/operator-delete--crt-.md) for over-aligned types so that they use the aligned allocation routines—for example, [_aligned_malloc](../vs140/_aligned_malloc.md) and [_aligned_free](../vs140/_aligned_free.md). The following sample generates C4316:  
  
```cpp  
// C4316.cpp  
// Test: cl /W3 /c C4316.cpp  
  
__declspec(align(32)) struct S {}; // C4324  
  
int main() {  
    new S; // C4316  
}  
```