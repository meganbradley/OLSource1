---
title: "CBasePane::ShowPane"
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
  - "CBasePane::ShowPane"
  - "CBasePane.ShowPane"
  - "ShowPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ShowPane method"
ms.assetid: 37cdf8ac-fc48-4138-894e-07d7d070576b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::ShowPane
Shows or hides the pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies whether to show (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) or hide (<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>) a pane.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, recalculating the docking layout is delayed.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, the pane is active when shown.  
  
## Remarks  
 This method shows or hides a pane. Use this method instead of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> because this method notifies the relevant docking managers about changes in the pane's visibility.  
  
 Use [CBasePane::IsVisible](../vs140/cbasepane--isvisible.md) to determine the current visibility of a pane.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)