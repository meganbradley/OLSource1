---
title: "IDiaStackWalkHelper::searchForReturnAddressStart"
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
  - "IDiaStackWalkHelper::searchForReturnAddressStart method"
ms.assetid: 0a33142e-5d31-44ea-874a-a2e94d95cbd2
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalkHelper::searchForReturnAddressStart
Searches the specified stack frame for a return address at or near the specified stack address.  
  
## Syntax  
  
```cpp#  
HRESULT searchForReturnAddressStart(   
   IDiaFrameData*  frame,  
   ULONGLONG       startAddress,  
   ULONGLONG*      returnAddress  
);  
```  
  
#### Parameters  
 `frame`  
 [in] An [IDiaFrameData](../vs140/idiaframedata.md) object that represents the current stack frame.  
  
 `startAddress`  
 [in] A virtual memory address from which to begin searching.  
  
 `ReturnAddress`  
 [out] Returns the nearest function return address to `startAddress`.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkHelper](../vs140/idiastackwalkhelper.md)   
 [IDiaFrameData](../vs140/idiaframedata.md)