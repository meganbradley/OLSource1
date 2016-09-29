---
title: "CPagerCtrl::IsButtonNormal"
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
  - "CPagerCtrl::IsButtonNormal"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsButtonNormal method"
ms.assetid: 7c75ec61-a190-4f82-9b9b-fd2ae6233e37
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl::IsButtonNormal
Indicates whether the specified scroll button of the current pager control is in normal state.  
  
## Syntax  
  
```  
BOOL IsButtonNormal(  
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
 `true` if the specified button is in normal state; otherwise, `false`.  
  
## Remarks  
 This method sends the [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. It then tests whether the state that is returned is `PGF_NORMAL`. For more information, see the Return Value section of the [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871) message.  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_GETBUTTONSTATE](http://msdn.microsoft.com/library/windows/desktop/bb760871)   
 [CPagerCtrl::GetButtonState](../vs140/cpagerctrl--getbuttonstate.md)