---
title: "EXTENSION_SNAPIN_NODEINFO_ENTRY"
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
  - "EXTENSION_SNAPIN_NODEINFO_ENTRY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EXTENSION_SNAPIN_NODEINFO_ENTRY macro"
ms.assetid: ad0757c7-db65-49d2-b148-36d7a90832ec
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EXTENSION_SNAPIN_NODEINFO_ENTRY
Adds a snap-in extension data class to the snap-in extension data class map.  
  
## Syntax  
  
```  
  
      EXTENSION_SNAPIN_NODEINFO_ENTRY(   
   dataClass    
)  
```  
  
#### Parameters  
 `dataClass`  
 [in] The data class of the snap-in extension.  
  
## Remarks  
 Start your snap-in extension data class map with the [BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/begin_extension_snapin_nodeinfo_map.md) macro, add entries for each of your snap-in extension data types with the `EXTENSION_SNAPIN_NODEINFO_ENTRY` macro, and complete the map with the [END_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/end_extension_snapin_nodeinfo_map.md) macro.  
  
## Example  
 See the example for [BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/begin_extension_snapin_nodeinfo_map.md).  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [Snap-In Object Macros](../vs140/snap-in-object-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/begin_extension_snapin_nodeinfo_map.md)   
 [END_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/end_extension_snapin_nodeinfo_map.md)   
 [EXTENSION_SNAPIN_DATACLASS](../vs140/extension_snapin_dataclass.md)