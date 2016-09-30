---
title: "IDebugBreakpointRequest2::GetLocationType"
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
  - "IDebugBreakpointRequest2::GetLocationType"
helpviewer_keywords: 
  - "IDebugBreakpointRequest2::GetLocationType"
ms.assetid: b6d14c59-d3aa-48ff-8278-f6b5bba9c2f3
caps.latest.revision: 16
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugBreakpointRequest2::GetLocationType
Gets the breakpoint location type of this breakpoint request.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] Returns a value from the [BP_LOCATION_TYPE](../vs140/bp_location_type.md) enumeration that describes the location of this breakpoint request.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, returns an error code. Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> field in the associated [BP_REQUEST_INFO](../vs140/bp_request_info.md) structure is not valid.  
  
## Example  
 The following example shows how to implement this method for a simple <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that exposes the[IDebugBreakpointRequest2](../vs140/idebugbreakpointrequest2.md) interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [IDebugBreakpointRequest2](../vs140/idebugbreakpointrequest2.md)   
 [BP_LOCATION_TYPE](../vs140/bp_location_type.md)   
 [BPREQI_FIELDS](../vs140/bpreqi_fields.md)   
 [BP_REQUEST_INFO](../vs140/bp_request_info.md)