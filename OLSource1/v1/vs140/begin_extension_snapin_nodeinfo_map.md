---
title: "BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP"
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
  - "BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP"
  - "ATL::BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP"
  - "ATL.BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP macro"
ms.assetid: 04526ef9-2080-4629-ae9b-ff1d4686a2c3
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP
Marks the beginning of the snap-in extension data class map.  
  
## Syntax  
  
```  
  
BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP( classname )  
```  
  
#### Parameters  
 *classname*  
 [in] The name of the snap-in extension data class.  
  
## Remarks  
 Start your snap-in extension map with the `BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP` macro, add entries for each of your snap-in extension data types with the [EXTENSION_SNAPIN_NODEINFO_ENTRY](../vs140/extension_snapin_nodeinfo_entry.md) macro, and complete the map with the [END_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/end_extension_snapin_nodeinfo_map.md) macro.  
  
## Example  
 [!code[NVC_ATL_Windowing#105](../vs140/codesnippet/CPP/begin_extension_snapin_nodeinfo_map_1.h)]  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [Snap-In Object Macros](../vs140/snap-in-object-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [END_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/end_extension_snapin_nodeinfo_map.md)   
 [EXTENSION_SNAPIN_NODEINFO_ENTRY](../vs140/extension_snapin_nodeinfo_entry.md)   
 [EXTENSION_SNAPIN_DATACLASS](../vs140/extension_snapin_dataclass.md)