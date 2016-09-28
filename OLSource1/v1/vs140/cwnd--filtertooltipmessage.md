---
title: "CWnd::FilterToolTipMessage"
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
  - "CWnd.FilterToolTipMessage"
  - "FilterToolTipMessage"
  - "CWnd::FilterToolTipMessage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "FilterToolTipMessage method"
  - "displaying tool tip messages"
  - "CWnd class, tool tip functions"
  - "tool tips [C++], message display"
ms.assetid: fa9cc51b-307d-4bcc-be0c-33652d9c12eb
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::FilterToolTipMessage
Called by the framework to display tool tip messages.  
  
## Syntax  
  
```  
  
      void FilterToolTipMessage(  
   MSG* pMsg   
);  
```  
  
#### Parameters  
 `pMsg`  
 A pointer to the tool tip message.  
  
## Remarks  
 In most MFC applications this method is called by the framework from [PreTranslateMessage](../vs140/cwnd--pretranslatemessage.md) and [EnableToolTips](../vs140/cwnd--enabletooltips.md), and you do not need to call it yourself.  
  
 However, in certain applications, for example some ActiveX controls, these methods might not be invoked by the framework, and you will need to call FilterToolTipMessage yourself. For more information, see [Methods of Creating Tool Tips](../vs140/methods-of-creating-tool-tips.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::OnToolHitTest](../vs140/cwnd--ontoolhittest.md)