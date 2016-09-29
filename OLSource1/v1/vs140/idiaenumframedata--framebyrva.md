---
title: "IDiaEnumFrameData::frameByRVA"
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
  - "IDiaEnumFrameData::frameByRVA method"
ms.assetid: 4b8dec05-e76c-4cc4-9644-2369d583849f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumFrameData::frameByRVA
Returns a frame by relative virtual address (RVA).  
  
## Syntax  
  
```cpp#  
HRESULT frameByRVA(   
   DWORD           relativeVirtualAddress,  
   IDiaFrameData** frame  
);  
```  
  
#### Parameters  
 relativeVirtualAddress  
 [in] RVA of the frame of interest.  
  
 frame  
 [out] Returns an [IDiaFrameData](../vs140/idiaframedata.md) object representing the frame that contains the address provided.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if no frame data matches the specified address. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumFrameData](../vs140/idiaenumframedata.md)   
 [IDiaFrameData](../vs140/idiaframedata.md)