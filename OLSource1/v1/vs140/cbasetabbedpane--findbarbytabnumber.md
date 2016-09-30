---
title: "CBaseTabbedPane::FindBarByTabNumber"
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
  - "FindPaneByTabNumber"
  - "CBaseTabbedPane.FindPaneByTabNumber"
  - "CBaseTabbedPane::FindPaneByTabNumber"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FindPaneByTabNumber method"
ms.assetid: fb0ca90b-7b77-434a-bf83-d4cfcd3d05b9
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::FindBarByTabNumber
Returns a pane that resides in a tab.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the tab to retrieve.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to return the underlying (wrapped) window of the pane instead of the pane itself; otherwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This only applies to panes derived from [CDockablePaneAdapter](../vs140/cdockablepaneadapter-class.md).  
  
## Return Value  
 If the pane is found, then a valid pointer to the pane being searched for is returned; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this method to retrieve the pane residing in the tab specified by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxBaseTabbedPane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)