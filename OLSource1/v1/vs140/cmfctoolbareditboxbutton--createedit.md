---
title: "CMFCToolBarEditBoxButton::CreateEdit"
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
  - "CMFCToolBarEditBoxButton::CreateEdit"
  - "CMFCToolBarEditBoxButton.CreateEdit"
  - "CreateEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEdit method"
ms.assetid: 4bd67fdf-9f7b-4dec-9c74-a6eab6cb4780
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarEditBoxButton::CreateEdit
Creates a new edit control in the button.  
  
## Syntax  
  
```  
virtual CEdit* CreateEdit(  
   CWnd* pWndParent,  
   const CRect& rect   
);  
```  
  
#### Parameters  
 `[in] pWndParent`  
 Specifies the parent window of the edit control. It must not be NULL.  
  
 `[in] rect`  
 Specifies the edit control's size and position.  
  
## Return Value  
 A pointer to the newly created edit control; it is `NULL` if the control's creation and attachment fail.  
  
## Remarks  
 You construct a [CMFCToolBarEditBoxButton](../vs140/cmfctoolbareditboxbutton-class.md) object in two steps. First call the constructor, and then call `CreateEdit,` which creates the Windows edit control and attaches it to the `CMFCToolBarEditBoxButton` object.  
  
## Requirements  
 **Header:** afxtoolbareditboxbutton.h  
  
## See Also  
 [CMFCToolBarEditBoxButton Class](../vs140/cmfctoolbareditboxbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)