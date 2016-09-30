---
title: "CPane::SetActiveInGroup"
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
  - "SetActiveInGroup"
  - "CPane::SetActiveInGroup"
  - "CPane.SetActiveInGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetActiveInGroup method"
ms.assetid: 48b8bd81-6384-4658-bde5-ec40a22ccd00
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::SetActiveInGroup
Flags a pane as active.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> that specifies whether the pane is flagged as active.  
  
## Remarks  
 When a dockable pane is shown or an auto-hide button is chosen, the corresponding auto-hide pane is marked as active.  
  
 The appearance of an auto-hide button that is associated with the pane is based on two factors. If the pane is active, and the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, the framework displays the auto-hide button as an icon and a label. For an inactive pane, the framework displays only the auto-hide icon.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, or if the pane is not located in a group, the framework displays the associated auto-hide button as an icon and a label.  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)