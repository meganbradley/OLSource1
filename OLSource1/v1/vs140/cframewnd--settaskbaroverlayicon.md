---
title: "CFrameWnd::SetTaskbarOverlayIcon"
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
  - "afxwin/CFrameWnd::SetTaskbarOverlayIcon"
  - "SetTaskbarOverlayIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTaskbarOverlayIcon"
ms.assetid: de01645d-99ac-4a35-8bd6-f1047c9975d3
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::SetTaskbarOverlayIcon
Overloaded. Applies an overlay to a taskbar button to indicate application status or to notify the user.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the Resource ID of an icon to use as the overlay. See description for <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> for details.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to a string that provides an alt text version of the information conveyed by the overlay, for accessibility purposes.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The handle of an icon to use as the overlay. This should be a small icon, measuring 16x16 pixels at 96 dots per inch (dpi). If an overlay icon is already applied to the taskbar button, that existing overlay is replaced. This value can be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. How a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> value is handled depends on whether the taskbar button represents a single window or a group of windows. It is the responsibility of the calling application to free <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> when it is no longer needed.  
  
## Return Value  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if OS version is less than Windows 7 or if an error occurs setting the icon.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)