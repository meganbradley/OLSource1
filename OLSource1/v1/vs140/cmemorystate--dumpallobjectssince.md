---
title: "CMemoryState::DumpAllObjectsSince"
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
  - "CMemoryState::DumpAllObjectsSince"
  - "DumpAllObjectsSince"
  - "CMemoryState.DumpAllObjectsSince"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMemoryState structure, operations"
  - "DumpAllObjectsSince method"
ms.assetid: a7f89034-bca4-4786-88d5-1571a5425ab2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemoryState::DumpAllObjectsSince
Calls the `Dump` function for all objects of a type derived from class `CObject` that were allocated (and are still allocated) since the last [Checkpoint](../vs140/cmemorystate--checkpoint.md) call for this `CMemoryState` object.  
  
## Syntax  
  
```  
  
void DumpAllObjectsSince( ) const;  
```  
  
## Remarks  
 Calling `DumpAllObjectsSince` with an uninitialized `CMemoryState` object will dump out all objects currently in memory.  
  
## Example  
 See the example for the [CMemoryState](../vs140/cmemorystate--cmemorystate.md) constructor.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CMemoryState Structure](../vs140/cmemorystate-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)