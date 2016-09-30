---
title: "BP_LOCATION_CODE_FUNC_OFFSET"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "BP_LOCATION_CODE_FUNC_OFFSET"
helpviewer_keywords: 
  - "BP_LOCATION_CODE_FUNC_OFFSET structure"
ms.assetid: ab38f7ca-fa01-4cf3-a06c-56cbb7207617
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# BP_LOCATION_CODE_FUNC_OFFSET
Describes the offset location of a breakpoint in a function in code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The context of the breakpoint, typically a method or function name as seen on a call stack.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The [IDebugFunctionPosition2](../vs140/idebugfunctionposition2.md) object that describes the name of the function and the relative position from the beginning of the function.  
  
## Remarks  
 This structure is a member of the [BP_LOCATION](../vs140/bp_location.md) structure as part of a union.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> member indicates where to set the function breakpoint.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [BP_LOCATION](../vs140/bp_location.md)   
 [IDebugFunctionPosition2](../vs140/idebugfunctionposition2.md)