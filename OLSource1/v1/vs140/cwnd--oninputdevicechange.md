---
title: "CWnd::OnInputDeviceChange"
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
  - CWnd::OnInputDeviceChange
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWnd::OnInputDeviceChange
ms.assetid: 96b275f1-c0cf-4320-8e57-a323ffc077d6
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnInputDeviceChange
The framework calls this member function when an I/O device is added or removed from the system.  
  
## Syntax  
  
```  
afx_msg void OnInputDeviceChange(  
    unsigned short uFlag  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `uFlag`|This flag can contain the following values:<br /><br /> -   `GIDC_ARRIVAL` - A new device has been added to the system.<br />-   `GIDC_REMOVAL` - A device has been removed from the system.|  
  
## Remarks  
 This method receives the [WM_INPUT_DEVICE_CHANGE](http://msdn.microsoft.com/library/windows/desktop/ms645591) notification, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. The is a generic input device message.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_INPUT_DEVICE_CHANGE](http://msdn.microsoft.com/library/windows/desktop/ms645591)