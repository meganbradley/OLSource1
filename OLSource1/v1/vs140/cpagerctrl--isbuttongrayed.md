---
title: "CPagerCtrl::IsButtonGrayed"
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
  - CPagerCtrl::IsButtonGrayed
dev_langs: 
  - C++
helpviewer_keywords: 
  - IsButtonGrayed method
ms.assetid: 6d043660-27cb-4abf-ac0c-de91a9ce0be4
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CPagerCtrl::IsButtonGrayed
Indicates whether the specified scroll button of the current pager control is in grayed state.  
  
## Syntax  
  
```  
BOOL IsButtonGrayed(  
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
 `true` if the specified button is in grayed state; otherwise, `false`.  
  
## Remarks  
 This method sends the [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It then tests whether the state that is returned is `PGF_GRAYED`. For more information, see the Return Value section of the [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message.  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871)   
 [CPagerCtrl::GetButtonState](../vs140/cpagerctrl--getbuttonstate.md)