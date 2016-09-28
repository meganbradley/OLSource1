---
title: "CWnd::EnableToolTips"
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
  - "CWnd::EnableToolTips"
  - "CWnd.EnableToolTips"
  - "EnableToolTips"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "enabling tool tips"
  - "CWnd class, tool tip functions"
  - "EnableToolTips method"
  - "tool tips [C++], enabling"
ms.assetid: 186b5b14-c000-4492-84f0-9ec83cf5b63f
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::EnableToolTips
Enables tool tips for the given window.  
  
## Syntax  
  
```  
  
      BOOL EnableToolTips(  
   BOOL bEnable = TRUE  
);  
```  
  
#### Parameters  
 `bEnable`  
 Specifies whether the tool tip control is enabled or disabled. **TRUE** enables the control; **FALSE** disables the control.  
  
## Return Value  
 **TRUE** if tool tips are enabled; otherwise **FALSE**.  
  
## Remarks  
 Override [OnToolHitTest](../vs140/cwnd--ontoolhittest.md) to provide the [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) struct or structs for the window.  
  
> [!NOTE]
>  Some windows, such as [CToolBar](../vs140/ctoolbar-class.md), provide a built-in implementation of [OnToolHitTest](../vs140/cwnd--ontoolhittest.md).  
  
 See [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information on this structure.  
  
 Simply calling `EnableToolTips` is not enough to display tool tips for your child controls unless the parent window is derived from `CFrameWnd`. This is because `CFrameWnd` provides a default handler for the **TTN_NEEDTEXT** notification. If your parent window is not derived from `CFrameWnd`, that is, if it is a dialog box or a form view, tool tips for your child controls will not display correctly unless you provide a handler for the **TTN_NEEDTEXT** tool tip notification. See [Tool Tips](../vs140/tool-tips-in-windows-not-derived-from-cframewnd.md).  
  
 The default tool tips provided for your windows by `EnableToolTips` do not have text associated with them. To retrieve text for the tool tip to display, the **TTN_NEEDTEXT** notification is sent to the tool tip control's parent window just before the tool tip window is displayed. If there is no handler for this message to assign some value to the `pszText` member of the **TOOLTIPTEXT** structure, there will be no text displayed for the tool tip.  
  
## Example  
 [!code[NVC_MFCWindowing#91](../vs140/codesnippet/CPP/cwnd--enabletooltips_1.cpp)]  
  
 [!code[NVC_MFCWindowing#92](../vs140/codesnippet/CPP/cwnd--enabletooltips_2.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::CancelToolTips](../vs140/cwnd--canceltooltips.md)   
 [CWnd::OnToolHitTest](../vs140/cwnd--ontoolhittest.md)   
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [TOOLINFO](http://msdn.microsoft.com/library/windows/desktop/bb760256)