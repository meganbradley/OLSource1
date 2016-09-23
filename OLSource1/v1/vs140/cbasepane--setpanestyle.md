---
title: "CBasePane::SetPaneStyle"
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
  - CBasePane::SetPaneStyle
  - CBasePane.SetPaneStyle
  - SetPaneStyle
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetPaneStyle method
ms.assetid: 56278360-8fec-464c-be5b-97d6e61db535
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CBasePane::SetPaneStyle
Sets the style of the pane.  
  
## Syntax  
  
```  
virtual void SetPaneStyle(  
   DWORD dwNewStyle  
);  
```  
  
#### Parameters  
 [in] `dwNewStyle`  
 Specifies the new style to set.  
  
## Remarks  
 This method can be used to set any of the CBRS_ styles that are defined in afxres.h. Because pane style and pane alignment are stored together, set the new style by combining it with the current alignment as follows.  
  
 `pPane->SetPaneStyle (pPane->GetCurrentAlignment() | CBRS_TOOLTIPS);`  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBasePane::GetPaneStyle](../vs140/cbasepane--getpanestyle.md)