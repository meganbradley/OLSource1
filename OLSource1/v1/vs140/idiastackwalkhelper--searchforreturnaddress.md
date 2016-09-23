---
title: "IDiaStackWalkHelper::searchForReturnAddress"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - IDiaStackWalkHelper2::searchForReturnAddress method
ms.assetid: 904223b1-6e26-4980-b310-d0b222cdbbbd
caps.latest.revision: 13
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaStackWalkHelper::searchForReturnAddress
Searches the specified stack frame for the nearest function return address.  
  
## Syntax  
  
```cpp#  
HRESULT searchForReturnAddress(   
   IDiaFrameData*  frame,  
   ULONGLONG*      returnAddress  
);  
```  
  
#### Parameters  
 `frame`  
 [in] An [IDiaFrameData](../vs140/idiaframedata.md) object that represents the current stack frame.  
  
 `returnAddress`  
 [out] Returns the nearest function return address.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkHelper](../vs140/idiastackwalkhelper.md)   
 [IDiaFrameData](../vs140/idiaframedata.md)