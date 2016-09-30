---
title: "CBaseTabbedPane::SetAutoDestroy"
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
  - "CBaseTabbedPane.SetAutoDestroy"
  - "SetAutoDestroy"
  - "CBaseTabbedPane::SetAutoDestroy"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAutoDestroy method"
ms.assetid: dc66d4fa-54b8-4a95-986d-cfc707fae244
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::SetAutoDestroy
Determines whether the tabbed control bar will be destroyed automatically.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the tabbed pane was created dynamically and you are not controlling its lifetime; otherwise, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Set the auto-destroy mode to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if you create a tabbed pane dynamically and if you are not controlling its lifetime. If auto-destroy mode is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the tabbed pane will be destroyed automatically by the framework.  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)