---
title: "CWnd::OnSpoolerStatus"
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
  - "CWnd.OnSpoolerStatus"
  - "WM_SPOOLERSTATUS"
  - "OnSpoolerStatus"
  - "CWnd::OnSpoolerStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_SPOOLERSTATUS"
  - "OnSpoolerStatus method"
ms.assetid: 6634be21-a213-409a-8102-5887cae15525
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnSpoolerStatus
The framework calls this member function from Print Manager whenever a job is added to or removed from the Print Manager queue.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the **SP_JOBSTATUS** flag.  
  
 *nJobs*  
 Specifies the number of jobs remaining in the Print Manager queue.  
  
## Remarks  
 This call is for informational purposes only.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_SPOOLERSTATUS](http://msdn.microsoft.com/library/windows/desktop/dd145220)