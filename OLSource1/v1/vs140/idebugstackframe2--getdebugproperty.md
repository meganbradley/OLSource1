---
title: "IDebugStackFrame2::GetDebugProperty"
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
  - IDebugStackFrame2::GetDebugProperty
helpviewer_keywords: 
  - IDebugStackFrame2::GetDebugProperty
ms.assetid: 02c2fa04-1424-4bca-9936-feaecd2afab6
caps.latest.revision: 14
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugStackFrame2::GetDebugProperty
Gets a description of the properties of a stack frame.  
  
## Syntax  
  
```cpp#  
HRESULT GetDebugProperty (   
   IDebugProperty2** ppDebugProp  
);  
```  
  
```c#  
int GetDebugProperty (   
   out IDebugProperty2 ppDebugProp  
);  
```  
  
#### Parameters  
 `ppDebugProp`  
 [out] Returns an [IDebugProperty2](../vs140/idebugproperty2.md) object that describes the properties of this stack frame.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Calling the [EnumChildren](../vs140/idebugproperty2--enumchildren.md) method with appropriate filters can retrieve the local variables, method parameters, registers, and "this" pointer associated with the stack frame.  
  
## See Also  
 [IDebugStackFrame2](../vs140/idebugstackframe2.md)   
 [IDebugProperty2](../vs140/idebugproperty2.md)