---
title: "CPagerCtrl::SetScrollPos"
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
  - "CPagerCtrl::SetScrollPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetScrollPos method"
ms.assetid: 5365a2b7-568e-41e0-8c88-2ef6612d4939
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPagerCtrl::SetScrollPos
Sets the scroll position of the current pager control.  
  
## Syntax  
  
```  
void SetScrollPos(  
     int iPos  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `iPos`|The new scroll position, measured in pixels.|  
  
## Requirements  
 **Header:** afxcmn.h  
  
## Remarks  
 This method sends the [PGM_SETPOS](http://msdn.microsoft.com/library/windows/desktop/bb760886) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [CPagerCtrl Class](../vs140/cpagerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [PGM_SETPOS](http://msdn.microsoft.com/library/windows/desktop/bb760886)   
 [CPagerCtrl::GetScrollPos](../vs140/cpagerctrl--getscrollpos.md)