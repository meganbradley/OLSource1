---
title: "SERVICE_ENTRY_CHAIN"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "SERVICE_ENTRY_CHAIN"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SERVICE_ENTRY_CHAIN macro"
ms.assetid: 09be4ce4-3ccd-4ff2-a95e-a9d5275354c1
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SERVICE_ENTRY_CHAIN
Instructs [IServiceProviderImpl::QueryService](../vs140/iserviceproviderimpl--queryservice.md) to chain to the object specified by `punk`.  
  
## Syntax  
  
```  
  
      SERVICE_ENTRY_CHAIN(   
   punk    
)  
```  
  
#### Parameters  
 `punk`  
 A pointer to the **IUnknown** interface to which to chain.  
  
## Example  
 See the example for [BEGIN_SERVICE_MAP](../vs140/begin_service_map.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Service Map Macros](../vs140/service-map-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [SERVICE_ENTRY](../vs140/service_entry.md)   
 [BEGIN_SERVICE_MAP](../vs140/begin_service_map.md)   
 [END_SERVICE_MAP](../vs140/end_service_map.md)