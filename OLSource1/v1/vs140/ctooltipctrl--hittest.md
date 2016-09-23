---
title: "CToolTipCtrl::HitTest"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CToolTipCtrl.HitTest
  - TTHITTESTINFO
  - CToolTipCtrl::HitTest
dev_langs: 
  - C++
helpviewer_keywords: 
  - HitTest method [MFC]
  - TTHITTESTINFO
ms.assetid: 97a3b48b-f52f-4e79-8e78-4fc0a1cda090
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolTipCtrl::HitTest
Tests a point to determine whether it is within the bounding rectangle of the given tool and, if so, retrieve information about the tool.  
  
## Syntax  
  
```  
  
      BOOL HitTest(  
   CWnd* pWnd,  
   CPoint pt,  
   LPTOOLINFO lpToolInfo   
) const;  
```  
  
#### Parameters  
 `pWnd`  
 Pointer to the window that contains the tool.  
  
 `pt`  
 Pointer to a `CPoint` object containing the coordinates of the point to be tested.  
  
 `lpToolInfo`  
 Pointer to [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) structure that contains information about the tool.  
  
## Return Value  
 Nonzero if the point specified by the hit-test information is within the tool's bounding rectangle; otherwise 0.  
  
## Remarks  
 If this function returns a nonzero value, the structure pointed to by `lpToolInfo` is filled with information on the tool within whose rectangle the point lies.  
  
 The `TTHITTESTINFO` structure is defined as follows:  
  
 `typedef struct _TT_HITTESTINFO { // tthti`  
  
 `HWND hwnd;   // handle of tool or window with tool`  
  
 `POINT pt;    // client coordinates of point to test`  
  
 `TOOLINFO ti; // receives information about the tool`  
  
 `} TTHITTESTINFO, FAR * LPHITTESTINFO;`  
  
 **hwnd**  
 Specifies the tool's handle.  
  
 **pt**  
 Specifies the coordinates of a point if the point is in the tool's bounding rectangle.  
  
 **ti**  
 Information about the tool. For more information about the `TOOLINFO` structure, see [CToolTipCtrl::GetToolInfo](../vs140/ctooltipctrl--gettoolinfo.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::GetToolInfo](../vs140/ctooltipctrl--gettoolinfo.md)