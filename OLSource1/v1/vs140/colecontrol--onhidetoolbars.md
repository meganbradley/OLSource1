---
title: "COleControl::OnHideToolBars"
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
  - "OnHideToolBars"
  - "COleControl::OnHideToolBars"
  - "COleControl.OnHideToolBars"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnHideToolbars method"
ms.assetid: 20a4007f-74ec-4aff-ba74-1253d56b83c2
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnHideToolBars
Called by the framework when the control is UI deactivated.  
  
## Syntax  
  
```  
  
virtual void OnHideToolBars( );  
```  
  
## Remarks  
 The implementation should hide all toolbars displayed by `OnShowToolbars`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnShowToolBars](../vs140/colecontrol--onshowtoolbars.md)