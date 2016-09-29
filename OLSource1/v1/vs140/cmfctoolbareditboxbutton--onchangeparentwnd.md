---
title: "CMFCToolBarEditBoxButton::OnChangeParentWnd"
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
  - "CMFCToolBarEditBoxButton.OnChangeParentWnd"
  - "CMFCToolBarEditBoxButton::OnChangeParentWnd"
  - "OnChangeParentWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnChangeParentWnd method"
ms.assetid: 11137ddc-c88c-49dc-82d2-b3a68a830d0f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::OnChangeParentWnd
Called by the framework when the button is inserted into a new toolbar.  
  
## Syntax  
  
```  
virtual void OnChangeParentWnd(  
   CWnd* pWndParent  
);  
```  
  
#### Parameters  
 [in] `pWndParent`  
 A pointer to the new parent window.  
  
## Remarks  
 This method overrides the base class implementation ([CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton--onchangeparentwnd.md)) by recreating the internal `CEdit` object.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CEdit Class](../vs140/cedit-class.md)