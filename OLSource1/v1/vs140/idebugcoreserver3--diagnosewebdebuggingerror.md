---
title: "IDebugCoreServer3::DiagnoseWebDebuggingError"
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
  - "IDebugCoreServer3::DiagnoseWebDebuggingError"
helpviewer_keywords: 
  - "IDebugCoreServer3::DiagnoseWebDebuggingError"
ms.assetid: 8c4570ca-ae55-42f2-bbaa-8d8e75d2fa19
caps.latest.revision: 12
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugCoreServer3::DiagnoseWebDebuggingError
Attempts to determine why an auto-attach failed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Not currently used; should always be set to a null value.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code. The following are other typical return codes:  
  
|Code|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Cannot determine why the remote server failed to start debugging.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Cannot debug on remote server, possibly due to insufficient permissions or because the DEBUG verb is not enabled.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The web server has been locked down and is blocking the DEBUG verb, which is required to enable debugging.|  
  
## See Also  
 [IDebugCoreServer3](../vs140/idebugcoreserver3.md)