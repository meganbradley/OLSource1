---
title: "Manipulating the Tool Tip Control"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CToolTipCtrl class, manipulating tool tip attributes"
  - "tool tips [C++], attributes"
ms.assetid: 3600afe5-712a-4b56-8456-96e85fe879af
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Manipulating the Tool Tip Control
Class `CToolTipCtrl` provides a group of member functions that control the various attributes of the `CToolTipCtrl` object and the tool tip window.  
  
 The initial, pop-up, and reshow durations for the tool tip windows can be set and retrieved with calls to [GetDelayTime](../vs140/ctooltipctrl--getdelaytime.md) and [SetDelayTime](../vs140/ctooltipctrl--setdelaytime.md).  
  
 Change the appearance of the tool tip windows with the following functions:  
  
-   [GetMargin](../vs140/ctooltipctrl--getmargin.md) and [SetMargin](../vs140/ctooltipctrl--setmargin.md) Retrieves and sets the width between the tool tip border and the tool tip text.  
  
-   [GetMaxTipWidth](../vs140/ctooltipctrl--getmaxtipwidth.md) and [SetMaxTipWidth](../vs140/ctooltipctrl--setmaxtipwidth.md) Retrieves and sets the maximum width of the tool tip window.  
  
-   [GetTipBkColor](../vs140/ctooltipctrl--gettipbkcolor.md) and [SetTipBkColor](../vs140/ctooltipctrl--settipbkcolor.md) Retrieves and sets the background color of the tool tip window.  
  
-   [GetTipTextColor](../vs140/ctooltipctrl--gettiptextcolor.md) and [SetTipTextColor](../vs140/ctooltipctrl--settiptextcolor.md) Retrieves and sets the text color of the tool tip window.  
  
 In order for the tool tip control to be notified of important messages, such as **WM_LBUTTONXXX** messages, you must relay the messages to your tool tip control. The best method for this relay is to make a call to [CToolTipCtrl::RelayEvent](../vs140/ctooltipctrl--relayevent.md), in the `PreTranslateMessage` function of the owner window. The following example illustrates one possible method (assuming the tool tip control is called `m_ToolTip`):  
  
 [!code[NVC_MFCControlLadenDialog#41](../vs140/codesnippet/CPP/manipulating-the-tool-tip-control_1.cpp)]  
  
 To immediately remove a tool tip window, call the [Pop](../vs140/ctooltipctrl--pop.md) member function.  
  
## See Also  
 [Using CToolTipCtrl](../vs140/using-ctooltipctrl.md)   
 [Controls (MFC)](../vs140/controls--mfc-.md)