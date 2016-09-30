---
title: "CDC::DrawIcon"
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
  - "CDC::DrawIcon"
  - "CDC.DrawIcon"
  - "DrawIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawIcon method"
  - "CDC class, simple drawing functions"
ms.assetid: 58e4c033-e806-4449-b330-a6f91129a578
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::DrawIcon
Draws an icon on the device represented by the current <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Specifies the logical x-coordinate of the upper-left corner of the icon.  
  
 *y*  
 Specifies the logical y-coordinate of the upper-left corner of the icon.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Identifies the handle of the icon to be drawn.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the logical x- and y-coordinates of the upper-left corner of the icon. You can pass a [POINT](../vs140/point-structure.md) structure or a [CPoint](../vs140/cpoint-class.md) object for this parameter.  
  
## Return Value  
 Nonzero if the function completed successfully; otherwise 0.  
  
## Remarks  
 The function places the icon's upper-left corner at the location specified by *x* and *y*. The location is subject to the current mapping mode of the device context.  
  
 The icon resource must have been previously loaded by using the functions <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> mapping mode must be selected prior to using this function.  
  
## Example  
 See the example for [CWnd::IsIconic](../vs140/cwnd--isiconic.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWinApp::LoadIcon](../vs140/cwinapp--loadicon.md)   
 [CWinApp::LoadStandardIcon](../vs140/cwinapp--loadstandardicon.md)   
 [CWinApp::LoadOEMIcon](../vs140/cwinapp--loadoemicon.md)   
 [CDC::GetMapMode](../vs140/cdc--getmapmode.md)   
 [CDC::SetMapMode](../vs140/cdc--setmapmode.md)   
 [DrawIcon](http://msdn.microsoft.com/library/windows/desktop/ms648064)   
 [POINT Structure](../vs140/point-structure.md)