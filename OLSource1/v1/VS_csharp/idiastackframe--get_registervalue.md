---
title: "IDiaStackFrame::get_registerValue"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackFrame::get_registerValue method"
ms.assetid: cbe3d8ac-319a-40ac-bc3e-4eb81b2d7807
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackFrame::get_registerValue
Retrieves the value of a specified register as stored in the stack frame.  
  
## Syntax  
  
```cpp#  
HRESULT get_registerValue(  
   ULONG      registerIndex,  
   ULONGLONG *pRetVal  
);  
```  
  
#### Parameters  
 `registerIndex`  
 [in] One of the [CV_HREG_e](../VS_csharp/cv_hreg_e.md) enumeration values.  
  
 `pRetVal`  
 [out] Value stored in the register.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
## See Also  
 [IDiaStackFrame](../VS_csharp/idiastackframe.md)   
 [CV_HREG_e](../VS_csharp/cv_hreg_e.md)