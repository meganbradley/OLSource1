---
title: "CMFCCmdUsageCount::GetCount"
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
  - CMFCCmdUsageCount.GetCount
  - GetCount
  - CMFCCmdUsageCount::GetCount
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetCount method
ms.assetid: c8b7390a-b48c-4c3b-8d3f-9bda9e6a5d7f
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCCmdUsageCount::GetCount
Retrieves the usage count that is associated with the given command ID.  
  
## Syntax  
  
```  
UINT GetCount(  
   UINT uiCmd  
) const;  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] `uiCmd`|The ID of the command counter to retrieve.|  
  
## Return Value  
 The usage count that is associated with the given command ID.  
  
## Requirements  
 **Header:** afxcmdusagecount.h  
  
## See Also  
 [CMFCCmdUsageCount Class](../vs140/cmfccmdusagecount-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)