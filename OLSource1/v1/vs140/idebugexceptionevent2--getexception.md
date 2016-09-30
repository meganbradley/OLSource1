---
title: "IDebugExceptionEvent2::GetException"
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
  - "IDebugExceptionEvent2::GetException"
helpviewer_keywords: 
  - "IDebugExceptionEvent2::GetException"
ms.assetid: 7c98f41d-322b-4e72-a514-cbd4823eb70d
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugExceptionEvent2::GetException
Gets a detailed description of the exception that fired this event.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in, out] An [EXCEPTION_INFO](../vs140/exception_info.md) structure that is filled in with the description of the exception.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 [C++ only] The caller is responsible for freeing any strings in the [EXCEPTION_INFO](../vs140/exception_info.md) structure as well as releasing the [IDebugProgram2](../vs140/idebugprogram2.md) object in the structure.  
  
## See Also  
 [IDebugExceptionEvent2](../vs140/idebugexceptionevent2.md)   
 [EXCEPTION_INFO](../vs140/exception_info.md)   
 [IDebugEvent2](../vs140/idebugevent2.md)   
 [IDebugProgram2](../vs140/idebugprogram2.md)