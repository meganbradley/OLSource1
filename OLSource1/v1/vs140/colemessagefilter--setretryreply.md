---
title: "COleMessageFilter::SetRetryReply"
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
  - "COleMessageFilter.SetRetryReply"
  - "SetRetryReply"
  - "COleMessageFilter::SetRetryReply"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRetryReply method"
  - "COleMessageFilter class, operations"
ms.assetid: 72e50fa6-3622-47c5-bb38-74a5883e0276
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleMessageFilter::SetRetryReply
Determines the calling application's action when it receives a busy response from a called application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Number of milliseconds between retries.  
  
## Remarks  
 When a called application indicates that it is busy, the calling application may decide to wait until the server is no longer busy, to retry right away, or to retry after a specified interval. It may also decide to cancel the call altogether.  
  
 The caller's response is controlled by the functions <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and [SetMessagePendingDelay](../vs140/colemessagefilter--setmessagependingdelay.md). <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> determines how long the calling application should wait between retries for a given call. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> determines how long the calling application waits for a response from the server before taking further action.  
  
 Usually the defaults are acceptable and do not need to be changed. The framework retries the call every <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> milliseconds until the call goes through or the message-pending delay has expired. A value of 0 for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> specifies an immediate retry, and – 1 specifies cancellation of the call.  
  
 When the message-pending delay has expired, the OLE "busy dialog box" (see [COleBusyDialog](../vs140/colebusydialog-class.md)) is displayed so that the user can choose to cancel or retry the call. Call [EnableBusyDialog](../vs140/colemessagefilter--enablebusydialog.md) to enable or disable this dialog box.  
  
 When a keyboard or mouse message is pending during a call and the call has timed out (exceeded the message-pending delay), the "not responding" dialog box is displayed. Call [EnableNotRespondingDialog](../vs140/colemessagefilter--enablenotrespondingdialog.md) to enable or disable this dialog box. Usually this state of affairs indicates that something has gone wrong and the user is getting impatient.  
  
 When the dialogs are disabled, the current "retry reply" is always used for calls to busy applications.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleMessageFilter Class](../vs140/colemessagefilter-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleBusyDialog Class](../vs140/colebusydialog-class.md)   
 [COleMessageFilter::EnableNotRespondingDialog](../vs140/colemessagefilter--enablenotrespondingdialog.md)   
 [COleMessageFilter::EnableBusyDialog](../vs140/colemessagefilter--enablebusydialog.md)   
 [COleMessageFilter::SetMessagePendingDelay](../vs140/colemessagefilter--setmessagependingdelay.md)