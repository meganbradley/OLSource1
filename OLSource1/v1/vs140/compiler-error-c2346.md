---
title: "Compiler Error C2346"
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
  - "C2346"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "C2346"
ms.assetid: 246145be-5645-4cd6-867c-e3bc39e33dca
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiler Error C2346
'function' cannot be compiled as native: reason  
  
 The compiler was unable to compile a function to MSIL.  
  
 For more information, see [managed, unmanaged](../vs140/managed--unmanaged.md) and [/clr (Common Language Runtime Compilation)](../vs140/-clr--common-language-runtime-compilation-.md).  
  
### To correct this error  
  
1.  Remove the code in the function that cannot be compiled to MSIL.  
  
2.  Either do not compile the module with **/clr**, or mark the function as unmanaged with the unmanaged pragma.  
  
## Example  
 The following sample generates C2346.  
  
```  
// C2346.cpp  
// processor: x86  
// compile with: /clr   
// C2346 expected  
struct S  
{  
   S()  
   {  
      { __asm { nop } }  
   }  
   virtual __clrcall ~S() { }  
};  
  
void main()  
{  
   S s;  
}  
```