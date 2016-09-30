---
title: "INTERCEPT_EXCEPTION_ACTION"
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
  - "INTERCEPT_EXCEPTION_ACTION"
helpviewer_keywords: 
  - "INTERCEPT_EXCEPTION_ACTION enumeration"
ms.assetid: e647f1eb-2932-4447-8c78-3b0d706fb972
caps.latest.revision: 13
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# INTERCEPT_EXCEPTION_ACTION
Specifies what actions to take when intercepting exceptions.  
  
## Syntax  
  
```cpp#  
enum enum_INTERCEPT_EXCEPTION_ACTION  
{  
   IEA_INTERCEPT = 0x0001  
}  
typedef DWORD INTERCEPT_EXCEPTION_ACTION;  
```  
  
```c#  
public enum enum_INTERCEPT_EXCEPTION_ACTION  
{  
   IEA_INTERCEPT = 0x0001  
}  
```  
  
#### Parameters  
 IEA_INTERCEPT  
 Enables intercepting the current exception. This is the only value supported at present and must be specified.  
  
## Remarks  
 These values are passed into the [IDebugStackFrame3::InterceptCurrentException](../vs140/idebugstackframe3--interceptcurrentexception.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations (Visual Studio Debugging SDK)](../vs140/enumerations--visual-studio-debugging-.md)   
 [IDebugStackFrame3::InterceptCurrentException](../vs140/idebugstackframe3--interceptcurrentexception.md)