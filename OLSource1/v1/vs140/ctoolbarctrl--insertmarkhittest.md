---
title: "CToolBarCtrl::InsertMarkHitTest"
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
  - CToolBarCtrl.InsertMarkHitTest
  - CToolBarCtrl::InsertMarkHitTest
  - InsertMarkHitTest
dev_langs: 
  - C++
helpviewer_keywords: 
  - InsertMarkHitTest method
  - hit testing insert mark
  - CToolBarCtrl class, attributes
ms.assetid: 0bca462e-3027-4ddc-9fb0-59ab593e7708
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CToolBarCtrl::InsertMarkHitTest
Retrieves the insertion mark information for a point in a toolbar.  
  
## Syntax  
  
```  
  
      BOOL InsertMarkHitTest(  
   LPPOINT ppt,  
   LPTBINSERTMARK ptbim   
) const;  
```  
  
#### Parameters  
 `ppt`  
 A pointer to a [POINT](http://msdn.microsoft.com/library/windows/desktop/dd162805) structure that contains the hit test coordinates, relative to the client area of the toolbar.  
  
 `ptbim`  
 A pointer to a [TBINSERTMARK](http://msdn.microsoft.com/library/windows/desktop/bb760480) structure that receives the insertion mark information.  
  
## Return Value  
 Nonzero if successful; otherwise zero.  
  
## Remarks  
 This member function implements the behavior of the Win32 message [TB_INSERTMARKHITTEST](http://msdn.microsoft.com/library/windows/desktop/bb787367), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolBarCtrl Class](../vs140/ctoolbarctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBarCtrl::GetInsertMark](../vs140/ctoolbarctrl--getinsertmark.md)   
 [CToolBarCtrl::SetInsertMark](../vs140/ctoolbarctrl--setinsertmark.md)