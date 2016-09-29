---
title: "IEnumDebugThreads2::GetCount"
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
  - "IEnumDebugThreads2::GetCount"
helpviewer_keywords: 
  - "IEnumDebugThreads2::GetCount"
ms.assetid: 81b7f139-d24e-4040-9adc-d664d77563ba
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IEnumDebugThreads2::GetCount
Returns the number of elements in the enumeration.  
  
## Syntax  
  
```cpp#  
HRESULT GetCount(  
   ULONG* pcelt  
);  
```  
  
```c#  
int GetCount(  
   out uint pcelt  
);  
```  
  
#### Parameters  
 `pcelt`  
 [out] Returns the number of elements in the enumeration.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method is not part of the customary COM enumeration interface which specifies that only the `Next`, `Clone`, `Skip`, and `Reset` methods need to be implemented.  
  
## See Also  
 [IEnumDebugThreads2](../vs140/ienumdebugthreads2.md)