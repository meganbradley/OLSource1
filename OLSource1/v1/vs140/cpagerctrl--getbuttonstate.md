---
title: "CPagerCtrl::GetButtonState"
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
  - "CPagerCtrl::GetButtonState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetButtonState method"
ms.assetid: 608170ab-5328-44b2-a2e0-2916e7abbc08
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl::GetButtonState
Retrieves the state of the specified scroll button in the current pager control.  
  
## Syntax  
  
```  
DWORD GetButtonState(  
      int iButton  
) const;  
```  
  
## Requirements  
 **Header:** afxcmn.h  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `iButton`|Indicates the button for which the state is retrieved. If the pager control style is `PGS_HORZ`, specify `PGB_TOPORLEFT` for the left button and `PGB_BOTTOMORRIGHT` for the right button. If the pager control style is `PGS_VERT`, specify `PGB_TOPORLEFT` for the top button and `PGB_BOTTOMORRIGHT` for the bottom button. For more information, see [Pager Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb760859).|  
  
## Return Value  
 The state of the button specified by the `iButton` parameter. The state is either `PGF_INVISIBLE`, `PGF_NORMAL`, `PGF_GRAYED`, `PGF_DEPRESSED`, or `PGF_HOT`. For more information, see the Return Value section of the [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message.  
  
## Remarks  
 This method sends the [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871)