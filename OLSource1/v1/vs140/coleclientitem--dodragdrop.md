---
title: "COleClientItem::DoDragDrop"
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
  - "COleClientItem.DoDragDrop"
  - "COleClientItem::DoDragDrop"
  - "DoDragDrop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoDragDrop method"
  - "COleClientItem class, clipboard operations"
ms.assetid: 3c49f6e3-cb89-44e3-b130-3448c9d52f73
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleClientItem::DoDragDrop
Call the `DoDragDrop` member function to perform a drag-and-drop operation.  
  
## Syntax  
  
```  
  
      DROPEFFECT DoDragDrop(  
   LPCRECT lpItemRect,  
   CPoint ptOffset,  
   BOOL bIncludeLink = FALSE,  
   DWORD dwEffects = DROPEFFECT_COPY | DROPEFFECT_MOVE,  
   LPCRECT lpRectStartDrag = NULL   
);  
```  
  
#### Parameters  
 `lpItemRect`  
 The item's rectangle on screen in client coordinates (pixels).  
  
 `ptOffset`  
 The offset from `lpItemRect` where the mouse position was at the time of the drag.  
  
 `bIncludeLink`  
 Set this to **TRUE** if the link data should be copied to the Clipboard. Set it to **FALSE** if your server application does not support links.  
  
 `dwEffects`  
 Determines the effects that the drag source will allow in the drag operation.  
  
 `lpRectStartDrag`  
 Pointer to the rectangle that defines where the drag actually starts. For more information, see the following Remarks section.  
  
## Return Value  
 A `DROPEFFECT` value. If it is `DROPEFFECT_MOVE`, the original data should be removed.  
  
## Remarks  
 The drag-and-drop operation does not start immediately. It waits until the mouse cursor leaves the rectangle specified by `lpRectStartDrag` or until a specified number of milliseconds have passed. If `lpRectStartDrag` is **NULL**, the size of the rectangle is one pixel.  
  
 The delay time is specified by a registry key setting. You can change the delay time by calling [CWinApp::WriteProfileString](../vs140/cwinapp--writeprofilestring.md) or [CWinApp::WriteProfileInt](../vs140/cwinapp--writeprofileint.md). If you do not specify the delay time, a default value of 200 milliseconds is used. Drag delay time is stored as follows:  
  
-   Windows NT   Drag delay time is stored in HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\NT\CurrentVersion\IniFileMapping\win.ini\Windows\DragDelay.  
  
-   Windows 3.x   Drag delay time is stored in the WIN.INI file, under the [Windows} section.  
  
-   Windows 95/98   Drag delay time is stored in a cached version of WIN.INI.  
  
 For more information about how drag delay information is stored in either the registry or the .INI file, see [WriteProfileString](http://msdn.microsoft.com/library/windows/desktop/ms725504) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleClientItem Class](../vs140/coleclientitem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::DoDragDrop](../vs140/coledatasource--dodragdrop.md)   
 [COleClientItem::CopyToClipboard](../vs140/coleclientitem--copytoclipboard.md)