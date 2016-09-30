---
title: "IDebugStackFrame2::GetInfo"
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
  - "IDebugStackFrame2::GetInfo"
helpviewer_keywords: 
  - "IDebugStackFrame2::GetInfo"
ms.assetid: 19c6870b-b94e-453c-bf19-82ce95b79d26
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugStackFrame2::GetInfo
Gets a description of the stack frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [FRAMEINFO_FLAGS](../vs140/frameinfo_flags.md) enumeration that specifies which fields of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter are to be filled in.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The radix to be used in formatting any numerical information.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] A [FRAMEINFO](../vs140/frameinfo.md) structure that is filled in with the description of the stack frame.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDebugStackFrame2](../vs140/idebugstackframe2.md)   
 [FRAMEINFO_FLAGS](../vs140/frameinfo_flags.md)   
 [FRAMEINFO](../vs140/frameinfo.md)