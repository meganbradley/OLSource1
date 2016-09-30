---
title: "CDockablePane::CreateEx"
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
  - "CreateEx"
  - "CDockablePane::CreateEx"
  - "CDockablePane.CreateEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateEx method"
ms.assetid: 2e511728-4a2f-490d-a9ac-409f7ecbe4dc
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::CreateEx
Creates the Windows control and attaches it to the [CDockablePane](../vs140/cdockablepane-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the extended style attributes for the new window.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the window name.  
  
 [in] [out] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the parent window.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the size and position of the window, in client coordinates of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> to create the pane with a caption; otherwise, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Specifies the ID of the child window. This value must be unique if you want to save the docking state for this docking pane.  
  
 [in] <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Specifies the window style attributes.  
  
 [in] <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Specifies the tabbed style of a tabbed window that is created when the user drags a pane on the caption of this pane.  
  
 [in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Specifies the additional style attributes.  
  
 [in] [out] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Specifies the create context of the window.  
  
## Return Value  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> if the dockable pane is successfully created; otherwise, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Remarks  
 Creates a Windows pane and attaches it to the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
 If the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> window style has the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> flag, the miniframe window can float with other panes in the miniframe window. By default, docking panes can only float individually.  
  
 If the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> parameter has the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> flag specified, the pane creates Outlook-style tabbed panes when another pane is attached to this pane using the [CDockablePane::AttachToTabWnd](../vs140/cdockablepane--attachtotabwnd.md) method. By default, dockable panes create regular tabbed panes of type [CTabbedPane](../vs140/ctabbedpane-class.md).  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)