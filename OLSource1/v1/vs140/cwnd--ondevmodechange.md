---
title: "CWnd::OnDevModeChange"
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
  - "WM_DEVMODECHANGE"
  - "CWnd::OnDevModeChange"
  - "OnDevModeChange"
  - "CWnd.OnDevModeChange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WM_DEVMODECHANGE"
  - "OnDevModeChange method"
ms.assetid: 532766ad-0e2f-4b76-9a79-e1cdcb7a580d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnDevModeChange
The framework calls this member function for all top-level `CWnd` objects when the user changes device-mode settings.  
  
## Syntax  
  
```  
  
      afx_msg void OnDevModeChange(  
   LPTSTR lpDeviceName   
);  
```  
  
#### Parameters  
 *lpDeviceName*  
 Points to the device name specified in the Windows initialization file, WIN.INI.  
  
## Remarks  
 Applications that handle the `WM_DEVMODECHANGE` message may reinitialize their device-mode settings. Applications that use the Windows **ExtDeviceMode** function to save and restore device settings typically do not process this function.  
  
 This function is not called when the user changes the default printer from Control Panel. In this case, the `OnWinIniChange` function is called.  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_DEVMODECHANGE](http://msdn.microsoft.com/library/windows/desktop/dd145209)