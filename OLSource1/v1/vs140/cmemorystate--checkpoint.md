---
title: "CMemoryState::Checkpoint"
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
  - "CMemoryState::Checkpoint"
  - "Checkpoint"
  - "CMemoryState.Checkpoint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMemoryState structure, construction/destruction"
  - "Checkpoint method"
ms.assetid: b2d80fea-3d21-457e-816d-b035909bf21a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemoryState::Checkpoint
Takes a snapshot summary of memory and stores it in this `CMemoryState` object.  
  
## Syntax  
  
```  
  
void Checkpoint( );  
```  
  
## Remarks  
 The `CMemoryState` member functions [Difference](../vs140/cmemorystate--difference.md) and [DumpAllObjectsSince](../vs140/cmemorystate--dumpallobjectssince.md) use this snapshot data.  
  
## Example  
 See the example for the [CMemoryState](../vs140/cmemorystate--cmemorystate.md) constructor.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CMemoryState Structure](../vs140/cmemorystate-structure.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)