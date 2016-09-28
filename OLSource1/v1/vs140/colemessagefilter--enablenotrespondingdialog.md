---
title: "COleMessageFilter::EnableNotRespondingDialog"
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
  - "EnableNotRespondingDialog"
  - "COleMessageFilter.EnableNotRespondingDialog"
  - "COleMessageFilter::EnableNotRespondingDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleMessageFilter class, operations"
  - "EnableNotRespondingDialog method"
ms.assetid: 9b2f04ac-4e9d-41c8-83ba-c9b571ee835a
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleMessageFilter::EnableNotRespondingDialog
Enables and disables the "not responding" dialog box, which is displayed if a keyboard or mouse message is pending during an OLE call and the call has timed out.  
  
## Syntax  
  
```  
  
      void EnableNotRespondingDialog(  
   BOOL bEnableNotResponding = TRUE   
);  
```  
  
#### Parameters  
 *bEnableNotResponding*  
 Specifies whether the "not responding" dialog box is enabled or disabled.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleMessageFilter Class](../vs140/colemessagefilter-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleMessageFilter::EnableBusyDialog](../vs140/colemessagefilter--enablebusydialog.md)   
 [COleMessageFilter::BeginBusyState](../vs140/colemessagefilter--beginbusystate.md)   
 [COleMessageFilter::SetBusyReply](../vs140/colemessagefilter--setbusyreply.md)   
 [COleBusyDialog Class](../vs140/colebusydialog-class.md)