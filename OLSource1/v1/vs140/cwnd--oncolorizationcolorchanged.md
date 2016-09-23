---
title: "CWnd::OnColorizationColorChanged"
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
  - CWnd::OnColorizationColorChanged
dev_langs: 
  - C++
helpviewer_keywords: 
  - CWnd::OnColorizationColorChanged
ms.assetid: 60f05072-04e1-454e-8c40-f06ebf835098
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CWnd::OnColorizationColorChanged
The framework calls this member when the rendering policy for the nonclient area has changed.  
  
## Syntax  
  
```  
afx_msg void OnColorizationColorChanged(  
    DWORD dwColorizationColor,   
    BOOL bOpacity  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `dwColorizationColor`|Specifies the new colorization color.<br /><br /> The color format is a hexadecimal number of the form 0xAARRGGBB, where each of the four components ranges from 0x00 through 0xFF. The AA component is the alpha value, RR is the color red, GG is green, and BB is blue.|  
|[in] `bOpacity`|`true` if the new color is blended with opacity; `false` if it is not.|  
  
## Remarks  
 This method receives the [WM_DWMNCRENDERINGCHANGED](http://msdn.microsoft.com/library/windows/desktop/dd388198) notification message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_DWMNCRENDERINGCHANGED](http://msdn.microsoft.com/library/windows/desktop/dd388198)