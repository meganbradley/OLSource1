---
title: "CCommonDialog::CCommonDialog"
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
  - CCommonDialog.CCommonDialog
  - CCommonDialog::CCommonDialog
dev_langs: 
  - C++
helpviewer_keywords: 
  - CCommonDialog class, constructor
ms.assetid: bfa36e22-5aea-4874-933c-8ff5a0529be8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CCommonDialog::CCommonDialog
Constructs a `CCommonDialog` object.  
  
## Syntax  
  
```  
  
      explicit CCommonDialog(  
   CWnd* pParentWnd   
);  
```  
  
#### Parameters  
 `pParentWnd`  
 Points to the parent or owner window object (of type [CWnd](../vs140/cwnd-class.md)) to which the dialog object belongs. If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
## Remarks  
 See [CDialog::CDialog](../vs140/cdialog--cdialog.md) for complete information.  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CCommonDialog Class](../vs140/ccommondialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDialog::CDialog](../vs140/cdialog--cdialog.md)