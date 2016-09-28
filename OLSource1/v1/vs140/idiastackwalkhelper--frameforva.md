---
title: "IDiaStackWalkHelper::frameForVA"
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
  - "IDiaStackWalkHelper2::frameForVA method"
ms.assetid: f35fc61b-f8dd-473a-b583-82c304059422
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaStackWalkHelper::frameForVA
Retrieves the stack frame that contains the specified virtual address.  
  
## Syntax  
  
```cpp#  
HRESULT frameForVA(   
   ULONGLONG        va,  
   IDiaFrameData**  ppFrame  
);  
```  
  
#### Parameters  
 `va`  
 [in] The virtual address for the frame data.  
  
 `ppFrame`  
 [out] An [IDiaFrameData](../vs140/idiaframedata.md) object that represents the stack frame at the specified address.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkHelper](../vs140/idiastackwalkhelper.md)   
 [IDiaFrameData](../vs140/idiaframedata.md)