---
title: "CMFCColorBar::ShowCommandMessageString"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CMFCColorBar::ShowCommandMessageString
  - ShowCommandMessageString
  - CMFCColorBar.ShowCommandMessageString
dev_langs: 
  - C++
helpviewer_keywords: 
  - ShowCommandMessageString method
ms.assetid: 481b65d7-a407-4cec-9c22-cab2cf9818be
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMFCColorBar::ShowCommandMessageString
Requests the frame window that owns the color bar control to update the message line in the status bar.  
  
## Syntax  
  
```  
virtual void ShowCommandMessageString(  
   UINT uiCmdId   
);  
```  
  
#### Parameters  
 [in] `uiCmdId`  
 A command ID. (This parameter is ignored.)  
  
## Remarks  
 This method sends the `WM_SETMESSAGESTRING` message to the owner of the color bar control.  
  
## Requirements  
 **Header:** afxcolorbar.h  
  
## See Also  
 [CMFCColorBar Class](../vs140/cmfccolorbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)