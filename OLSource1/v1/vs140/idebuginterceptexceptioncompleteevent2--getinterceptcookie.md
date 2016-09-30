---
title: "IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie"
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
  - "IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie"
helpviewer_keywords: 
  - "IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie"
ms.assetid: 07b20866-e598-4783-9ecc-6aa8625c8804
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugInterceptExceptionCompleteEvent2::GetInterceptCookie
Called when the processing of an intercepted exception has completed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Unique value that is associated with the exception that was intercepted.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise returns error code.  
  
## Remarks  
 After the [IDebugStackFrame3::InterceptCurrentException](../vs140/idebugstackframe3--interceptcurrentexception.md) method has completed handling of an intercepted exception, it sends the [IDebugInterceptExceptionCompleteEvent2](../vs140/idebuginterceptexceptioncompleteevent2.md) event. The handler can use the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method to retrieve the unique value associated with the exception (the same value passed to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method).  
  
## See Also  
 [IDebugStackFrame3::InterceptCurrentException](../vs140/idebugstackframe3--interceptcurrentexception.md)   
 [IDebugInterceptExceptionCompleteEvent2](../vs140/idebuginterceptexceptioncompleteevent2.md)