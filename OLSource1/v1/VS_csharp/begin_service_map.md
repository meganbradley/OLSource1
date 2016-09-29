---
title: "BEGIN_SERVICE_MAP"
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
  - "ATL::BEGIN_SERVICE_MAP"
  - "ATL.BEGIN_SERVICE_MAP"
  - "BEGIN_SERVICE_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "service maps"
  - "BEGIN_SERVICE_MAP macro"
ms.assetid: 3c6ae156-8776-4588-8227-2d234daec236
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_SERVICE_MAP
Marks the beginning of the service map.  
  
## Syntax  
  
```  
  
BEGIN_SERVICE_MAP( theClass )  
```  
  
#### Parameters  
 `theClass`  
 [in] Specifies the class containing the service map.  
  
## Remarks  
 Use the service map to implement service provider functionality on your COM object. First, you must derive your class from [IServiceProviderImpl](../VS_csharp/iserviceproviderimpl-class.md). There are two types of entries:  
  
-   [SERVICE_ENTRY](../VS_csharp/service_entry.md) Indicates support for the specified service ID (SID).  
  
-   [SERVICE_ENTRY_CHAIN](../VS_csharp/service_entry_chain.md) Instructs [IServiceProviderImpl::QueryService](../VS_csharp/iserviceproviderimpl--queryservice.md) to chain to another, specified object.  
  
## Example  
 [!code[NVC_ATL_COM#57](../VS_csharp/codesnippet/CPP/begin_service_map_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Service Map Macros](../VS_csharp/service-map-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)   
 [END_SERVICE_MAP](../VS_csharp/end_service_map.md)