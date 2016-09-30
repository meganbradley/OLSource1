---
title: "TN001: Window Class Registration"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.registration"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TN001"
  - "WNDCLASS"
  - "AfxRegisterClass function"
ms.assetid: 1abf678e-f220-4606-85e0-03df32f64c54
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN001: Window Class Registration
This note describes the MFC routines that register the special [WNDCLASS](http://msdn.microsoft.com/library/windows/desktop/ms633576)es needed by Microsoft Windows. Specific <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> attributes used by MFC and Windows are discussed.  
  
## The Problem  
 The attributes of a [CWnd](../vs140/cwnd-class.md) object, like an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> handle in Windows, are stored in two places: the window object and the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The name of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is passed to general window creation functions such as [CWnd::Create](../vs140/cwnd--create.md) and [CFrameWnd::Create](../vs140/cframewnd--create.md) in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter.  
  
 This <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must be registered through one of four means:  
  
-   Implicitly by using a MFC provided <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
-   Implicitly by subclassing a Windows control (or some other control).  
  
-   Explicitly by calling the MFC [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) or [AfxRegisterClass](../vs140/afxregisterclass.md).  
  
-   Explicitly by calling the Windows routine [RegisterClass](http://msdn.microsoft.com/library/windows/desktop/ms633586).  
  
## WNDCLASS Fields  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> structure consists of various fields that describe a window class. The following table shows the fields and specifies how they are used in an MFC application:  
  
|Field|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|window proc, must be an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|not used (should be zero)|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|not used (should be zero)|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|automatically filled with [AfxGetInstanceHandle](../vs140/afxgetinstancehandle.md)|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|icon for frame windows, see below|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|cursor for when mouse is over window, see below|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|background color, see below|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|not used (should be NULL)|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|class name, see below|  
  
## Provided WNDCLASSes  
 Earlier versions of MFC (before MFC 4.0), provided several predefined Window classes. These Window classes are no longer provided by default. Applications should use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> with the appropriate parameters.  
  
 If the application provides a resource with the specified resource ID (for example, AFX_IDI_STD_FRAME), MFC will use that resource. Otherwise it will use the default resource. For the icon, the standard application icon is used, and for the cursor, the standard arrow cursor is used.  
  
 Two icons support MDI applications with single document types: one icon for the main application, the other icon for iconic document/MDIChild windows. For multiple document types with different icons, you must register additional <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>es or use the [CFrameWnd::LoadFrame](../vs140/cframewnd--loadframe.md) function.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> will register a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> using the icon ID you specify as the first parameter and the following standard attributes:  
  
-   class style : CS_DBLCLKS &#124; CS_HREDRAW &#124; CS_VREDRAW;  
  
-   icon AFX_IDI_STD_FRAME  
  
-   arrow cursor  
  
-   COLOR_WINDOW background color  
  
 The values for background color and cursor for the [CMDIFrameWnd](../vs140/cmdiframewnd-class.md) are not used since the client area of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is completely covered by the **MDICLIENT** window. Microsoft does not encourage subclassing the **MDICLIENT** window so use the standard colors and cursor types when possible.  
  
## Subclassing and Superclassing Controls  
 If you subclass or superclass a Windows control (for example, [CButton](../vs140/cbutton-class.md)) then your class automatically gets the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> attributes provided in the Windows implementation of that control.  
  
## The AfxRegisterWndClass Function  
 MFC provides a helper function for registering a window class. Given a set of attributes (window class style, cursor, background brush, and icon), a synthetic name is generated, and the resulting window class is registered. For example,  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This function returns a temporary string of the generated registered window class name. For more information about this function, see [AfxRegisterWndClass](../vs140/afxregisterwndclass.md).  
  
 The returned string is a temporary pointer to a static string buffer. It is valid until the next call to <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. If you want to keep this string around, store it in a [CString](../vs140/using-cstring.md) variable, as in this example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> will throw a [CResourceException](../vs140/cresourceexception-class.md) if the window class failed to register (either because of bad parameters, or out of Windows memory).  
  
## The RegisterClass and AfxRegisterClass Functions  
 If you want to do anything more sophisticated than what <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> provides, you can call the Windows API <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> or the MFC function <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, [CFrameWnd](../vs140/cframewnd-class.md) and [CMDIChildWnd](../vs140/cmdichildwnd-class.md) <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> functions take a <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> string name for the window class as the first parameter. You can use any registered window class name, regardless of the method you used to register it.  
  
 It is important to use <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> (or <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>) in a DLL on Win32. Win32 does not automatically unregister classes registered by a DLL, so you must explicitly unregister classes when the DLL is terminated. By using <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> this is handled automatically for you. <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> maintains a list of unique classes registered by your DLL and will automatically unregister them when the DLL terminates. When you use <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> in a DLL, you must ensure that all classes are unregistered when the DLL is terminated (in your [DllMain](http://msdn.microsoft.com/library/windows/desktop/ms682583) function). Failure to do so might cause <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to fail unexpectedly when another client application tries to use your DLL.  
  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)