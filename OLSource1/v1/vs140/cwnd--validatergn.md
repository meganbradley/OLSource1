---
title: "CWnd::ValidateRgn"
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
  - "ValidateRgn"
  - "CWnd::ValidateRgn"
  - "CWnd.ValidateRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ValidateRgn method"
  - "client areas, validating"
  - "validating client areas"
ms.assetid: 2955d3fc-ce8d-4807-b0cc-d3398b7b49b8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::ValidateRgn
Validates the client area within the given region by removing the region from the current update region of the window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a [CRgn](../vs140/crgn-class.md) object that identifies a region that defines the area to be removed from the update region. If this parameter is **NULL**, the entire client area is removed.  
  
## Remarks  
 The given region must have been created previously by a region function. The region coordinates are assumed to be client coordinates.  
  
 The [BeginPaint](../vs140/cwnd--beginpaint.md) member function automatically validates the entire client area. Neither the [ValidateRect](../vs140/cwnd--validaterect.md) nor the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> member function should be called if a portion of the update region must be validated before the next [WM_PAINT](http://msdn.microsoft.com/library/windows/desktop/dd145213) message is generated.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [ValidateRgn](http://msdn.microsoft.com/library/windows/desktop/dd145195)   
 [CWnd::ValidateRect](../vs140/cwnd--validaterect.md)