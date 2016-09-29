---
title: "CPagerCtrl::ForwardMouse"
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
  - "CPagerCtrl::ForwardMouse"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ForwardMouse method"
ms.assetid: 6fd36fd2-ba70-45cb-8075-f76c57c73e25
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl::ForwardMouse
Enables or disables forwarding [WM_MOUSEMOVE](http://msdn.microsoft.com/library/windows/desktop/ms645616) messages to the window that is contained in the current pager control.  
  
## Syntax  
  
```  
void ForwardMouse(  
     BOOL bForward  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `bForward`|`true` to forward mouse messages, or `false` to not forward mouse messages.|  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Remarks  
 This method sends the [PGM_FORWARDMOUSE](http://msdn.microsoft.com/library/windows/desktop/bb760867) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_FORWARDMOUSE](http://msdn.microsoft.com/library/windows/desktop/bb760867)   
 [WM_MOUSEMOVE](http://msdn.microsoft.com/library/windows/desktop/ms645616)