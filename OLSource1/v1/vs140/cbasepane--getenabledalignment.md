---
title: "CBasePane::GetEnabledAlignment"
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
  - "GetEnabledAlignment"
  - "CBasePane::GetEnabledAlignment"
  - "CBasePane.GetEnabledAlignment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetEnabledAlignment method"
ms.assetid: 658cfa97-f78a-4aa5-bee4-c66f13d6b19a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::GetEnabledAlignment
Returns the CBRS_ALIGN_ styles that are applied to the pane.  
  
## Syntax  
  
```  
virtual DWORD GetEnabledAlignment() const;  
```  
  
## Return Value  
 A combination of CBRS_ALIGN_ styles. The following table shows the possible styles:  
  
|Flag|Enabled alignment|  
|----------|-----------------------|  
|`CBRS_ALIGN_LEFT`|Left.|  
|`CBRS_ALIGN_RIGHT`|Right.|  
|`CBRS_ALIGN_TOP`|Top.|  
|`CBRS_ALIGN_BOTTOM`|Bottom.|  
|`CBRS_ALIGN_ANY`|Combination of all flags.|  
  
## Remarks  
 Call this method to determine the enabled alignment for the pane. Enabled alignment means the sides of the main frame window that a pane can be docked to.  
  
 Enable docking alignment by using [CBasePane::EnableDocking](../vs140/cbasepane--enabledocking.md).  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)