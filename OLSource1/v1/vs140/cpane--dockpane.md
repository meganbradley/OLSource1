---
title: "CPane::DockPane"
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
  - "DockPane"
  - "CPane.DockPane"
  - "CPane::DockPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DockPane method"
ms.assetid: 0351bfbc-6f0b-478e-9e0e-c32958864ebe
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::DockPane
Docks the floating pane to a base pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the base pane to dock this pane to.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the rectangle on the base pane where this pane is to be docked.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the docking method to use. Available options are as follows:  
  
|Option|Description|  
|------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The framework uses this option when the docking method is unknown. The pane does not store its most recent floating position. You can also use this option to programmatically dock a pane when you do not have to store the recent floating position.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Used internally.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|This option is used when the gripper is double-clicked. The pane is repositioned at its most recent docking position. If the pane is undocked by double-clicking, the pane is repositioned at its most recent floating position.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|This option can be used to programmatically dock the pane. The pane stores its most recent floating position.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The pane is docked in the region that is specified by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|When you use this option, the framework draws the pane as an outline frame while it is being moved.|  
  
## Return Value  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> if the pane was docked successfully; otherwise, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method docks the pane to the base pane that is specified by the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter. You must first enable docking by calling [CBasePane::EnableDocking](../vs140/cbasepane--enabledocking.md).  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)