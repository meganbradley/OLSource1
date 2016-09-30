---
title: "IDebugBreakpointRequest2::GetRequestInfo"
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
  - "IDebugBreakpointRequest2::GetRequestInfo"
helpviewer_keywords: 
  - "IDebugBreakpointRequest2::GetRequestInfo"
ms.assetid: 5defd8d7-6daa-479b-8909-fcc4ae0b357a
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointRequest2::GetRequestInfo
Gets the breakpoint request information that describes this breakpoint request.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A combination of flags from the [BPREQI_FIELDS](../vs140/bpreqi_fields.md) enumeration that determines which fields in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter are to be filled out.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Specifies the [BP_REQUEST_INFO](../vs140/bp_request_info.md) structure to be filled in with the description of the breakpoint request.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that exposes the [IDebugBreakpointRequest2](../vs140/idebugbreakpointrequest2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBreakpointRequest2](../vs140/idebugbreakpointrequest2.md)   
 [BPREQI_FIELDS](../vs140/bpreqi_fields.md)   
 [BP_REQUEST_INFO](../vs140/bp_request_info.md)