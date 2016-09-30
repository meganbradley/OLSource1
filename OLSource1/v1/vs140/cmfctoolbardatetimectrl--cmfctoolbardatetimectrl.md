---
title: "CMFCToolBarDateTimeCtrl::CMFCToolBarDateTimeCtrl"
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
  - "CMFCToolBarDateTimeCtrl::CMFCToolBarDateTimeCtrl"
  - "CMFCToolBarDateTimeCtrl"
  - "CMFCToolBarDateTimeCtrl.CMFCToolBarDateTimeCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCToolBarDateTimeCtrl class, constructor"
ms.assetid: 5ed2abbe-7d42-45fc-bd73-fcf1129eaf4d
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarDateTimeCtrl::CMFCToolBarDateTimeCtrl
Creates and initializes a [CMFCToolBarDateTimeCtrl](../vs140/cmfctoolbardatetimectrl-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The control ID.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The index of the image in the toolbar's <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The style of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> window that is created when a user clicks the button.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The width of the control, in pixels.  
  
## Remarks  
 This object is initialized to the system date and time. The window style of the internal <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object includes the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter and the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> styles. You cannot change these styles by using <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to change the style of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> control.  
  
## Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class. This code snippet is part of the [Toolbar Date Time Picker sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_ToolbarDateTimePicker#1](../vs140/codesnippet/CPP/cmfctoolbardatetimectrl--cmfctoolbardatetimectrl_1.cpp)]  
  
## Requirements  
 **Header:** afxtoolbardatetimectrl.h  
  
## See Also  
 [CMFCToolBarDateTimeCtrl Class](../vs140/cmfctoolbardatetimectrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [CMFCToolBarDateTimeCtrlImpl Class](assetId:///4fcddcbc-b374-4c27-bfb4-09fb0ca2eac5)