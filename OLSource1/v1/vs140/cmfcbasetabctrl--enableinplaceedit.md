---
title: "CMFCBaseTabCtrl::EnableInPlaceEdit"
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
  - "CMFCBaseTabCtrl::EnableInPlaceEdit"
  - "EnableInPlaceEdit"
  - "CMFCBaseTabCtrl.EnableInPlaceEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableInPlaceEdit method"
ms.assetid: 6e9a263b-8771-4132-a400-0399df227f97
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::EnableInPlaceEdit
Enables direct editing of the tab labels by the user.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A Boolean parameter that specifies whether to enable direct editing of the tab labels.  
  
## Remarks  
 By default, direct editing of the tab labels is disabled for tab controls.  
  
 You can enable direct editing for a subset of the tabs on the tab control. To do this, override the method <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> should return a nonzero value for all tabs that support direct editing of tab labels.  
  
 In the [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md), this method is a pure virtual function and has no implementation. If you derive a class from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, you must implement this function.  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)