---
title: "IDebugProcess3::GetENCAvailableState"
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
  - "IDebugProcess3::GetENCAvailableState"
helpviewer_keywords: 
  - "IDebugProcess3::GetENCAvailableState"
ms.assetid: 98a5d527-8a72-476c-8e92-0bff3d97c195
caps.latest.revision: 15
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcess3::GetENCAvailableState
This method gets the current Edit and Continue state of the process. A custom port supplier should always return `E_NOTIMPL`.  
  
## Syntax  
  
```cpp  
HRESULT GetENCAvailableState(  
   EncUnavailableReason* pReason  
);  
```  
  
```c#  
int GetENCAvailableState(  
   EncUnavailableReason[] pReason  
);  
```  
  
#### Parameters  
 `pReason`  
 [out] A value from the [EncUnavailableReason](../vs140/encunavailablereason.md) enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns error code.  
  
> [!NOTE]
>  A custom port supplier should always return `E_NOTIMPL`.  
  
## Remarks  
 This state can be affected by [IDebugProcess3::DisableENC](../vs140/idebugprocess3--disableenc.md).  
  
## See Also  
 [IDebugProcess3](../vs140/idebugprocess3.md)   
 [IDebugProcess3::DisableENC](../vs140/idebugprocess3--disableenc.md)   
 [EncUnavailableReason](../vs140/encunavailablereason.md)