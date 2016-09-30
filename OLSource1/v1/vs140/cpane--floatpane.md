---
title: "CPane::FloatPane"
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
  - "FloatPane"
  - "CPane::FloatPane"
  - "CPane.FloatPane"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FloatPane method"
ms.assetid: e706dedc-b7d6-4034-8372-f973b322ebb7
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::FloatPane
Floats the pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the location, in screen coordinates, to position the pane when it is floated.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the docking method to use when the pane is floated. For a list of possible values, see [CPane::DockPane](../vs140/cpane--dockpane.md).  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to show the pane when floated; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> if the pane was floated successfully or if the pane cannot be floated because [CBasePane::CanFloat](../vs140/cbasepane--canfloat.md) returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this method to float the pane at the position that is specified by the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter. This method automatically creates a parent mini-frame window for the pane.  
  
## Requirements  
 **Header:** afxPane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPane::CreateDefaultMiniframe](../vs140/cpane--createdefaultminiframe.md)   
 [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md)   
 [CMultiPaneFrameWnd Class](../vs140/cmultipaneframewnd-class.md)