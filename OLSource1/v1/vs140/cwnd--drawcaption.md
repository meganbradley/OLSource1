---
title: "CWnd::DrawCaption"
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
  - "CWnd::DrawCaption"
  - "DrawCaption"
  - "CWnd.DrawCaption"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawCaption method"
ms.assetid: 360b4094-7ab9-4a4b-9f1a-3a8a05606ac9
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::DrawCaption
Draws a window caption.  
  
## Syntax  
  
```  
  
      BOOL DrawCaption(  
   CDC* pDC,  
   LPCRECT lprc,  
   UINT uFlags  
);  
```  
  
#### Parameters  
 `pDC`  
 A pointer to a device context. The function draws the window caption into this device context.  
  
 `lprc`  
 A pointer to a RECT structure that specifies the bounding rectangle for the window caption.  
  
 `uFlags`  
 Specifies drawing options. For a complete list of values, see [DrawCaption](http://msdn.microsoft.com/library/windows/desktop/dd162476).  
  
## Return Value  
 Nonzero if the function succeeds; otherwise 0.  
  
## Remarks  
 This member function emulates the functionality of the function [DrawCaption](http://msdn.microsoft.com/library/windows/desktop/dd162476), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)