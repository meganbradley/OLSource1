---
title: "CDC::SetViewportExt"
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
  - "CDC::SetViewportExt"
  - "SetViewportExt"
  - "CDC.SetViewportExt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, mapping functions"
  - "SetViewportExt method"
ms.assetid: eba2b828-7620-4c9d-80e6-707d21d8f6ad
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetViewportExt
Sets the x- and y-extents of the viewport of the device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the x-extent of the viewport (in device units).  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the y-extent of the viewport (in device units).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the x- and y-extents of the viewport (in device units).  
  
## Return Value  
 The previous extents of the viewport as a [CSize](../vs140/csize-class.md) object. When an error occurs, the x- and y-coordinates of the returned <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object are both set to 0.  
  
## Remarks  
 The viewport, along with the device-context window, defines how GDI maps points in the logical coordinate system to points in the coordinate system of the actual device. In other words, they define how GDI converts logical coordinates into device coordinates.  
  
 When the following mapping modes are set, calls to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> are ignored:  
  
|MM_HIENGLISH|MM_LOMETRIC|  
|-------------------|------------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|  
  
 When <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> mode is set, an application must call the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> member function before it calls <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [CView::OnPrepareDC](../vs140/cview--onpreparedc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetWindowExt](../vs140/cdc--setwindowext.md)   
 [CSize Class](../vs140/csize-class.md)   
 [CDC::GetViewportExt](../vs140/cdc--getviewportext.md)