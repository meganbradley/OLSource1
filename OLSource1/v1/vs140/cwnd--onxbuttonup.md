---
title: "CWnd::OnXButtonUp"
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
  - "CWnd::OnButtonUp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWnd::OnXButtonUp"
ms.assetid: b83a3059-431d-4899-bc29-f5f73a6bb971
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWnd::OnXButtonUp
The framework calls this member function when the user releases XBUTTON1 or XBUTTON2 while the cursor is in the client area of a window.  
  
## Syntax  
  
```  
afx_msg void OnXButtonUp(  
    UINT nFlags,   
    UINT nButton,   
    CPoint point  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `nFlags`|A bitwise combination (OR) of flags that indicate which modifier keys are pressed. For example, the `MK_CONTROL` flag indicates that the CTRL key is pressed.|  
|[in] `nButton`|A value of `XBUTTON1` if the first Microsoft Intellimouse X button was double-clicked, or `XBUTTON2` if the second X button was double-clicked.|  
|[in] `point`|A [CPoint](../vs140/cpoint-class.md) object that specifies the *x* and *y* coordinates of the cursor relative to the upper-left corner of the client area.|  
  
## Remarks  
 This method receives the [WM_XBUTTONUP](http://msdn.microsoft.com/library/windows/desktop/ms646246) notification, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. If the mouse is not captured, the message is posted to the window beneath the cursor. Otherwise, the message is posted to the window that has captured the mouse.  
  
 The `nFlags` parameter can be a combination of modifier keys listed in the following table. For more information, see [About Mouse Input](http://msdn.microsoft.com/library/windows/desktop/ms645601).  
  
|Modifier Key|Description|  
|------------------|-----------------|  
|MK_CONTROL|The CTRL key is pressed.|  
|MK_LBUTTON|The left mouse button is pressed.|  
|MK_MBUTTON|The middle mouse button is pressed.|  
|MK_RBUTTON|The right mouse button is pressed.|  
|MK_SHIFT|The SHIFT key is pressed.|  
|MK_XBUTTON1|The XBUTTON1 mouse button of the Microsoft IntelliMouse is pressed.|  
|MK_XBUTTON2|The XBUTTON2 mouse button of the Microsoft IntelliMouse is pressed.|  
  
> [!NOTE]
>  This member function is called by the framework to allow your application to handle a Windows message. The parameters passed to your function reflect the parameters received by the framework when the message was received. If you call the base-class implementation of this function, that implementation will use the parameters originally passed with the message and not the parameters you supply to the function.  
  
## Requirements  
 **Header:** afxwin.h  
  
 This method is supported in [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
 Additional requirements for this method are described in [Build Requirements for Vista Common Controls](../vs140/build-requirements-for-windows-vista-common-controls.md).  
  
## See Also  
 [CWnd Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [WM_XBUTTONUP](http://msdn.microsoft.com/library/windows/desktop/ms646246)