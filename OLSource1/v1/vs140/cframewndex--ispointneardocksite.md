---
title: "CFrameWndEx::IsPointNearDockSite"
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
  - "CFrameWndEx::IsPointNearDockSite"
  - "CFrameWndEx.IsPointNearDockSite"
  - "IsPointNearDockSite"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsPointNearDockSite method"
ms.assetid: 72836492-a22c-48bc-aca5-5a6ec90f8189
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::IsPointNearDockSite
Determines whether the point is located in an alignment zone.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The position of the point.  
  
 [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Where the point is aligned. See the table in the Remarks section for possible values.  
  
 [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the point is located close to the frame border; <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the point is located in a client area.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the point is located in an alignment zone; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The following table lists the possible values for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Aligned to the top.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Aligned to the right.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Aligned to the bottom.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Aligned to the left.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)