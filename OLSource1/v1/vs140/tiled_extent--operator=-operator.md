---
title: "tiled_extent::operator= Operator"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "amp/Concurrency::tiled_extent::operator="
dev_langs: 
  - "C++"
ms.assetid: 76b0c5aa-1f75-48d5-b496-f6040ea6263f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tiled_extent::operator= Operator
Copies the contents of the specified `tiled_index` object into this one.  
  
## Syntax  
  
```  
tiled_extent& operator=(  
   const tiled_extent& _Other  
) restrict (amp, cpu);  
```  
  
#### Parameters  
 `_Other`  
 The `tiled_index` object to copy from.  
  
## Return Value  
 A reference to this `tiled_index` instance.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [tiled_extent Class](../vs140/tiled_extent-class.md)