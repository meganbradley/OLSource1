---
title: "IDebugProcess3::GetEngineFilter"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - GetEngineFilter
  - IDebugProcess3::GetEngineFilter
ms.assetid: ccb7ecb0-f189-4e80-b5b2-221a095e01f5
caps.latest.revision: 13
translation.priority.mt: 
  - de-de
  - ja-jp
---
# IDebugProcess3::GetEngineFilter
Retrieves an array of unique identifiers for available debug engines.  
  
## Syntax  
  
```cpp#  
HRESULT GetEngineFilter(  
   GUID_ARRAY *pEngineArray  
);  
```  
  
```c#  
public int GetEngineFilter(  
   out GUID_ARRAY[] pEngineArray  
);  
```  
  
#### Parameters  
 `pEngineArray`  
 [out] Reference to a structure that contains unique identifiers for debug engines.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProcess3](../vs140/idebugprocess3.md)   
 [GUID_ARRAY](../vs140/guid_array.md)