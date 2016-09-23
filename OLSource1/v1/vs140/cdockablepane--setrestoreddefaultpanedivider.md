---
title: "CDockablePane::SetRestoredDefaultPaneDivider"
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
  - SetRestoredDefaultPaneDivider
  - CDockablePane::SetRestoredDefaultPaneDivider
  - CDockablePane.SetRestoredDefaultPaneDivider
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetRestoredDefaultPaneDivider method
ms.assetid: ddd4248f-1e81-4275-a2f2-55aa0e9816f6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDockablePane::SetRestoredDefaultPaneDivider
Sets the restored default pane divider.  
  
## Syntax  
  
```  
void SetRestoredDefaultPaneDivider(  
   HWND hRestoredSlider  
);  
```  
  
#### Parameters  
 [in] `hRestoredSlider`  
 A handle to a pane divider (slider).  
  
## Remarks  
 A restored default pane divider is obtained when a pane is deserialized. For more information, see [CDockablePane::RestoreDefaultPaneDivider](../vs140/cdockablepane--restoredefaultpanedivider.md).  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)