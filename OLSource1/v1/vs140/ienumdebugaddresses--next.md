---
title: "IEnumDebugAddresses::Next"
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
  - IEnumDebugAddresses::Next
helpviewer_keywords: 
  - IEnumDebugAddresses::Next method
ms.assetid: 941e4be7-858d-433a-9259-18d0d017be9e
caps.latest.revision: 11
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IEnumDebugAddresses::Next
This method returns the next set of elements from the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT Next(  
   ULONG           celt,  
   IDebugAddress** rgelt,  
   ULONG*          pceltFetched  
);  
```  
  
```c#  
int Next(  
   uint            celt,  
   IDebugAddress[] rgelt,  
   ref uint        pceltFetched  
);  
```  
  
#### Parameters  
 `celt`  
 [in] The number of elements to retrieve. Also specifies the maximum size of the `rgelt` array.  
  
 `rgelt`  
 [in, out] Array of [IDebugAddress](../vs140/idebugaddress.md) elements to be filled in.  
  
 `pceltFetched`  
 [out] Returns the number of elements actually returned in `rgelt`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if fewer than the requested number of elements could be returned; otherwise, returns an error code.  
  
## See Also  
 [IEnumDebugAddresses](../vs140/ienumdebugaddresses.md)   
 [IDebugAddress](../vs140/idebugaddress.md)