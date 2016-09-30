---
title: "CMFCColorBar::OnSendCommand"
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
  - "CMFCColorBar::OnSendCommand"
  - "OnSendCommand"
  - "CMFCColorBar.OnSendCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnSendCommand method"
  - "CMFCColorBar::OnSendCommand"
ms.assetid: 926e18b1-a530-42e6-ad8f-5869c17c7514
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::OnSendCommand
Called by the framework to close a hierarchy of pop-up controls.  
  
## Syntax  
  
```  
virtual BOOL OnSendCommand(  
   const CMFCToolBarButton* pButton  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pButton`|Pointer to a control that resides on a toolbar.|  
  
## Return Value  
 `TRUE` if this method is successful; otherwise, `FALSE`.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [CMFCToolBarButton Class](../vs140/cmfctoolbarbutton-class.md)