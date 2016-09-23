---
title: "CMFCToolBarDateTimeCtrl::CMFCToolBarDateTimeCtrl"
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
  - CMFCToolBarDateTimeCtrl::CMFCToolBarDateTimeCtrl
  - CMFCToolBarDateTimeCtrl
  - CMFCToolBarDateTimeCtrl.CMFCToolBarDateTimeCtrl
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMFCToolBarDateTimeCtrl class, constructor
ms.assetid: 5ed2abbe-7d42-45fc-bd73-fcf1129eaf4d
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCToolBarDateTimeCtrl::CMFCToolBarDateTimeCtrl
Creates and initializes a [CMFCToolBarDateTimeCtrl](../vs140/cmfctoolbardatetimectrl-class.md) object.  
  
## Syntax  
  
```  
CMFCToolBarDateTimeCtrl(  
   UINT uiID,  
   int iImage,  
   DWORD dwStyle=0,  
   int iWidth=0  
);  
```  
  
#### Parameters  
 [in] `uiID`  
 The control ID.  
  
 [in] `iImage`  
 The index of the image in the toolbar's `CMFCToolBarImages` object.  
  
 [in] `dwStyle`  
 The style of the `CMFCToolBarDateTimeCtrlImpl` window that is created when a user clicks the button.  
  
 [in] `iWidth`  
 The width of the control, in pixels.  
  
## Remarks  
 This object is initialized to the system date and time. The window style of the internal `CMFCToolBarDateTimeCtrlImpl` object includes the `dwStyle` parameter and the `WS_CHILD` and `WS_VISIBLE` styles. You cannot change these styles by using `CMFCToolBarDateTimeCtrl::SetStyle`. Use `SetStyle` to change the style of the `CMFCToolBarDateTimeCtrl` control.  
  
## Example  
 The following example demonstrates how to construct an object of the `CMFCToolBarDateTimeCtrl` class. This code snippet is part of the [Toolbar Date Time Picker sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_ToolbarDateTimePicker#1](../vs140/codesnippet/CPP/cmfctoolbardatetimectrl--cmfctoolbardatetimectrl_1.cpp)]
  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [CMFCToolBarDateTimeCtrlImpl Class](assetId:///4fcddcbc-b374-4c27-bfb4-09fb0ca2eac5)