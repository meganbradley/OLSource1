---
title: "CMDIChildWndEx::OnTaskbarTabThumbnailMouseActivate"
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
  - "afxmdichildwndex/CMDIChildWndEx::OnTaskbarTabThumbnailMouseActivate"
  - "OnTaskbarTabThumbnailMouseActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnTaskbarTabThumbnailMouseActivate"
ms.assetid: 14a5cdea-54cb-4c8f-bf28-cbcc1a5e5ac3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::OnTaskbarTabThumbnailMouseActivate
Called by the framework when the Taskbar tab thumbnail should process the WM_MOUSEACTIVATE message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies a pointer to the top-level parent window of the window being activated. The pointer may be temporary and should not be stored.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the hit-test area code. A hit test is a test that determines the location of the cursor.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the mouse message number.  
  
## Remarks  
 The default implementation activates the related MDI child frame.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)