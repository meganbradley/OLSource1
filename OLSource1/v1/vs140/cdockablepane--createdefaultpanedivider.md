---
title: "CDockablePane::CreateDefaultPaneDivider"
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
  - "CreateDefaultPaneDivider"
  - "CDockablePane::CreateDefaultPaneDivider"
  - "CDockablePane.CreateDefaultPaneDivider"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateDefaultPaneDivider method"
ms.assetid: 1eed178a-c637-4af6-92d5-d471dab157c8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::CreateDefaultPaneDivider
Creates a default divider for the pane as it is being docked to a frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the side of the main frame to which the pane is being docked. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> contains the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> flag, this method creates a vertical (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>) divider; otherwise, this method creates a horizontal (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>) divider.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to the parent frame.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Not used.  
  
## Return Value  
 This method returns a pointer to the newly-created divider, or <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> if divider creation fails.  
  
## Remarks  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> can be any of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The pane is being docked to the top of the client area of a frame window.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The pane is being docked to the bottom of the client area of a frame window.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The pane is being docked to the left side of the client area of a frame window.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|The pane is being docked to the right side of the client area of a frame window.|  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)