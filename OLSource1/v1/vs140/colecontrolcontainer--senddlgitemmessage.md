---
title: "COleControlContainer::SendDlgItemMessage"
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
  - COleControlContainer::SendDlgItemMessage
  - COleControlContainer.SendDlgItemMessage
dev_langs: 
  - C++
helpviewer_keywords: 
  - COleControlContainer class, overridables
  - SendDlgItemMessage method
ms.assetid: 2758e175-507f-4598-bc71-d9bfc4ba6f84
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControlContainer::SendDlgItemMessage
Sends a message to the specified control.  
  
## Syntax  
  
```  
  
      virtual LRESULT SendDlgItemMessage(  
   int nID,  
   UINT message,  
   WPARAM wParam,  
   LPARAM lParam   
);  
```  
  
#### Parameters  
 `nID`  
 Specifies the identifier of the control that receives the message.  
  
 `message`  
 Specifies the message to be sent.  
  
 `wParam`  
 Specifies additional message-specific information.  
  
 `lParam`  
 Specifies additional message-specific information.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)