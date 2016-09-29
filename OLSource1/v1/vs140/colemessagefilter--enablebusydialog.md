---
title: "COleMessageFilter::EnableBusyDialog"
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
  - "EnableBusyDialog"
  - "COleMessageFilter::EnableBusyDialog"
  - "COleMessageFilter.EnableBusyDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleMessageFilter class, operations"
  - "EnableBusyDialog method"
ms.assetid: ee491d92-d85b-496a-96ba-88a16b0173b3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleMessageFilter::EnableBusyDialog
Enables and disables the busy dialog box, which is displayed when the message-pending delay expires (see [SetRetryReply](../vs140/colemessagefilter--setretryreply.md)) during an OLE call.  
  
## Syntax  
  
```  
  
      void EnableBusyDialog(  
   BOOL bEnableBusy = TRUE   
);  
```  
  
#### Parameters  
 *bEnableBusy*  
 Specifies whether the "busy" dialog box is enabled or disabled.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleMessageFilter Class](../vs140/colemessagefilter-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleMessageFilter::EnableNotRespondingDialog](../vs140/colemessagefilter--enablenotrespondingdialog.md)   
 [COleMessageFilter::BeginBusyState](../vs140/colemessagefilter--beginbusystate.md)   
 [COleMessageFilter::SetBusyReply](../vs140/colemessagefilter--setbusyreply.md)   
 [COleMessageFilter::SetRetryReply](../vs140/colemessagefilter--setretryreply.md)   
 [COleBusyDialog Class](../vs140/colebusydialog-class.md)