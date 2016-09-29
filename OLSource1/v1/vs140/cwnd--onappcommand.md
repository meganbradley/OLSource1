---
title: "CWnd::OnAppCommand"
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
  - "CWnd::OnAppCommand"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWnd::OnAppCommand"
ms.assetid: d5a02b29-0baa-40d6-9f98-60117fe0e6c6
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnAppCommand
The framework calls this member function when the user generates an application command event. Such an event occurs when the user clicks an application command button or types an application command key.  
  
## Syntax  
  
```  
afx_msg void OnAppCommand(  
    CWnd* pWnd,  
    UINT nCmd,  
    UINT nDevice,  
    UINT nKey  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `pWnd`|Pointer to a [CWnd](../vs140/cwnd-class.md) object that represents the window where the user clicked the comman button or pressed the command key. This window can be a child window of the window receiving the message.|  
|[in] `nCmd`|Indicates the application command. For a list of possible values, see the commands under the *cmd* section of the `lParam` parameter of [WM_APPCOMMAND](http://msdn.microsoft.com/library/windows/desktop/ms646275).|  
|[in] `nDevice`|The input device that generated the input event. For a list of possible values, see the devices under the *uDevice* section of the `lParam` parameter of [WM_APPCOMMAND](http://msdn.microsoft.com/library/windows/desktop/ms646275).|  
|[in] `nKey`|Indicates any virtual keys that are down, such as the CTRL key or the left mouse button. For a list of possible values, see the keys under the *dwKeys* section of the `lParam` parameter of [WM_APPCOMMAND](http://msdn.microsoft.com/library/windows/desktop/ms646275). For more information, see the "Message Parameters" subheading in [About Mouse Input](http://msdn.microsoft.com/library/windows/desktop/ms645601).|  
  
## Remarks  
 This method receives the [WM_APPCOMMAND](http://msdn.microsoft.com/library/windows/desktop/ms646275) notification, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_APPCOMMAND](http://msdn.microsoft.com/library/windows/desktop/ms646275)