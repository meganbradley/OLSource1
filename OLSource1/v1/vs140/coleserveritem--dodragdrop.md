---
title: "COleServerItem::DoDragDrop"
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
  - "COleServerItem.DoDragDrop"
  - "COleServerItem::DoDragDrop"
  - "DROPEFFECT"
  - "DoDragDrop"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoDragDrop method"
  - "COleServerItem class, operations"
  - "DROPEFFECT"
ms.assetid: 3e57e532-f9a3-4ce2-839b-465738ae7a05
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleServerItem::DoDragDrop
Call the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function to perform a drag-and-drop operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *lpRectItem*  
 The item's rectangle on screen, in pixels, relative to the client area.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The offset from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> where the mouse position was at the time of the drag.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Set this to **TRUE** if link data should be copied to the Clipboard. Set it to **FALSE** if your application does not support links.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Determines the effects that the drag source will allow in the drag operation (a combination of Copy, Move, and Link).  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Pointer to the rectangle that defines where the drag actually starts. For more information, see the following Remarks section.  
  
## Return Value  
 A value from the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> enumeration. If it is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the original data should be removed.  
  
## Remarks  
 The drag-and-drop operation does not start immediately. It waits until the mouse cursor leaves the rectangle specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or until a specified number of milliseconds have passed. If <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is **NULL**, a default rectangle is used so that the drag starts when the mouse cursor moves one pixel.  
  
 The delay time is specified by a registry key setting. You can change the delay time by calling [CWinApp::WriteProfileString](../vs140/cwinapp--writeprofilestring.md) or [CWinApp::WriteProfileInt](../vs140/cwinapp--writeprofileint.md). If you do not specify the delay time, a default value of 200 milliseconds is used. Drag delay time is stored as follows:  
  
-   Windows NT   Drag delay time is stored in HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\NT\CurrentVersion\IniFileMapping\win.ini\Windows\DragDelay.  
  
-   Windows 3.x   Drag delay time is stored in the WIN.INI file, under the [Windows} section.  
  
-   Windows 95/98   Drag delay time is stored in a cached version of WIN.INI.  
  
 For more information about how drag delay information is stored in either the registry or the .INI file, see [WriteProfileString](http://msdn.microsoft.com/library/windows/desktop/ms725504) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleServerItem Class](../vs140/coleserveritem-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDataSource::DoDragDrop](../vs140/coledatasource--dodragdrop.md)   
 [COleServerItem::CopyToClipboard](../vs140/coleserveritem--copytoclipboard.md)