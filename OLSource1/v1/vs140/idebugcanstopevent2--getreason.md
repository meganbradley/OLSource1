---
title: "IDebugCanStopEvent2::GetReason"
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
  - "IDebugCanStopEvent2::GetReason"
helpviewer_keywords: 
  - "IDebugCanStopEvent2::GetReason"
ms.assetid: f5de31ca-7b8d-4029-9cf9-ba860ac66af6
caps.latest.revision: 15
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCanStopEvent2::GetReason
Gets the reason why the debug engine (DE) wants to stop.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns a value from the [CANSTOP_REASON](../vs140/canstop_reason.md) enumeration that describes the reason for this event.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 This method is typically called before the [IDebugCanStopEvent2::CanStop](../vs140/idebugcanstopevent2--canstop.md) method so the caller can determine whether to pass non-zero (<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>) to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> method.  
  
 The reason for stopping can be either <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which means the DE has reached an entry point, or <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which means the DE has stepped into a function.  
  
## See Also  
 [IDebugCanStopEvent2](../vs140/idebugcanstopevent2.md)   
 [CANSTOP_REASON](../vs140/canstop_reason.md)   
 [IDebugCanStopEvent2::CanStop](../vs140/idebugcanstopevent2--canstop.md)