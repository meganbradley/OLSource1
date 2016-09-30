---
title: "CMFCToolBar::OnUserToolTip"
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
  - "OnUserToolTip"
  - "CMFCToolBar::OnUserToolTip"
  - "CMFCToolBar.OnUserToolTip"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnUserToolTip method"
ms.assetid: bffb929a-d768-4b4d-94ed-776932045439
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::OnUserToolTip
Called by the framework when the tooltip for a button is about to be displayed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a toolbar button for which a tooltip is to be displayed.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object that receives the text of the tooltip.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> was populated with tooltip text; otherwise <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method when the tooltip for a toolbar button is about to be displayed. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the framework displays a tooltip which contains the text returned by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>. Otherwise, the tooltip contains the button text.  
  
 Override <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> to customize tool tips of toolbar buttons. The default implementation calls [CMFCToolBar::OnUserToolTip](../vs140/cmfctoolbar--onusertooltip.md) to obtain the tooltip text.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)