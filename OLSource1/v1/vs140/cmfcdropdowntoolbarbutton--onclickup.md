---
title: "CMFCDropDownToolbarButton::OnClickUp"
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
  - "OnClickUp"
  - "CMFCDropDownToolbarButton::OnClickUp"
  - "CMFCDropDownToolbarButton.OnClickUp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnClickUp method"
ms.assetid: d0c2fa3a-1b89-4982-9c30-ca7c9506c608
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDropDownToolbarButton::OnClickUp
Called by the framework when the user releases the mouse button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the button processes the click message; otherwise 0.  
  
## Remarks  
 This method extends the base class implementation, [CMFCToolBarButton::OnClickUp](../vs140/cmfctoolbarbutton--onclickup.md), by updating the state of the drop-down toolbar.  
  
 This method stops the drop-down toolbar timer if it is active. It closes the drop-down toolbar if it is open.  
  
 For more information about the drop-down toolbar and drop-down toolbar timer, see [CMFCDropDownToolbarButton::OnClick](../vs140/cmfcdropdowntoolbarbutton--onclick.md).  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
## See Also  
 [CMFCDropDownToolbarButton Class](../vs140/cmfcdropdowntoolbarbutton-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCToolBarButton::OnClickUp](../vs140/cmfctoolbarbutton--onclickup.md)   
 [CMFCDropDownToolbarButton::OnClick](../vs140/cmfcdropdowntoolbarbutton--onclick.md)