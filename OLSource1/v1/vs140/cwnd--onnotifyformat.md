---
title: "CWnd::OnNotifyFormat"
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
  - "CWnd::OnNotifyFormat"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWnd::OnNotifyFormat"
ms.assetid: 09289222-ce3f-48fc-b3c9-b7f22873b9e8
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnNotifyFormat
The framework calls this member function to determine if the current window accepts ANSI or Unicode structures in the WM_NOTIFY notification message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|A pointer to a [CWnd](../vs140/cwnd-class.md) object that represents the window sending the [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583) message.\<br />\<br /> This parameter is the pointer to a control if the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or the pointer to the parent window of a control if <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|[in] <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|A command value that specializes the **WM_NOTIFY** message. The possible values are:\<br />\<br /> -   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> -\<br />     The message is a query to determine whether ANSI or Unicode structures should be used in **WM_NOTIFY** messages. This message is sent from a control to its parent window during the creation of a control, and in response to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> form of this message.\<br />-   <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> -\<br />     The message is a request for a control to send the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> form of this message to its parent window. This request is sent from the parent window, and asks the control to requery the parent about the type of structure to use in **WM_NOTIFY** messages. If the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter is <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, the return value is the result of the requery operation.|  
  
## Return Value  
  
|Return value|Meaning|  
|------------------|-------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|ANSI structures should be used in **WM_NOTIFY** messages sent by the control.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Unicode structures should be used in **WM_NOTIFY** messages sent by the control.|  
|0|An error occurred.|  
  
## Remarks  
 This method receives the [WM_NOTIFYFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb775584) notification, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. **WM_NOTIFY** messages are sent from a common control to its parent window, and from the parent window to the common control.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_NOTIFYFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb775584)   
 [WM_NOTIFY](http://msdn.microsoft.com/library/windows/desktop/bb775583)