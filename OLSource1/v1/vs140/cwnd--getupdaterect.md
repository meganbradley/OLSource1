---
title: "CWnd::GetUpdateRect"
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
  - "CWnd::GetUpdateRect"
  - "CWnd.GetUpdateRect"
  - "GetUpdateRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetUpdateRect method"
ms.assetid: 7c2d3bd8-9acd-44dc-b35c-2601f710444a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::GetUpdateRect
Retrieves the coordinates of the smallest rectangle that completely encloses the update region.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object or [RECT](../vs140/rect-structure.md) structure that is to receive the client coordinates of the update that encloses the update region.  
  
 Set this parameter to **NULL** to determine whether an update region exists within the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is **NULL**, the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> member function returns nonzero if an update region exists and 0 if one does not. This provides a way to determine whether a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> message resulted from an invalid area. Do not set this parameter to **NULL** in Windows version 3.0 and earlier.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies whether the background in the update region is to be erased.  
  
## Return Value  
 Specifies the status of the update region. The value is nonzero if the update region is not empty; otherwise 0.  
  
 If the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter is set to **NULL**, the return value is nonzero if an update region exists; otherwise 0.  
  
## Remarks  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> was created with the **CS_OWNDC** style and the mapping mode is not <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> member function gives the rectangle in logical coordinates. Otherwise, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> gives the rectangle in client coordinates. If there is no update region, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> sets the rectangle to be empty (sets all coordinates to 0).  
  
 The <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameter specifies whether <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> should erase the background of the update region. If <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is **TRUE** and the update region is not empty, the background is erased. To erase the background, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> sends the [WM_ERASEBKGND](../vs140/cwnd--onerasebkgnd.md) message.  
  
 The update rectangle retrieved by the [BeginPaint](../vs140/cwnd--beginpaint.md) member function is identical to that retrieved by the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> member function.  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member function automatically validates the update region, so any call to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> made immediately after a call to <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> retrieves an empty update region.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::BeginPaint](../vs140/cwnd--beginpaint.md)   
 [GetUpdateRect](http://msdn.microsoft.com/library/windows/desktop/dd144943)   
 [CWnd::OnPaint](../vs140/cwnd--onpaint.md)   
 [CWnd::RedrawWindow](../vs140/cwnd--redrawwindow.md)