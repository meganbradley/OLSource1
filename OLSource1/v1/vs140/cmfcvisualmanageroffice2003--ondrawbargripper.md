---
title: "CMFCVisualManagerOffice2003::OnDrawBarGripper"
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
  - CMFCVisualManagerOffice2003.OnDrawBarGripper
  - CMFCVisualManagerOffice2003::OnDrawBarGripper
  - OnDrawBarGripper
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnDrawBarGripper method
ms.assetid: fd19b5fc-1bd5-499d-b502-22ade91c579f
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCVisualManagerOffice2003::OnDrawBarGripper
Called by the framework when it draws the gripper for a control bar.  
  
## Syntax  
  
```  
virtual void OnDrawBarGripper(  
   CDC* pDC,  
   CRect rectGripper,  
   BOOL bHorz,  
   CBasePane* pBar  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to the device context for a control bar.  
  
 [in] `rectGripper`  
 The bounding rectangle for the control bar.  
  
 [in] `bHorz`  
 A Boolean parameter that specifies whether the control bar is docked horizontally or vertically.  
  
 [in] `pBar`  
 A pointer to a control bar. The visual manager draws the gripper of this control bar.  
  
## Remarks  
 The default implementation of this method displays the standard gripper. To customize the appearance of the gripper, override this method in a custom class derived from the [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md) Class.  
  
## Requirements  
 **Header:** afxvisualmanageroffice2003.h  
  
## See Also  
 [CMFCVisualManagerOffice2003 Class](../vs140/cmfcvisualmanageroffice2003-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)