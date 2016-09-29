---
title: "CReBarCtrl::DragMove"
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
  - "CReBarCtrl::DragMove"
  - "DragMove"
  - "CReBarCtrl.DragMove"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, operations"
  - "DragMove method"
ms.assetid: 68f84da8-e0a1-4b7a-8bbd-b54b5cd3692a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::DragMove
Implements the behavior of the Win32 message [RB_DRAGMOVE](https://msdn.microsoft.com/en-us/library/bb774433.aspx), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
```  
  
      void DragMove(  
   DWORD dwPos = (DWORD  
)-1   
);  
```  
  
#### Parameters  
 `dwPos`  
 A `DWORD` value that contains the new mouse coordinates. The horizontal coordinate is contained in the LOWORD and the vertical coordinate is contained in the HIWORD. If you pass `(DWORD)-1`, the rebar control will use the position of the mouse the last time the control's thread called **GetMessage** or **PeekMessage**.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CReBarCtrl::BeginDrag](../vs140/crebarctrl--begindrag.md)   
 [CReBarCtrl::EndDrag](../vs140/crebarctrl--enddrag.md)   
 [GetMessage](http://msdn.microsoft.com/library/windows/desktop/ms644936)   
 [PeekMessage](http://msdn.microsoft.com/library/windows/desktop/ms644943)