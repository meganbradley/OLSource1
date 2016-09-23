---
title: "IDiaEnumDebugStreams::Clone"
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
  - IDiaEnumDebugStreams::Clone method
ms.assetid: e85ec592-de97-4f95-a774-1623315ba415
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# IDiaEnumDebugStreams::Clone
Creates an enumerator that contains the same enumeration state as the current enumerator.  
  
## Syntax  
  
```cpp#  
HRESULT Clone (   
   IDiaEnumDebugStreams** ppenum  
);  
```  
  
#### Parameters  
 `ppenum`  
 [out] Returns an [IDiaEnumDebugStreams](../vs140/idiaenumdebugstreams.md) object that contains a duplicate of the  enumerator. The streams are not duplicated, only the enumerator.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumDebugStreams](../vs140/idiaenumdebugstreams.md)