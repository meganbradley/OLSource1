---
title: "IDebugProcess2::EnumPrograms"
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
  - "IDebugProcess2::EnumPrograms"
helpviewer_keywords: 
  - "IDebugProcess2::EnumPrograms"
ms.assetid: f5b7295d-487d-464f-a4c6-d54175b07705
caps.latest.revision: 14
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# IDebugProcess2::EnumPrograms
Retrieves a list of all the programs contained by this process.  
  
## Syntax  
  
```cpp#  
HRESULT EnumPrograms(   
   IEnumDebugPrograms2** ppEnum  
);  
```  
  
```c#  
int EnumPrograms(   
   out IEnumDebugPrograms2 ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns an [IEnumDebugPrograms2](../vs140/ienumdebugprograms2.md) object that contains a list of all the programs in the process.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProcess2](../vs140/idebugprocess2.md)   
 [IEnumDebugPrograms2](../vs140/ienumdebugprograms2.md)