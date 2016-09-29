---
title: "CMFCToolBarButton::OnChangeParentWnd"
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
  - "CMFCToolBarButton::OnChangeParentWnd"
  - "CMFCToolBarButton.OnChangeParentWnd"
  - "OnChangeParentWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnChangeParentWnd method"
ms.assetid: 47bb1a4a-2cb3-49ae-adcb-1292b6b45eb5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::OnChangeParentWnd
Called by the framework when the button is inserted into a new toolbar.  
  
## Syntax  
  
```  
virtual void OnChangeParentWnd(  
   CWnd* pWndParent   
);  
```  
  
#### Parameters  
 [in] `pWndParent`  
 The new parent window.  
  
## Remarks  
 The button is inserted into a toolbar, for example, when the user drags it from one toolbar to another toolbar.  
  
 The default implementation of this method does nothing.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)