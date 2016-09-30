---
title: "IDebugProcess2::Attach"
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
  - "IDebugProcess2::Attach"
helpviewer_keywords: 
  - "IDebugProcess2::Attach"
ms.assetid: 40d78417-fde2-45c3-96c9-16e06bd9008d
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcess2::Attach
Attaches the session debug manager (SDM) to the process.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDebugEventCallback2](../vs140/idebugeventcallback2.md) object that is used for debug event notification.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] An array of GUIDs of debug engines to be used to debug programs running in the process. This parameter can be a null value. See Remarks for details.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The number of debug engines in the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> array and the size of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> array.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in, out] An array of HRESULT codes returned by the debug engines. The size of this array is specified in the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter. Each code is typically either <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. The latter indicates that the DE is currently attached to no programs.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>; otherwise, returns an error code. The following table shows other possible values.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The specified process is already attached to the debugger.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|A security violation occurred during the attach procedure.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|A desktop process cannot be attached to the debugger.|  
  
## Remarks  
 Attaching to a process attaches the SDM to all programs running in that process that can be debugged by the debug engines (DE) specified in the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> array. Set the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> parameter to a null value or include <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> in the array to attach to all programs in the process.  
  
 All debug events that occur in the process are sent to the given [IDebugEventCallback2](../vs140/idebugeventcallback2.md) object. This <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object is provided when the SDM calls this method.  
  
## See Also  
 [IDebugProcess2](../vs140/idebugprocess2.md)   
 [IDebugEventCallback2](../vs140/idebugeventcallback2.md)