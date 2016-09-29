---
title: "BEGIN_COM_MAP"
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
  - "BEGIN_COM_MAP"
  - "ATL::BEGIN_COM_MAP"
  - "ATL.BEGIN_COM_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_COM_MAP macro"
  - "COM maps"
ms.assetid: ead2a1e3-334d-44ad-bb1f-b94bb14c2333
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_COM_MAP
The COM map is the mechanism that exposes interfaces on an object to a client through `QueryInterface`.  
  
## Syntax  
  
```  
  
BEGIN_COM_MAP( x )  
```  
  
#### Parameters  
 *x*  
 [in] The name of the class object you are exposing interfaces on.  
  
## Remarks  
 [CComObjectRootEx::InternalQueryInterface](../Topic/CComObjectRootEx::InternalQueryInterface.md) only returns pointers for interfaces in the COM map. Start your interface map with the `BEGIN_COM_MAP` macro, add entries for each of your interfaces with the [COM_INTERFACE_ENTRY](../VS_csharp/com_interface_entry--atl-.md) macro or one of its variants, and complete the map with the [END_COM_MAP](../VS_csharp/end_com_map.md) macro.  
  
## Example  
 From the ATL [BEEPER](../VS_csharp/visual-c---samples.md) sample:  
  
 [!code[NVC_ATL_COM#1](../VS_csharp/codesnippet/CPP/begin_com_map_1.h)]  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [COM Map Macros](../VS_csharp/com-map-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)