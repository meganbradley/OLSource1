---
title: "Compiler Warning (level 4) C4366"
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
  - "C4366"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C4366"
ms.assetid: 65d2942f-3741-42f4-adf2-4920d5a055ca
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Warning (level 4) C4366
The result of the unary 'operator' operator may be unaligned  
  
 If a structure member could ever be unaligned because of packing, the compiler will warn when that member's address is assigned to an aligned pointer. By default, all pointers are aligned.  
  
 To resolve C4366, either change the alignment of the structure or declare the pointer with the [__unaligned](../vs140/__unaligned.md) keyword.  
  
 For more information, see __unaligned and [pack](../vs140/pack.md).  
  
## Example  
 The following sample generates C4366.  
  
```  
// C4366.cpp  
// compile with: /W4 /c  
// processor: IPF x64  
#pragma pack(1)  
struct X {  
   short s1;  
   int s2;  
};  
  
int main() {  
   X x;  
   short * ps1 = &x.s1;   // OK  
   int * ps2 = &x.s2;   // C4366  
}  
```