---
title: "CMFCOutlookBarTabCtrl::EnableInPlaceEdit"
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
  - "CMFCOutlookBarTabCtrl.EnableInPlaceEdit"
  - "EnableInPlaceEdit"
  - "CMFCOutlookBarTabCtrl::EnableInPlaceEdit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableInPlaceEdit method"
ms.assetid: 20ca9c3a-c01d-4f78-974c-bcc1eb96c9b0
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCOutlookBarTabCtrl::EnableInPlaceEdit
Specifies whether a user can modify the text labels on the tab page buttons of the Outlook bar.  
  
## Syntax  
  
```  
virtual void EnableInPlaceEdit(  
   BOOL bEnable   
);  
```  
  
#### Parameters  
 `bEnable`  
 If `TRUE`, enable the in-place editing of the text label. If `FALSE`, disable the in-place editing.  
  
## Remarks  
 Call this function to enable or disable in-place editing of text  labels on tab page buttons. By default the in-place editing is disabled.  
  
## Requirements  
 **Header:** afxOutlookBarTabCtrl.h  
  
## See Also  
 [CMFCOutlookBarTabCtrl Class](../vs140/cmfcoutlookbartabctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)