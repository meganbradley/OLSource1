---
title: "CMFCToolBar::SetButtonText"
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
  - "SetButtonText"
  - "CMFCToolBar::SetButtonText"
  - "CMFCToolBar.SetButtonText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetButtonText method"
ms.assetid: 170e7792-4e6a-4933-b4b8-578d73f9bc78
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetButtonText
Sets the text label of a toolbar button.  
  
## Syntax  
  
```  
BOOL SetButtonText(  
   int nIndex,  
   LPCTSTR lpszText   
);  
```  
  
#### Parameters  
 [in] `nIndex`  
 The index of the toolbar button.  
  
 [in] `lpszText`  
 The text label of the toolbar button. Must be non-`NULL`.  
  
## Return Value  
 `TRUE` if the method succeeds; otherwise `FALSE`.  
  
## Remarks  
 This method returns `FALSE` if the provided index does not refer to a valid toolbar button.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)