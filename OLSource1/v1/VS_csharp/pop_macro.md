---
title: "pop_macro"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc-pragma.pop_macro"
  - "pop_macro_CPP"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "pop_macro pragma"
  - "pragmas, pop_macro"
ms.assetid: 3b5489d0-69ba-4c66-b572-2748af0f12bb
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# pop_macro
Sets the value of the *macro_name* macro to the value on the top of the stack for this macro.  
  
## Syntax  
  
```  
  
#pragma pop_macro("  
macro_name  
")  
  
```  
  
## Remarks  
 You must first issue a [push_macro](../VS_csharp/push_macro.md) for *macro_name* before you can do a **pop_macro**.  
  
## Example  
  
```  
// pragma_directives_pop_macro.cpp  
// compile with: /W1  
#include <stdio.h>  
#define X 1  
#define Y 2  
  
int main() {  
   printf("%d",X);  
   printf("\n%d",Y);  
   #define Y 3   // C4005  
   #pragma push_macro("Y")  
   #pragma push_macro("X")  
   printf("\n%d",X);  
   #define X 2   // C4005  
   printf("\n%d",X);  
   #pragma pop_macro("X")  
   printf("\n%d",X);  
   #pragma pop_macro("Y")  
   printf("\n%d",Y);  
}  
```  
  
 **1**  
**2**  
**1**  
**2**  
**1**  
**3**   
## See Also  
 [Pragma Directives and the __Pragma Keyword](../VS_csharp/pragma-directives-and-the-__pragma-keyword.md)