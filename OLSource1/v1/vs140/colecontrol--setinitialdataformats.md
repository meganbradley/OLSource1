---
title: "COleControl::SetInitialDataFormats"
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
  - "COleControl.SetInitialDataFormats"
  - "SetInitialDataFormats"
  - "COleControl::SetInitialDataFormats"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetInitialDataFormats method"
ms.assetid: 58488a91-8966-4c10-928c-190c370426ca
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SetInitialDataFormats
Called by the framework to initialize the list of data formats supported by the control.  
  
## Syntax  
  
```  
  
virtual void SetInitialDataFormats( );  
```  
  
## Remarks  
 The default implementation specifies two formats: `CF_METAFILEPICT` and the persistent property set.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)