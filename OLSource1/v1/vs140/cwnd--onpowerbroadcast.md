---
title: "CWnd::OnPowerBroadcast"
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
  - "CWnd::OnPowerBroadcast"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWnd::OnPowerBroadcast"
ms.assetid: e5a79a17-1aeb-41f8-9e06-76e8f4223b99
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnPowerBroadcast
The framework calls this member function when a power-management event occurs.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The power-management event.|  
|[in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Event-specific data.|  
  
## Return Value  
 If the event is a request, return <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to grant the request, or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to deny the request.  
  
## Remarks  
 This method receives the [WM_POWERBROADCAST](http://msdn.microsoft.com/library/windows/desktop/aa373247) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter specifies events such as battery power is low, the power status has changed, permission to suspend operation is requested or denied, an operation is resuming automatically after an event, the system is suspending operation, or an operation is resuming after suspension. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is typically not used. For more information, see the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameters of the [WM_POWERBROADCAST](http://msdn.microsoft.com/library/windows/desktop/aa373247) message.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_POWERBROADCAST](http://msdn.microsoft.com/library/windows/desktop/aa373247)