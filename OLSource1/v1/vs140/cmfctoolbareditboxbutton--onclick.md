---
title: "CMFCToolBarEditBoxButton::OnClick"
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
  - "OnClick"
  - "CMFCToolBarEditBoxButton.OnClick"
  - "CMFCToolBarEditBoxButton::OnClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClick method"
ms.assetid: 54e5fbd8-6208-40c3-9cfd-ccfb0b51e26d
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::OnClick
Called by the framework when the user clicks the mouse button.  
  
## Syntax  
  
```  
virtual BOOL OnClick(  
   CWnd* pWnd,  
   BOOL bDelay = TRUE  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 Unused.  
  
 [in] `bDelay`  
 Unused.  
  
## Return Value  
 Nonzero if the button processes the click message; otherwise 0.  
  
## Remarks  
 This method overrides the base class implementation ([CMFCToolBarButton::OnClick](../vs140/cmfctoolbarbutton--onclick.md)) by returning a nonzero value if the internal `CEdit` object is visible.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnClick](../vs140/cmfctoolbarbutton--onclick.md)   
 [CEdit Class](../vs140/cedit-class.md)