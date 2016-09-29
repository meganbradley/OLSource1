---
title: "COleControlSite::IsWindowEnabled"
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
  - "COleControlSite::IsWindowEnabled"
  - "COleControlSite.IsWindowEnabled"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsWindowEnabled method"
  - "COleControlSite class, overridables"
ms.assetid: 5d658bcc-9fba-47b0-8f5d-095cb821a896
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlSite::IsWindowEnabled
Determines if the control site is enabled.  
  
## Syntax  
  
```  
  
virtual BOOL IsWindowEnabled( ) const;  
  
```  
  
## Return Value  
 Nonzero if the control is enabled, otherwise zero.  
  
## Remarks  
 The value is retrieved from the control's Enabled stock property.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlSite Class](../vs140/colecontrolsite-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)