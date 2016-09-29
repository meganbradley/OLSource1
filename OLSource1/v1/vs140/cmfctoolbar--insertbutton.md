---
title: "CMFCToolBar::InsertButton"
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
  - "CMFCToolBar.InsertButton"
  - "CMFCToolBar::InsertButton"
  - "InsertButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertButton method"
ms.assetid: c4736be1-a623-4045-8353-278255bfd1d0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::InsertButton
Inserts a button into the toolbar.  
  
## Syntax  
  
```  
virtual int InsertButton(  
   const CMFCToolBarButton& button,  
   INT_PTR iInsertAt=-1   
);  
virtual int InsertButton(  
   CMFCToolBarButton* pButton,  
   int iInsertAt=-1   
);  
```  
  
#### Parameters  
 [in] `button`  
 Specifies the button to insert.  
  
 [in] `iInsertAt`  
 Specifies the zero-based position to insert the button at.  
  
## Return Value  
 The position at which the button was inserted or -1 if an error occurs.  
  
## Remarks  
 If `iInsertAt` is -1, this method adds the button to the end of the list of toolbar buttons.  
  
 Call the [CMFCToolBar::InsertSeparator](../vs140/cmfctoolbar--insertseparator.md) method to insert a separator into the toolbar.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::InsertSeparator](../vs140/cmfctoolbar--insertseparator.md)