---
title: "CMDIChildWndEx::OnTaskbarTabThumbnailActivate"
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
  - "OnTaskbarTabThumbnailActivate"
  - "afxmdichildwndex/CMDIChildWndEx::OnTaskbarTabThumbnailActivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnTaskbarTabThumbnailActivate"
ms.assetid: ee974bbc-5e33-48a0-8d00-72d5925afc1a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWndEx::OnTaskbarTabThumbnailActivate
Called by the framework when the Taskbar tab thumbnail should process the WM_ACTIVATE message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is being activated or deactivated.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Pointer to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> being activated or deactivated. The pointer can be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and it may be temporary.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Specifies the minimized state of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> being activated or deactivated. A value of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> indicates the window is minimized.  
  
## Remarks  
 The default implementation activates the related MDI child frame.  
  
## Requirements  
 **Header:** afxmdichildwndex.h  
  
## See Also  
 [CMDIChildWndEx Class](../vs140/cmdichildwndex-class.md)