---
title: "CBasePane::SelectDefaultFont"
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
  - "CBasePane::SelectDefaultFont"
  - "SelectDefaultFont"
  - "CBasePane.SelectDefaultFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SelectDefaultFont method"
ms.assetid: 81f632b8-618d-4272-86cd-0d9082eee5dc
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::SelectDefaultFont
Selects the default font for a given device context.  
  
## Syntax  
  
```  
CFont* SelectDefaultFont(  
   CDC* pDC  
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A device context.  
  
## Return Value  
 A pointer to the default [CFont Class](../vs140/cfont-class.md) object.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)