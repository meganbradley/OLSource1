---
title: "CBasePane::CanFloat"
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
  - "CanFloat"
  - "CBasePane.CanFloat"
  - "CBasePane::CanFloat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanFloat method"
ms.assetid: 845c8a75-0d50-4df4-a110-8fb135b9664e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CanFloat
Determines whether the pane can float.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the pane can float; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 The framework calls this method to determine whether the pane can float.  
  
 During construction, you can set this ability by passing the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> flag to [CBasePane::CreateEx](../vs140/cbasepane--createex.md).  
  
> [!NOTE]
>  The framework assumes that non-floating panes are static and that their docking state cannot change. Therefore, the framework does not save the docking state of non-floating panes.  
  
 The default implementation checks for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> style.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)