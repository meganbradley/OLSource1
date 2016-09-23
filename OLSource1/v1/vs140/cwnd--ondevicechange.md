---
title: "CWnd::OnDeviceChange"
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
  - CWnd.OnDeviceChange
  - WM_DEVICECHANGE
  - OnDeviceChange
  - CWnd::OnDeviceChange
dev_langs: 
  - C++
helpviewer_keywords: 
  - devices, changing
  - OnDeviceChange method
  - WM_DEVICECHANGE
ms.assetid: 78ef17c3-51e9-4673-8717-25c3599b5523
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnDeviceChange
The framework calls this member function to notify an application or device driver of a change to the hardware configuration of a device or the computer.  
  
## Syntax  
  
```  
  
      afx_msg BOOL OnDeviceChange(   
   UINT nEventType,   
   DWORD_PTR dwData    
);  
```  
  
#### Parameters  
 *nEventType*  
 An event type. See the Remarks section for a description of the available values  
  
 `dwData`  
 The address of a structure that contains event-specific data. Its meaning depends on the given event.  
  
## Remarks  
 For devices that offer software-controllable features, such as ejection and locking, the operating system typically sends a **DBT_DEVICEREMOVEPENDING** message to let applications and device drivers end their use of the device gracefully.  
  
 If the operating system forcefully removes of a device, it may not send a **DBT_DEVICEQUERYREMOVE** message before doing so.  
  
 The *nEvent* parameter can be one of these values:  
  
-   [DBT_DEVICEARRIVAL](http://msdn.microsoft.com/library/windows/desktop/aa363205) A device has been inserted and is now available.  
  
-   [DBT_DEVICEQUERYREMOVE](http://msdn.microsoft.com/library/windows/desktop/aa363206) Permission to remove a device is requested. Any application can deny this request and cancel the removal.  
  
-   [DBT_DEVICEQUERYREMOVEFAILED](http://msdn.microsoft.com/library/windows/desktop/aa363207) Request to remove a device has been canceled.  
  
-   [DBT_DEVICEREMOVEPENDING](http://msdn.microsoft.com/library/windows/desktop/aa363209) Device is about to be removed. Cannot be denied.  
  
-   [DBT_DEVICEREMOVECOMPLETE](http://msdn.microsoft.com/library/windows/desktop/aa363208) Device has been removed.  
  
-   [DBT_DEVICETYPESPECIFIC](http://msdn.microsoft.com/library/windows/desktop/aa363210) Device-specific event.  
  
-   [DBT_CONFIGCHANGED](http://msdn.microsoft.com/library/windows/desktop/aa363203) Current configuration has changed.  
  
-   **DBT_DEVNODES_CHANGED** Device node has changed.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_DEVICECHANGE](http://msdn.microsoft.com/library/windows/desktop/aa363480)