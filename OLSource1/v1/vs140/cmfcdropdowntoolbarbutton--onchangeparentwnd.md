---
title: "CMFCDropDownToolbarButton::OnChangeParentWnd"
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
  - CMFCDropDownToolbarButton.OnChangeParentWnd
  - OnChangeParentWnd
  - CMFCDropDownToolbarButton::OnChangeParentWnd
dev_langs: 
  - C++
helpviewer_keywords: 
  - OnChangeParentWnd method
ms.assetid: 7085ec96-e182-43c4-9162-f901e9c2cba5
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCDropDownToolbarButton::OnChangeParentWnd
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
 This method overrides the base class implementation ([CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton--onchangeparentwnd.md)) by clearing the text label ([CMFCToolBarButton::m_strText](../vs140/cmfctoolbarbutton--m_strtext.md)) and setting the [CMFCToolBarButton::m_bText](../vs140/cmfctoolbarbutton--m_btext.md) and [CMFCToolBarButton::m_bUserButton](../vs140/cmfctoolbarbutton--m_buserbutton.md) data members to `FALSE`.  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCDropDownToolbarButton Class](../vs140/cmfcdropdowntoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnChangeParentWnd](../vs140/cmfctoolbarbutton--onchangeparentwnd.md)   
 [CMFCToolBarButton::m_strText](../vs140/cmfctoolbarbutton--m_strtext.md)   
 [CMFCToolBarButton::m_bText](../vs140/cmfctoolbarbutton--m_btext.md)   
 [CMFCToolBarButton::m_bUserButton](../vs140/cmfctoolbarbutton--m_buserbutton.md)