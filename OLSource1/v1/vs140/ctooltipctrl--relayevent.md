---
title: "CToolTipCtrl::RelayEvent"
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
  - "RelayEvent"
  - "CToolTipCtrl.RelayEvent"
  - "CToolTipCtrl::RelayEvent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RelayEvent method"
ms.assetid: 145b1413-1606-4f57-8c76-bee539a6f264
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::RelayEvent
Passes a mouse message to a tool tip control for processing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a [MSG](http://msdn.microsoft.com/library/windows/desktop/ms644958) structure that contains the message to relay.  
  
## Remarks  
 A tool tip control processes only the following messages, which are sent to it by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>:  
  
|WM_LBUTTONDOWN|WM_MOUSEMOVE|  
|---------------------|-------------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>||  
  
## Example  
 See the example for [CPropertySheet::GetTabControl](../vs140/cpropertysheet--gettabcontrol.md).  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::PreTranslateMessage](../vs140/cwnd--pretranslatemessage.md)   
 [CWinApp::PreTranslateMessage](../vs140/cwinapp--pretranslatemessage.md)