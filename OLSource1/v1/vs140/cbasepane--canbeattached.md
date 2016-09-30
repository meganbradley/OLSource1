---
title: "CBasePane::CanBeAttached"
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
  - "CanBeAttached"
  - "CBasePane::CanBeAttached"
  - "CBasePane.CanBeAttached"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeAttached method"
ms.assetid: 3142b024-6481-4bfe-8882-a3a348785d9a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CanBeAttached
Determines whether the pane can be docked to another pane or frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the pane can be docked to another pane or frame window; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The default implementation returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. Override this method in a derived class to enable or disable the ability to dock without calling [CBasePane::EnableDocking](../vs140/cbasepane--enabledocking.md).  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)