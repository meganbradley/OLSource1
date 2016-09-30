---
title: "CBasePane::CanBeResized"
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
  - "CanBeResized"
  - "CBasePane::CanBeResized"
  - "CBasePane.CanBeResized"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanBeResized method"
ms.assetid: 15b65ab4-9332-4f00-bb8b-03f42f56b5ec
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CanBeResized
Determines whether the pane can be resized.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the pane can be resized; otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method checks for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> flag, which is specified by default in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. If this flag is not specified, the docking manager flags the pane internally as immovable instead of docking it.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)