---
title: "CDC::CreateIC"
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
  - "CDC.CreateIC"
  - "CDC::CreateIC"
  - "CreateIC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, initialization"
  - "CreateIC method"
ms.assetid: ff5c8904-553a-4628-97b8-9fc3f5b07bf9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::CreateIC
Creates an information context for the specified device.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the filename (without extension) of the device driver (for example, "EPSON"). You can pass a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the name of the specific device to be supported (for example, "EPSON FX-80"). The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter is used if the module supports more than one device. You can pass a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Points to a null-terminated string that specifies the file or device name for the physical output medium (file or port). You can pass a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object for this parameter.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Points to device-specific initialization data for the device driver. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> parameter must be **NULL** if the device driver is to use the default initialization (if any) specified by the user through the Control Panel. See <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> for the data format for device-specific initialization.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The information context provides a fast way to get information about the device without creating a device context.  
  
 Device names follow these conventions: an ending colon (:) is recommended, but optional. Windows strips the terminating colon so that a device name ending with a colon is mapped to the same port as the same name without a colon. The driver and port names must not contain leading or trailing spaces. GDI output functions cannot be used with information contexts.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::CreateDC](../vs140/cdc--createdc.md)   
 [CreateIC](http://msdn.microsoft.com/library/windows/desktop/dd183505)   
 [CDC::DeleteDC](../vs140/cdc--deletedc.md)