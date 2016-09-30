---
title: "CMFCRibbonPanel::AddToolBar"
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
  - "CMFCRibbonPanel.AddToolBar"
  - "CMFCRibbonPanel::AddToolBar"
  - "AddToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddToolBar method"
ms.assetid: c120bec1-5b81-487b-921f-52cc7cee47bb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonPanel::AddToolBar
Adds a toolbar to the ribbon panel.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the resource ID of the toolbar to add.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the resource ID of the toolbar's cold images.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the resource ID of the toolbar's hot images.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the resource ID of the toolbar's disabled images.  
  
## Return Value  
 Call this method to add a toolbar to the ribbon panel. The toolbar will be added next to the ribbon element added by the previous call to [CMFCRibbonPanel::Add](../vs140/cmfcribbonpanel--add.md).  
  
## Remarks  
 For more information about toolbars, hot images, cold images, and disabled images, see [CMFCToolBar Class](../vs140/cmfctoolbar-class.md).  
  
## Requirements  
 **Header:** afxRibbonPanel.h  
  
## See Also  
 [CMFCRibbonPanel Class](../vs140/cmfcribbonpanel-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)