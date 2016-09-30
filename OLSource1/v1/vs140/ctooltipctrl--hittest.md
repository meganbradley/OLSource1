---
title: "CToolTipCtrl::HitTest"
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
  - "CToolTipCtrl.HitTest"
  - "TTHITTESTINFO"
  - "CToolTipCtrl::HitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HitTest method [MFC]"
  - "TTHITTESTINFO"
ms.assetid: 97a3b48b-f52f-4e79-8e78-4fc0a1cda090
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::HitTest
Tests a point to determine whether it is within the bounding rectangle of the given tool and, if so, retrieve information about the tool.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the window that contains the tool.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object containing the coordinates of the point to be tested.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure that contains information about the tool.  
  
## Return Value  
 Nonzero if the point specified by the hit-test information is within the tool's bounding rectangle; otherwise 0.  
  
## Remarks  
 If this function returns a nonzero value, the structure pointed to by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is filled with information on the tool within whose rectangle the point lies.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> structure is defined as follows:  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 **hwnd**  
 Specifies the tool's handle.  
  
 **pt**  
 Specifies the coordinates of a point if the point is in the tool's bounding rectangle.  
  
 **ti**  
 Information about the tool. For more information about the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> structure, see [CToolTipCtrl::GetToolInfo](../vs140/ctooltipctrl--gettoolinfo.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::GetToolInfo](../vs140/ctooltipctrl--gettoolinfo.md)