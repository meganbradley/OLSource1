---
title: "CDockablePane::Create"
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
  - "Create"
  - "CDockablePane.Create"
  - "CDockablePane::Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method"
ms.assetid: b54d2dac-13b3-4f6d-bbce-43895b35d96b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::Create
Creates the Windows control and attaches it to the [CDockablePane](../vs140/cdockablepane-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the window name.  
  
 [in] [out] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the parent window.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the size and position of the window, in client coordinates of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to create the pane with a caption; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Specifies the ID of the child window. This value must be unique if you want to save docking state for this docking pane.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the window style attributes.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the tabbed style of a tabbed window that is created when the user drags a pane on the caption of this pane.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Specifies additional style attributes.  
  
 [in] [out] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Specifies the create context of the window.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Specifies the window name.  
  
 [in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Specifies the size of the window.  
  
## Return Value  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> if the dockable pane is successfully created; otherwise, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## Remarks  
 Creates a Windows pane and attaches it to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
 If the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> window style has the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> flag, the miniframe window can float with other panes in the miniframe window. By default, docking panes can only float individually.  
  
 If the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> parameter has the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> flag specified, the pane creates Outlook-style tabbed panes when another pane is attached to this pane using the [CDockablePane::AttachToTabWnd](../vs140/cdockablepane--attachtotabwnd.md) method. By default, dockable panes create regular tabbed panes of type [CTabbedPane](../vs140/ctabbedpane-class.md).  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)