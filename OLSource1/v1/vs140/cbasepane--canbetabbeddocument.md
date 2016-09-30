---
title: "CBasePane::CanBeTabbedDocument"
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
  - "CanBeTabbedDocument"
  - "CBasePane::CanBeTabbedDocument"
  - "CBasePane.CanBeTabbedDocument"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeTabbedDocument method"
ms.assetid: 633c64e0-8234-49e8-80f0-4b89ce48c5df
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CanBeTabbedDocument
Specifies whether the pane can be converted to an MDI tabbed document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the pane can be converted to a tabbed document; otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> always returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Only objects of certain <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-derived types, such as the [CDockablePane Class](../vs140/cdockablepane-class.md), can be converted to tabbed documents.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)