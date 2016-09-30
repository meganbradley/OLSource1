---
title: "COleMessageFilter::OnMessagePending"
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
  - "COleMessageFilter.OnMessagePending"
  - "COleMessageFilter::OnMessagePending"
  - "OnMessagePending"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMessagePending method"
  - "COleMessageFilter class, overridables"
ms.assetid: 0b912a69-9fd9-4ac3-accf-f8a1c2c407ad
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleMessageFilter::OnMessagePending
Called by the framework to process messages while an OLE call is in progress.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the pending message.  
  
## Return Value  
 Nonzero on success; otherwise 0.  
  
## Remarks  
 When a calling application is waiting for a call to be completed, the framework calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with a pointer to the pending message. By default, the framework dispatches <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> messages, so that window updates can occur during a call that is taking a long time.  
  
 You must register your message filter by means of a call to [Register](../vs140/colemessagefilter--register.md) before it can become active.  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [COleMessageFilter Class](../vs140/colemessagefilter-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleMessageFilter::Register](../vs140/colemessagefilter--register.md)   
 [AfxOleInit](../vs140/afxoleinit.md)   
 [CWinApp::InitInstance](../vs140/cwinapp--initinstance.md)