---
title: "COleControl::OnAppearanceChanged"
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
  - "COleControl::OnAppearanceChanged"
  - "COleControl.OnAppearanceChanged"
  - "OnAppearanceChanged"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAppearanceChanged method"
ms.assetid: 2747d3f9-d02e-4c51-8f7e-5da6926b77cb
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::OnAppearanceChanged
Called by the framework when the stock Appearance property value has changed.  
  
## Syntax  
  
```  
  
virtual void OnAppearanceChanged ( );  
```  
  
## Remarks  
 Override this function if you want notification after this property changes. The default implementation calls `InvalidateControl`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetAppearance](../vs140/colecontrol--getappearance.md)   
 [COleControl::SetAppearance](../vs140/colecontrol--setappearance.md)   
 [COleControl::InvalidateControl](../vs140/colecontrol--invalidatecontrol.md)