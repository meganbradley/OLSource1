---
title: "CBasePane::SetControlBarStyle"
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
  - CBasePane::SetControlBarStyle
  - SetControlBarStyle
  - CBasePane.SetControlBarStyle
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetControlBarStyle method
ms.assetid: 8e133f19-dca3-496c-879d-eaa178bb5d14
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBasePane::SetControlBarStyle
Sets the control bar style.  
  
## Syntax  
  
```  
virtual void SetControlBarStyle(  
   DWORD dwNewStyle  
);  
```  
  
#### Parameters  
 [in] `dwNewStyle`  
 A bitwise-OR combination of the following possible values.  
  
|Style|Description|  
|-----------|-----------------|  
|`AFX_CBRS_FLOAT`|Makes the control bar float.|  
|`AFX_CBRS_AUTOHIDE`|Enables auto-hide mode.|  
|`AFX_CBRS_RESIZE`|Enables resizing of the control bar. When this flag is set, the control bar can be placed in a dockable pane.|  
|`AFX_CBRS_CLOSE`|Enables hiding of the control bar.|  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBasePane::GetControlBarStyle](../vs140/cbasepane--getcontrolbarstyle.md)