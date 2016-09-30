---
title: "CMFCRibbonLinkCtrl::CMFCRibbonLinkCtrl"
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
  - "CMFCRibbonLinkCtrl.CMFCRibbonLinkCtrl"
  - "CMFCRibbonLinkCtrl"
  - "CMFCRibbonLinkCtrl::CMFCRibbonLinkCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonLinkCtrl class, constructor"
ms.assetid: 7c77397e-956e-4470-a60e-295f1a775514
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonLinkCtrl::CMFCRibbonLinkCtrl
Constructs and initializes a [CMFCRibbonLinkCtrl](../vs140/cmfcribbonlinkctrl-class.md) object.  
  
## Syntax  
  
```  
CMFCRibbonLinkCtrl(  
    UINT nID,  
    LPCTSTR lpszText,  
    LPCTSTR lpszLink   
);  
```  
  
#### Parameters  
 [in] `nID`  
 Specifies the command ID of the command that executes when the link control is clicked.  
  
 [in] `lpszText`  
 Specifies the label to display on the link control.  
  
 [in] `lpszLink`  
 Specifies the hyperlink associated with the link control.  
  
## Example  
 The following example demonstrates how to use the constructor of the `CMFCRibbonLinkCtrl` class. This code snippet is part of the [Ribbon Gadgets sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_RibbonGadgets#1](../vs140/codesnippet/CPP/cmfcribbonlinkctrl--cmfcribbonlinkctrl_1.cpp)]  
  
## Requirements  
 **Header:** afxRibbonLinkCtrl.h  
  
## See Also  
 [CMFCRibbonLinkCtrl Class](../vs140/cmfcribbonlinkctrl-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)