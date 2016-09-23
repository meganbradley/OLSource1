---
title: "BP_TYPE"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - BP_TYPE
helpviewer_keywords: 
  - BP_TYPE enumeration
ms.assetid: ef07191e-7966-43ab-96fb-1a0b1db3115d
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# BP_TYPE
Specifies whether the breakpoint is at a code location, is a data location, or is another type of breakpoint.  
  
## Syntax  
  
```cpp#  
enum enum_BP_TYPE {   
   BPT_NONE    = 0x0000,  
   BPT_CODE    = 0x0001,  
   BPT_DATA    = 0x0002,  
   BPT_SPECIAL = 0x0003  
};  
typedef DWORD BP_TYPE;  
```  
  
```c#  
public enum enum_BP_TYPE {   
   BPT_NONE    = 0x0000,  
   BPT_CODE    = 0x0001,  
   BPT_DATA    = 0x0002,  
   BPT_SPECIAL = 0x0003  
};  
```  
  
## Members  
 BPT_NONE  
 Specifies no breakpoint type.  
  
 BPT_CODE  
 Specifies a code breakpoint.  
  
 BPT_DATA  
 Specifies a data breakpoint.  
  
 BPT_SPECIAL  
 Specifies a breakpoint that is neither a code nor a data type. This type is deprecated and should not be used.  
  
## Remarks  
 Passed as a parameter to the [GetBreakpointType](../vs140/idebugbreakpointresolution2--getbreakpointtype.md) and [GetBreakpointType](../vs140/idebugerrorbreakpointresolution2--getbreakpointtype.md) methods.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [GetBreakpointType](../vs140/idebugbreakpointresolution2--getbreakpointtype.md)   
 [GetBreakpointType](../vs140/idebugerrorbreakpointresolution2--getbreakpointtype.md)