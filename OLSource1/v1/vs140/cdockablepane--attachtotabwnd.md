---
title: "CDockablePane::AttachToTabWnd"
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
  - "CDockablePane.AttachToTabWnd"
  - "AttachToTabWnd"
  - "CDockablePane::AttachToTabWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AttachToTabWnd method"
ms.assetid: 8f08e351-b7e1-4b7f-aeab-23cfc47fc90c
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::AttachToTabWnd
Attaches the current pane to a target pane, creating a tabbed pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the target pane that the current pane attaches to. The target pane must be a dockable pane.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the docking method.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to activate the tabbed pane after the attach operation; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 [out] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Contains the tabbed pane that results from the attach operation.  
  
## Return Value  
 A pointer to the current pane, if it is not a tabbed pane; otherwise a pointer to the tabbed pane that results from the attach operation. The return value is <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the current pane cannot be attached, or if an error occurs.  
  
## Remarks  
 When one dockable pane attaches to another pane using this method, the following occurs:  
  
1.  The framework checks whether the target pane <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is a regular docking pane or if it is derived from [CBaseTabbedPane](../vs140/cbasetabbedpane-class.md).  
  
2.  If the target pane is a tabbed pane, the framework adds the current pane to it as a tab.  
  
3.  If the target pane is a regular docking pane, the framework creates a tabbed pane.  
  
    -   The framework calls <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The style of the new tabbed pane depends on the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> member. By default, this member is set to the runtime class of [CTabbedPane](../vs140/ctabbedpane-class.md). If you pass the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> style as the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> parameter to the [CDockablePane::Create](../vs140/cdockablepane--create.md) method, the runtime class object is set to the runtime class of [CMFCOutlookBar](../vs140/cmfcoutlookbar-class.md). You can change this member at any time to change the style of the new pane.  
  
    -   When this method creates a tabbed pane, the framework replaces the pointer to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> (if the pane is docked or floating in a multi-miniframe window) with a pointer to the new tabbed pane.  
  
    -   The framework adds the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> pane to the tabbed pane as the first tab. The framework then adds the current pane as a second tab.  
  
4.  If the current pane is derived from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, all of its tabs are moved to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and the current pane is destroyed. Therefore, be careful when you call this method, because a pointer to the current pane may be invalid when the method returns.  
  
 If you attach one pane to another when building a docking layout, set <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 You should dock the first pane before you attach another pane to it.  
  
## Requirements  
 **Header:** afxDockablePane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBasePane::DockPane](../vs140/cbasepane--dockpane.md)   
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [CTabbedPane Class](../vs140/ctabbedpane-class.md)   
 [CMFCOutlookBar Class](../vs140/cmfcoutlookbar-class.md)   
 [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md)   
 [CPaneContainer Class](../vs140/cpanecontainer-class.md)