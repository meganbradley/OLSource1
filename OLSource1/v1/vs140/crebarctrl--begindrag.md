---
title: "CReBarCtrl::BeginDrag"
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
  - "CReBarCtrl.BeginDrag"
  - "BeginDrag"
  - "CReBarCtrl::BeginDrag"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CReBarCtrl class, operations"
  - "BeginDrag method"
ms.assetid: 3778cea6-98a7-43f4-bf98-c5c8a0e98467
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CReBarCtrl::BeginDrag
Implements the behavior of the Win32 message [RB_BEGINDRAG](http://msdn.microsoft.com/library/windows/desktop/bb774429), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Zero-based index of the band that the drag-and-drop operation will affect.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value that contains the starting mouse coordinates. The horizontal coordinate is contained in the LOWORD and the vertical coordinate is contained in the HIWORD. If you pass <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the rebar control will use the position of the mouse the last time the control's thread called **GetMessage** or **PeekMessage**.  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CReBarCtrl Class](../vs140/crebarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [GetMessage](http://msdn.microsoft.com/library/windows/desktop/ms644936)   
 [PeekMessage](http://msdn.microsoft.com/library/windows/desktop/ms644943)