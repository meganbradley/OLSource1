---
title: "ATL_NO_VTABLE"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::ATL_NO_VTABLE"
  - "ATL.ATL_NO_VTABLE"
  - "ATL_NO_VTABLE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL_NO_VTABLE macro"
ms.assetid: 8b85286c-9ea0-49ca-9b00-5175ac0ea0a9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL_NO_VTABLE
A symbol that prevents the vtable pointer from being initialized in the class's constructor and destructor.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the vtable pointer is prevented from being initialized in the class's constructor and destructor, the linker can eliminate the vtable and all of the functions to which it points. Expands to **__declspec(novtable)**.  
  
## Example  
 [!code[NVC_ATL_COM#53](../vs140/codesnippet/CPP/atl_no_vtable_1.h)]  
  
## Requirements  
 **Header:** atldef.h  
  
## See Also  
 [Compiler Options Macros](../vs140/compiler-options-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [Specifying Compiler Optimization for an ATL Project](../vs140/specifying-compiler-optimization-for-an-atl-project.md)