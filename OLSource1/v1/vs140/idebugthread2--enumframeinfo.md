---
title: "IDebugThread2::EnumFrameInfo"
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
  - "IDebugThread2::EnumFrameInfo"
helpviewer_keywords: 
  - "IDebugThread2::EnumFrameInfo"
ms.assetid: 17914a71-10ea-4b6f-8982-e364f87dca53
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugThread2::EnumFrameInfo
Retrieves a list of the stack frames for this thread.  
  
## Syntax  
  
```cpp#  
HRESULT EnumFrameInfo (   
   FRAMEINFO_FLAGS        dwFieldSpec,  
   UINT                   nRadix,  
   IEnumDebugFrameInfo2** ppEnum  
);  
```  
  
```c#  
int EnumFrameInfo (   
   enum_FRAMEINFO_FLAGS     dwFieldSpec,  
   uint                     nRadix,  
   out IEnumDebugFrameInfo2 ppEnum  
);  
```  
  
#### Parameters  
 `dwFieldSpec`  
 [in] A combination of flags from the [FRAMEINFO_FLAGS](../vs140/frameinfo_flags.md) enumeration that specifies which fields of the [FRAMEINFO](../vs140/frameinfo.md) structures are to be filled out. Specify the `FIF_FUNCNAME_FORMAT` flag to format the function name into a single string.  
  
 `nRadix`  
 [in] Radix used in formatting numerical information in the enumerator.  
  
 `ppEnum`  
 [out] Returns an [IEnumDebugFrameInfo2](../vs140/ienumdebugframeinfo2.md) object that contains a list of [FRAMEINFO](../vs140/frameinfo.md) structures describing the stack frame.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The thread's frames are enumerated in order, with the current frame enumerated first and the oldest frame enumerated last.  
  
## See Also  
 [IDebugThread2](../vs140/idebugthread2.md)   
 [FRAMEINFO_FLAGS](../vs140/frameinfo_flags.md)   
 [IEnumDebugFrameInfo2](../vs140/ienumdebugframeinfo2.md)   
 [FRAMEINFO](../vs140/frameinfo.md)