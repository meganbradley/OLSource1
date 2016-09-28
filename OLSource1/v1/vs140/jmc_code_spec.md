---
title: "JMC_CODE_SPEC"
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
  - "JMC_CODE_SPEC"
helpviewer_keywords: 
  - "JMC_CODE_SPEC structure"
ms.assetid: d89498f1-4234-46d9-b4e2-abbcbca5068a
caps.latest.revision: 10
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# JMC_CODE_SPEC
This structure is used to set the JustMyCode information for a module.  
  
## Syntax  
  
```cpp#  
typedef struct _JMC_CODE_SPEC {  
   BOOL fIsUserCode;  
   BSTR bstrModuleName;  
} JMC_CODE_SPEC;  
```  
  
```c#  
public struct JMC_CODE_SPEC {  
   public int    fIsUserCode;  
   public string bstrModuleName;  
};  
```  
  
## Members  
 fIsUserCode  
 Non-zero (`TRUE`) if the module is to be considered user code; otherwise, zero (`FALSE`) if the module is to be treated as external code and not to be debugged.  
  
 bstrModuleName  
 Name of the module in question.  
  
## Remarks  
 This structure is passed as a list of such structures to the [IDebugEngine3::SetJustMyCodeState](../vs140/idebugengine3--setjustmycodestate.md) method.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../vs140/structures-and-unions.md)   
 [IDebugEngine3::SetJustMyCodeState](../vs140/idebugengine3--setjustmycodestate.md)