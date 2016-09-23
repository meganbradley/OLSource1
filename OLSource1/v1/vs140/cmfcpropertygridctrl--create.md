---
title: "CMFCPropertyGridCtrl::Create"
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
  - Create
  - CMFCPropertyGridCtrl.Create
  - CMFCPropertyGridCtrl::Create
dev_langs: 
  - C++
helpviewer_keywords: 
  - Create method
ms.assetid: fdaf3917-40e9-41c8-9cd4-92f5f0ecdd2a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCPropertyGridCtrl::Create
Creates a property grid control and attaches it to the property grid control object.  
  
## Syntax  
  
```  
virtual BOOL Create(  
   DWORD dwStyle,  
   const RECT& rect,  
   CWnd* pParentWnd,  
   UINT nID   
);  
```  
  
#### Parameters  
 [in] `dwStyle`  
 A bitwise combination (OR) of [window styles](../vs140/window-styles.md).  
  
 [in] `rect`  
 A bounding rectangle that specifies the size and position of the window, in client coordinates of `pParentWnd`.  
  
 [in] `pParentWnd`  
 Pointer to the parent window. Must not be `NULL`.  
  
 [in] `nID`  
 The ID of the child window.  
  
## Return Value  
 `TRUE` if the window was created successfully; otherwise, `FALSE`.  
  
## Remarks  
 To create a property grid control, first call [CMFCPropertyGridCtrl::CMFCPropertyGridCtrl](../vs140/cmfcpropertygridctrl--cmfcpropertygridctrl.md) to construct a property grid object. Then call `CMFCPropertyGridCtrl::Create`.  
  
## Example  
 The following example demonstrates how to use the `Create` method in `CMFCPropertyGridCtrl` class. This example is part of the [New Controls sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_NewControls#15](../vs140/codesnippet/CPP/cmfcpropertygridctrl--create_1.cpp)]
  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::Create](../vs140/cwnd--create.md)