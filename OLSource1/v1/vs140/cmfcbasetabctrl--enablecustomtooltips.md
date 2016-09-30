---
title: "CMFCBaseTabCtrl::EnableCustomToolTips"
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
  - "EnableCustomToolTips"
  - "CMFCBaseTabCtrl::EnableCustomToolTips"
  - "CMFCBaseTabCtrl.EnableCustomToolTips"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableCustomToolTips method"
ms.assetid: e8215bd9-f9f7-4bd5-b93a-771797cb274a
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCBaseTabCtrl::EnableCustomToolTips
Enables custom tooltips for the tab control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A Boolean that determines whether to use custom tooltips.  
  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if successful; otherwise <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 If custom tooltips are enabled, the tab control sends the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message to the main frame. If you want to support custom tooltips in your application, the main frame window must handle this method and provide the custom tooltip text. For more information about providing custom tooltip text, see [CMFCTabToolTipInfo Class](../vs140/cmfctabtooltipinfo-structure.md).  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
## See Also  
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCTabToolTipInfo Class](../vs140/cmfctabtooltipinfo-structure.md)