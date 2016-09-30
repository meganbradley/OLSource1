---
title: "CMFCToolBarButton::OnClick"
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
  - "CMFCToolBarButton.OnClick"
  - "CMFCToolBarButton::OnClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClick method"
ms.assetid: bbb9835c-6fab-4e71-b7fe-d793b300e7ef
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarButton::OnClick
Called by the framework when the user clicks the mouse button.  
  
## Syntax  
  
```  
virtual BOOL OnClick(  
   CWnd* pWnd,  
   BOOL bDelay=TRUE   
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 The parent window of the toolbar button.  
  
 [in] `bDelay`  
 `TRUE` if the message should be handled with a delay.  
  
## Return Value  
 This method returns `FALSE`.  
  
## Remarks  
 The framework calls this method when the user clicks the toolbar button.  
  
 The default implementation does nothing and returns `FALSE`. Override this method to return a nonzero value if the button processes the click message.  
  
## Requirements  
 **Header:** afxtoolbarbutton.h  
  
## See Also  
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)