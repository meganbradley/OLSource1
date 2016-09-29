---
title: "CToolBar::SetButtonText"
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
  - "CToolBar::SetButtonText"
  - "SetButtonText"
  - "CToolBar.SetButtonText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "toolbar controls [MFC], button text"
  - "SetButtonText method"
  - "CToolBar class, construction/destruction"
ms.assetid: 891b8476-5aea-44a5-8170-372b5d7484eb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar::SetButtonText
Call this function to set the text on a button.  
  
## Syntax  
  
```  
  
      BOOL SetButtonText(  
   int nIndex,  
   LPCTSTR lpszText   
);  
```  
  
#### Parameters  
 `nIndex`  
 Index of the button whose text is to be set.  
  
 `lpszText`  
 Points to the text to be set on a button.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Example  
 See the example for [CToolBar::GetToolBarCtrl](../vs140/ctoolbar--gettoolbarctrl.md).  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::GetButtonText](../vs140/ctoolbar--getbuttontext.md)