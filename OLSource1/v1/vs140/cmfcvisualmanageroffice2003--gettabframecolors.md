---
title: "CMFCVisualManagerOffice2003::GetTabFrameColors"
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
  - "GetTabFrameColors"
  - "CMFCVisualManagerOffice2003.GetTabFrameColors"
  - "CMFCVisualManagerOffice2003::GetTabFrameColors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabFrameColors method"
ms.assetid: 58a4f6f7-8c19-4b00-b24c-03030f817a1e
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCVisualManagerOffice2003::GetTabFrameColors
The framework calls this function when it has to retrieve the set of colors for drawing a tab window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the tabbed window where the frame is drawing a tab.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) parameter where this method stores the color for the dark border of a tab.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter where this method stores the color for the border of the tab window. The default color for the border is black.  
  
 [out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter where this method stores the color for the highlight state of the tab window.  
  
 [out] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter where this method stores the color for face of the tab window.  
  
 [out] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> parameter where this method stores the color for the shadow of the tab window.  
  
 [out] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 A reference to a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter where this method stores the color for the light edge of the tab window.  
  
 [out] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 A pointer to a reference for a brush. This method stores the brush that it uses to fill the face of the tab window in this parameter.  
  
 [out] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 A pointer to a reference for a brush. This method stores the brush it uses to fill the black edge of the tab window in this parameter.  
  
## Remarks  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)