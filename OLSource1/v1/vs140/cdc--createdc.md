---
title: "CDC::CreateDC"
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
  - CreateDC
  - CDC::CreateDC
  - CDC.CreateDC
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, initialization
  - CreateDC method
ms.assetid: 24f3ed45-313c-48b3-87ee-645239c452cb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::CreateDC
Creates a device context for the specified device.  
  
## Syntax  
  
```  
  
      BOOL CreateDC(  
   LPCTSTR lpszDriverName,  
   LPCTSTR lpszDeviceName,  
   LPCTSTR lpszOutput,  
   const void* lpInitData   
);  
```  
  
#### Parameters  
 `lpszDriverName`  
 Points to a null-terminated string that specifies the filename (without extension) of the device driver (for example, "EPSON"). You can also pass a `CString` object for this parameter.  
  
 `lpszDeviceName`  
 Points to a null-terminated string that specifies the name of the specific device to be supported (for example, "EPSON FX-80"). The `lpszDeviceName` parameter is used if the module supports more than one device. You can also pass a `CString` object for this parameter.  
  
 `lpszOutput`  
 Points to a null-terminated string that specifies the file or device name for the physical output medium (file or output port). You can also pass a `CString` object for this parameter.  
  
 `lpInitData`  
 Points to a `DEVMODE` structure containing device-specific initialization data for the device driver. The Windows **DocumentProperties** function retrieves this structure filled in for a given device. The `lpInitData` parameter must be **NULL** if the device driver is to use the default initialization (if any) specified by the user through the Control Panel.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The PRINT.H header file is required if the [DEVMODE](http://msdn.microsoft.com/library/windows/desktop/dd183565) structure is used.  
  
 Device names follow these conventions: an ending colon (:) is recommended, but optional. Windows strips the terminating colon so that a device name ending with a colon is mapped to the same port as the same name without a colon. The driver and port names must not contain leading or trailing spaces. GDI output functions cannot be used with information contexts.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [DocumentProperties](http://msdn.microsoft.com/library/windows/desktop/dd183576)   
 [CreateDC](http://msdn.microsoft.com/library/windows/desktop/dd183490)   
 [CDC::DeleteDC](../vs140/cdc--deletedc.md)   
 [CDC::CreateIC](../vs140/cdc--createic.md)