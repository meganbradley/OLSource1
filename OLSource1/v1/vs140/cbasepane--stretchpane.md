---
title: "CBasePane::StretchPane"
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
  - "CBasePane.StretchPane"
  - "StretchPane"
  - "CBasePane::StretchPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StretchPane method"
ms.assetid: 81e67ecf-fd31-4324-9fbf-864a9a28677c
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::StretchPane
Stretches a pane vertically or horizontally.  
  
## Syntax  
  
```  
virtual CSize StretchPane(  
   int nLength,  
   BOOL bVert  
);  
```  
  
#### Parameters  
 [in] `nLength`  
 The length by which to stretch the pane.  
  
 [in] `bVert`  
 If `TRUE`, stretch the pane vertically. If `FALSE`, stretch the pane horizontally.  
  
## Return Value  
 The size of the stretched pane.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)