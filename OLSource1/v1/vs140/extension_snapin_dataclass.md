---
title: "EXTENSION_SNAPIN_DATACLASS"
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
  - EXTENSION_SNAPIN_DATACLASS
dev_langs: 
  - C++
helpviewer_keywords: 
  - EXTENSION_SNAPIN_DATACLASS macro
ms.assetid: bb6d0a0e-3984-49d2-a37c-71fc62b10d57
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# EXTENSION_SNAPIN_DATACLASS
Adds a data member to the snap-in extension data class for an **ISnapInItemImpl**-derived class.  
  
## Syntax  
  
```  
  
      EXTENSION_SNAPIN_DATACLASS(   
   dataClass    
)  
```  
  
#### Parameters  
 `dataClass`  
 [in] The data class of the snap-in extension.  
  
## Remarks  
 This class should also be entered into a snap-in extension data class map. Start your snap-in extension data class map with the [BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/begin_extension_snapin_nodeinfo_map.md) macro, add entries for each of your snap-in extension data types with the [EXTENSION_SNAPIN_NODEINFO_ENTRY](../vs140/extension_snapin_nodeinfo_entry.md) macro, and complete the map with the [END_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/end_extension_snapin_nodeinfo_map.md) macro.  
  
## Example  
 [!code[NVC_ATL_Windowing#105](../vs140/codesnippet/CPP/extension_snapin_dataclass_1.h)]
  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [Snap-In Object Macros](../vs140/snap-in-object-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/begin_extension_snapin_nodeinfo_map.md)   
 [EXTENSION_SNAPIN_NODEINFO_ENTRY](../vs140/extension_snapin_nodeinfo_entry.md)   
 [END_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/end_extension_snapin_nodeinfo_map.md)