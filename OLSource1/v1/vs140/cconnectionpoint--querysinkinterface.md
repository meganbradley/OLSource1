---
title: "CConnectionPoint::QuerySinkInterface"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - QuerySinkInterface
  - CConnectionPoint::QuerySinkInterface
  - CConnectionPoint.QuerySinkInterface
dev_langs: 
  - C++
helpviewer_keywords: 
  - QuerySinkInterface method
ms.assetid: 291cc11a-e2b9-4a7f-9796-7e0b3d7533d9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CConnectionPoint::QuerySinkInterface
Retrieves a pointer to the requested sink interface.  
  
## Syntax  
  
```  
  
      virtual HRESULT QuerySinkInterface(  
   LPUNKNOWN pUnkSink,  
   void** ppInterface  
);  
```  
  
#### Parameters  
 `pUnkSink`  
 The identifier of the sink interface being requested.  
  
 `ppInterface`  
 A pointer to the interface pointer identified by `pUnkSink`. If the object does not support this interface, \*`ppInterface` is set to **NULL**.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [CConnectionPoint Class](../vs140/cconnectionpoint-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)