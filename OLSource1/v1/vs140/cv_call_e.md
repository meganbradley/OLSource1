---
title: "CV_call_e"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CV_call_e enumeration"
ms.assetid: f230560b-4243-432d-8f19-46df112043b9
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CV_call_e
Specifies the calling convention for a function.  
  
> [!NOTE]
>  Only the most common enumeration values are documented here. The complete enumeration is available in the cvconst.h header file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements  
 CV_CALL_NEAR_C  
 Specifies a function-calling convention using a near right-to-left push. The calling function clears the stack.  
  
 CV_CALL_NEAR_FAST  
 Specifies a function-calling convention using a near left-to-right push with registers. The called function uses the sum of parameter bytes to clear the stack.  
  
 CV_CALL_NEAR_STD  
 Specifies a function-calling convention using a near standard call (right-to-left push).  
  
 CV_CALL_NEAR_SYS  
 Specifies a function-calling convention using a near system call.  
  
 CV_CALL_THISCALL  
 Specifies a function-calling convention using <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> call (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointer passed in register).  
  
 CV_CALL_CLRCALL  
 Specifies a function-calling convention used by the Common Language Runtime (CLR) (also known as a managed code calling convention).  
  
## Remarks  
 The values in this enumeration are returned by a call to the [IDiaSymbol::get_callingConvention](../vs140/idiasymbol--get_callingconvention.md) method.  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../vs140/enumerations-and-structures.md)   
 [IDiaSymbol::get_callingConvention](../vs140/idiasymbol--get_callingconvention.md)