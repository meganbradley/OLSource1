---
title: "CBasePane::OnAfterChangeParent"
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
  - "OnAfterChangeParent"
  - "CBasePane::OnAfterChangeParent"
  - "CBasePane.OnAfterChangeParent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnAfterChangeParent method"
ms.assetid: 062f14d6-f955-4659-acf0-74207540277f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::OnAfterChangeParent
Called by the framework after the pane's parent changes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the previous parent.  
  
## Remarks  
 The framework calls this method after the pane's parent changes, usually because of a docking or floating operation.  
  
 The default implementation does nothing.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)