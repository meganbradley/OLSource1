---
title: "CMFCToolBar::CalcFixedLayout"
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
  - "CalcFixedLayout"
  - "CMFCToolBar.CalcFixedLayout"
  - "CMFCToolBar::CalcFixedLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcFixedLayout method"
ms.assetid: 3734d495-c9ec-4e3f-ae03-c9a55650dda3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::CalcFixedLayout
Calculates the horizontal size of the toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to stretch the toolbar to the size of the parent frame.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to orient the toolbar horizontally; <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to orient the toolbar vertically.  
  
## Return Value  
 A <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object that specifies the size of the toolbar.  
  
## Remarks  
 This method calculates the size of the toolbar by using the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method. It passes the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> flag for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter if <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. It passes the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> flag if <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 See the VisualStudioDemo sample for an example that uses this method.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)