---
title: "CFrameWnd::SetMenuBarVisibility"
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
  - "CFrameWnd::SetMenuBarVisibility"
  - "CFrameWnd.SetMenuBarVisibility"
  - "SetMenuBarVisibility"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMenuBarVisibility method"
ms.assetid: c7ec0613-019d-4b37-afaa-7cd183a4617d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWnd::SetMenuBarVisibility
Sets the default behavior of the menu in the current MFC application to be either hidden or visible.  
  
## Syntax  
  
```  
virtual void SetMenuBarVisibility(  
    DWORD nStyle  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|[in] `nStyle`|Specifies whether the menu is by default hidden, or is visible and has the focus. The `nStyle` parameter can have the following values:<br /><br /> -   AFX_MBV_KEEPVISIBLE (0x01) -<br />     The menu is displayed at all times, and by default does not have the focus.<br />-   AFX_MBV_DISPLAYONFOCUS (0x02) -<br />     The menu is hidden by default. If the menu is hidden, press the ALT key to display the menu and give it the focus. If the menu is displayed, press the ALT or ESC key to hide menu.<br />-   AFX_MBV_ DISPLAYONFOCUS (0x02) &#124; AFX_MBV_DISPLAYONF10 (0x04)<br />     (bitwise combination (OR)) - The menu is hidden by default. If the menu is hidden, press the F10 key to display the menu and give it the focus. If the menu is displayed, press the F10 key to toggle the focus on or off the menu. The menu is displayed until you press the ALT or ESC key to hide it.|  
  
## Remarks  
 If the value of the `nStyle` parameter is not valid, this method asserts in Debug mode and raises [CInvalidArgException](../vs140/cinvalidargexception-class.md) in Release mode. In case of other runtime errors, this method asserts in Debug mode and raises an exception derived from the [CException](../vs140/cexception-class.md) class.  
  
 This method affects the state of menus in applications written for [!INCLUDE[windowsver](../vs140/includes/windowsver_md.md)] and later.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CFrameWnd Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFrameWnd::GetMenuBarVisibility](../vs140/cframewnd--getmenubarvisibility.md)