---
title: "BEGIN_SNAPINTOOLBARID_MAP"
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
  - ATL.BEGIN_SNAPINTOOLBARID_MAP
  - ATL::BEGIN_SNAPINTOOLBARID_MAP
  - BEGIN_SNAPINTOOLBARID_MAP
dev_langs: 
  - C++
helpviewer_keywords: 
  - snap-in objects
  - snap-in objects, declaring toolbar maps
  - BEGIN_SNAPINTOOLBARID_MAP macro
ms.assetid: 64a8c167-25e1-46c1-93cb-947921c216be
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# BEGIN_SNAPINTOOLBARID_MAP
Declares the beginning of the toolbar ID map for the Snap-In object.  
  
## Syntax  
  
```  
  
BEGIN_SNAPINTOOLBARID_MAP( _class )  
```  
  
#### Parameters  
 `_class`  
 [in] Specifies the Snap-In object class.  
  
## Example  
 [!code[NVC_ATL_Windowing#106](../vs140/codesnippet/CPP/begin_snapintoolbarid_map_1.h)]
  
  
## Requirements  
 **Header:** atlsnap.h  
  
## See Also  
 [Snap-In Object Macros](../vs140/snap-in-object-macros.md)   
 [Macros](../vs140/atl-macros.md)   
 [END_SNAPINTOOLBARID_MAP](../vs140/end_snapintoolbarid_map.md)   
 [SNAPINTOOLBARID_ENTRY](../vs140/snapintoolbarid_entry.md)