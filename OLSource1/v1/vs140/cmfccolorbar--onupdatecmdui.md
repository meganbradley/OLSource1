---
title: "CMFCColorBar::OnUpdateCmdUI"
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
  - "CMFCColorBar.OnUpdateCmdUI"
  - "OnUpdateCmdUI"
  - "CMFCColorBar::OnUpdateCmdUI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnUpdateCmdUI method"
ms.assetid: 5e038c9a-fc7c-4943-875f-c08aebf96562
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorBar::OnUpdateCmdUI
Called by the framework to enable or disable a user-interface item of a color bar control before the item is displayed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a window that contains a user-interface item to update.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to disable the user-interface item if no handler is defined in a message map; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 When a user of your application clicks a user-interface item, the item must know whether it should be displayed as enabled or disabled. The target of the command message provides this information by implementing an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> command handler. Use this method to help process the command. For more information, see [CCmdUI Class](../vs140/ccmdui-class.md).  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CCmdUI Class](../vs140/ccmdui-class.md)