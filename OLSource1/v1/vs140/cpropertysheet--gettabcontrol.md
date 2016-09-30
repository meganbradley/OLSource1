---
title: "CPropertySheet::GetTabControl"
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
  - "GetTabControl"
  - "CPropertySheet.GetTabControl"
  - "CPropertySheet::GetTabControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTabControl method"
  - "CPropertySheet class, attributes"
ms.assetid: 53250f63-b3ad-4741-b86d-d09e4a6ab0b4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPropertySheet::GetTabControl
Retrieves a pointer to a tab control to do something specific to the tab control (that is, to use any of the APIs in [CTabCtrl](../vs140/ctabctrl-class.md)).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to a tab control.  
  
## Remarks  
 For example, call this member function if you want to add bitmaps to each of the tabs during initialization.  
  
## Example  
 [!code[NVC_MFCDocView#136](../vs140/codesnippet/CPP/cpropertysheet--gettabcontrol_1.cpp)]  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CPropertySheet Class](../vs140/cpropertysheet-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CTabCtrl::CTabCtrl](../vs140/ctabctrl--ctabctrl.md)