---
title: "CMFCBaseVisualManager::DrawStatusBarProgress"
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
  - "CMFCBaseVisualManager.DrawStatusBarProgress"
  - "DrawStatusBarProgress"
  - "CMFCBaseVisualManager::DrawStatusBarProgress"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawStatusBarProgress method"
ms.assetid: 208d0705-4a6e-4a9c-a833-c5c8e8e06287
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseVisualManager::DrawStatusBarProgress
Draws progress bar on status bar control ([CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)) using the current Windows theme.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to status bar. This value is ignored.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The bounding rectangle of the progress bar in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> coordinates.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The total progress value.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The current progress value.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The start color. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> ignores this. Derived classes can use it for color gradients.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The end color. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> ignores this. Derived classes can use it for color gradients.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Progress text color. <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> ignores this. The text color is defined by <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Specifies whether to display progress text.  
  
## Return Value  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if Theme API is enabled; otherwise <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxvisualmanager.h  
  
## See Also  
 [CMFCBaseVisualManager Class](../vs140/cmfcbasevisualmanager-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)