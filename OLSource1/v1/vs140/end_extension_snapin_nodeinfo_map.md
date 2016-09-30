---
title: "END_EXTENSION_SNAPIN_NODEINFO_MAP"
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
  - "END_EXTENSION_SNAPIN_NODEINFO_MAP"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "END_EXTENSION_SNAPIN_NODEINFO_MAP macro"
ms.assetid: f80a16f9-e2bf-4702-ab58-9e36208d4878
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# END_EXTENSION_SNAPIN_NODEINFO_MAP
Marks the end of the snap-in extension data class map.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Start your snap-in extension map with the [BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/begin_extension_snapin_nodeinfo_map.md) macro, add entries for each of your extension snap-in data types with the [EXTENSION_SNAPIN_NODEINFO_ENTRY](../vs140/extension_snapin_nodeinfo_entry.md) macro, and complete the map with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> macro.  
  
## Example  
 See the example for [BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/begin_extension_snapin_nodeinfo_map.md).  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [Snap-In Object Macros](../vs140/snap-in-object-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [BEGIN_EXTENSION_SNAPIN_NODEINFO_MAP](../vs140/begin_extension_snapin_nodeinfo_map.md)   
 [EXTENSION_SNAPIN_NODEINFO_ENTRY](../vs140/extension_snapin_nodeinfo_entry.md)   
 [EXTENSION_SNAPIN_DATACLASS](../vs140/extension_snapin_dataclass.md)