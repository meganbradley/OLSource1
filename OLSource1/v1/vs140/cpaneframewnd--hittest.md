---
title: "CPaneFrameWnd::HitTest"
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
  - "HitTest"
  - "CPaneFrameWnd.HitTest"
  - "CPaneFrameWnd::HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method"
ms.assetid: d9b6826c-9e4f-4e4e-9ce9-0188361bc0a2
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPaneFrameWnd::HitTest
Determines what part of a mini-frame window is at a given point.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The point to test.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, check the point against the caption. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, ignore the caption.  
  
## Return Value  
 One of the following values:  
  
|Value|Meaning|  
|-----------|-------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The point is outside the mini-frame window.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|The point is in the client area.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The point is on the caption.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The point is at the top.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|The point is at the top left.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|The point is at the top right.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The point is at the left.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The point is at the right.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The point is at the bottom.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|The point is at the bottom left.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The point is at the bottom right.|  
  
## Requirements  
 **Header:** afxpaneframewnd.h  
  
## See Also  
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)