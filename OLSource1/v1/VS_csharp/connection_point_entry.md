---
title: "CONNECTION_POINT_ENTRY"
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
  - "CONNECTION_POINT_ENTRY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComConnectionPoint class"
  - "CONNECTION_POINT_ENTRY macro"
  - "connection point maps [C++]"
ms.assetid: 0a7f3053-6433-49b2-a9b5-8a307e8efe14
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CONNECTION_POINT_ENTRY
Enters a connection point for the specified interface into the connection point map so that it can be accessed.  
  
## Syntax  
  
```  
  
CONNECTION_POINT_ENTRY(   
iid  
 )  
  
```  
  
#### Parameters  
 `iid`  
 [in] The GUID of the interface being added to the connection point map.  
  
## Remarks  
 Connection point entries in the map are used by [IConnectionPointContainerImpl](../VS_csharp/iconnectionpointcontainerimpl-class.md). The class containing the connection point map must inherit from `IConnectionPointContainerImpl`.  
  
 Start your connection point map with the [BEGIN_CONNECTION_POINT_MAP](../VS_csharp/begin_connection_point_map.md) macro, add entries for each of your connection points with the `CONNECTION_POINT_ENTRY` macro, and complete the map with the [END_CONNECTION_POINT_MAP](../VS_csharp/end_connection_point_map.md) macro.  
  
 For more information about connection points in ATL, see the article [Connection Points](../VS_csharp/atl-connection-points.md).  
  
## Example  
 [!code[NVC_ATL_Windowing#120](../VS_csharp/codesnippet/CPP/connection_point_entry_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [Connection Point Macros](../VS_csharp/connection-point-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)