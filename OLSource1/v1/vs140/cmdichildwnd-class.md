---
title: "CMDIChildWnd Class"
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
  - "CMDIChildWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MDI [C++], child windows"
  - "windows [C++], MDI"
  - "CMDIChildWnd class"
  - "child windows, CMDIChildWnd class"
ms.assetid: 6d07f5d4-9a3e-4723-9fa5-e65bb669fdd5
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIChildWnd Class
Provides the functionality of a Windows multiple document interface (MDI) child window, along with members for managing the window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMDIChildWnd::CMDIChildWnd](#cmdichildwnd__cmdichildwnd)|Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMDIChildWnd::Create](#cmdichildwnd__create)|Creates the Windows MDI child window associated with the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
|[CMDIChildWnd::GetMDIFrame](#cmdichildwnd__getmdiframe)|Returns the parent MDI frame of the MDI client window.|  
|[CMDIChildWnd::MDIActivate](#cmdichildwnd__mdiactivate)|Activates this MDI child window.|  
|[CMDIChildWnd::MDIDestroy](#cmdichildwnd__mdidestroy)|Destroys this MDI child window.|  
|[CMDIChildWnd::MDIMaximize](#cmdichildwnd__mdimaximize)|Maximizes this MDI child window.|  
|[CMDIChildWnd::MDIRestore](#cmdichildwnd__mdirestore)|Restores this MDI child window from maximized or minimized size.|  
|[CMDIChildWnd::SetHandles](#cmdichildwnd__sethandles)|Sets the handles for menu and accelerator resources.|  
  
## Remarks  
 An MDI child window looks much like a typical frame window, except that the MDI child window appears inside an MDI frame window rather than on the desktop. An MDI child window does not have a menu bar of its own, but instead shares the menu of the MDI frame window. The framework automatically changes the MDI frame menu to represent the currently active MDI child window.  
  
 To create a useful MDI child window for your application, derive a class from <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. Add member variables to the derived class to store data specific to your application. Implement message-handler member functions and a message map in the derived class to specify what happens when messages are directed to the window.  
  
 There are three ways to construct an MDI child window:  
  
-   Directly construct it using **Create**.  
  
-   Directly construct it using <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
-   Indirectly construct it through a document template.  
  
 Before you call **Create** or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, you must construct the frame-window object on the heap using the C++ **new** operator. Before calling **Create** you can also register a window class with the [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) global function to set the icon and class styles for the frame.  
  
 Use the **Create** member function to pass the frame's creation parameters as immediate arguments.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> requires fewer arguments than **Create**, and instead retrieves most of its default values from resources, including the frame's caption, icon, accelerator table, and menu. To be accessible by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, all these resources must have the same resource ID (for example, **IDR_MAINFRAME**).  
  
 When a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object contains views and documents, they are created indirectly by the framework instead of directly by the programmer. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object orchestrates the creation of the frame, the creation of the containing views, and the connection of the views to the appropriate document. The parameters of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> constructor specify the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> of the three classes involved (document, frame, and view). A <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object is used by the framework to dynamically create new frames when specified by the user (for example, by using the File New command or the MDI Window New command).  
  
 A frame-window class derived from <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> must be declared with <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> in order for the above <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> mechanism to work correctly.  
  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class inherits much of its default implementation from <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. For a detailed list of these features, please refer to the [CFrameWnd](../vs140/cframewnd-class.md) class description. The <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> class has the following additional features:  
  
-   In conjunction with the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> class, multiple <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> objects from the same document template share the same menu, saving Windows system resources.  
  
-   The currently active MDI child window menu entirely replaces the MDI frame window's menu, and the caption of the currently active MDI child window is added to the MDI frame window's caption. For further examples of MDI child window functions that are implemented in conjunction with an MDI frame window, see the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> class description.  
  
 Do not use the C++ **delete** operator to destroy a frame window. Use <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> instead. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> implementation of <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> will delete the C++ object when the window is destroyed. When the user closes the frame window, the default <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> handler will call <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
 For more information on <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, see [Frame Windows](../vs140/frame-windows.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CFrameWnd](../vs140/cframewnd-class.md)  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cmdichildwnd__cmdichildwnd">\</a>  CMDIChildWnd::CMDIChildWnd  
 Call to construct a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Call **Create** to create the visible window.  
  
### Example  
  See the example for [CMDIChildWnd::Create](#cmdichildwnd__create).  
  
##  \<a name="cmdichildwnd__create">\</a>  CMDIChildWnd::Create  
 Call this member function to create a Windows MDI child window and attach it to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Points to a null-terminated character string that names the Windows class (a                                 [WNDCLASS](http://msdn.microsoft.com/library/windows/desktop/ms633576) structure). The class name can be any name registered with the [AfxRegisterWndClass](../vs140/afxregisterwndclass.md) global function. Should be **NULL** for a standard <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Points to a null-terminated character string that represents the window name. Used as text for the title bar.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Specifies the window [style](../vs140/window-styles.md) attributes. The **WS_CHILD** style is required.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Contains the size and position of the window. The <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> value allows Windows to specify the size and position of the new <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Specifies the window's parent. If **NULL**, the main application window is used.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Specifies a [CCreateContext](../vs140/ccreatecontext-structure.md) structure. This parameter can be **NULL**.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The currently active MDI child frame window can determine the caption of the parent frame window. This feature is disabled by turning off the **FWS_ADDTOTITLE** style bit of the child frame window.  
  
 The framework calls this member function in response to a user command to create a child window, and the framework uses the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter to properly connect the child window to the application. When you call **Create**, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> can be **NULL**.  
  
### Example  
 Example 1:  
  
 [!code[NVC_MFCWindowing#7](../vs140/codesnippet/CPP/cmdichildwnd-class_1.cpp)]  
  
### Example  
 Example 2:  
  
 [!code[NVC_MFCWindowing#8](../vs140/codesnippet/CPP/cmdichildwnd-class_2.cpp)]  
  
 [!code[NVC_MFCWindowing#9](../vs140/codesnippet/CPP/cmdichildwnd-class_3.cpp)]  
  
##  \<a name="cmdichildwnd__getmdiframe">\</a>  CMDIChildWnd::GetMDIFrame  
 Call this function to return the MDI parent frame.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the MDI parent frame window.  
  
### Remarks  
 The frame returned is two parents removed from the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and is the parent of the window of type **MDICLIENT** that manages the <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object. Call the [GetParent](../vs140/cwnd-class.md#cwnd__getparent) member function to return the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> object's immediate **MDICLIENT** parent as a temporary <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> pointer.  
  
### Example  
  See the example for [CMDIFrameWnd::MDISetMenu](../vs140/cmdiframewnd-class.md#cmdiframewnd__mdisetmenu).  
  
##  \<a name="cmdichildwnd__mdiactivate">\</a>  CMDIChildWnd::MDIActivate  
 Call this member function to activate an MDI child window independently of the MDI frame window.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 When the frame becomes active, the child window that was last activated will be activated as well.  
  
### Example  
  See the example for [CMDIFrameWnd::GetWindowMenuPopup](../vs140/cmdiframewnd-class.md#cmdiframewnd__getwindowmenupopup).  
  
##  \<a name="cmdichildwnd__mdidestroy">\</a>  CMDIChildWnd::MDIDestroy  
 Call this member function to destroy an MDI child window.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 The member function removes the title of the child window from the frame window and deactivates the child window.  
  
### Example  
 [!code[NVC_MFCWindowing#10](../vs140/codesnippet/CPP/cmdichildwnd-class_4.cpp)]  
  
##  \<a name="cmdichildwnd__mdimaximize">\</a>  CMDIChildWnd::MDIMaximize  
 Call this member function to maximize an MDI child window.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 When a child window is maximized, Windows resizes it to make its client area fill the client area of the frame window. Windows places the child window's Control menu in the frame's menu bar so that the user can restore or close the child window and adds the title of the child window to the frame-window title.  
  
### Example  
 [!code[NVC_MFCWindowing#11](../vs140/codesnippet/CPP/cmdichildwnd-class_5.cpp)]  
  
##  \<a name="cmdichildwnd__mdirestore">\</a>  CMDIChildWnd::MDIRestore  
 Call this member function to restore an MDI child window from maximized or minimized size.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Example  
 [!code[NVC_MFCWindowing#12](../vs140/codesnippet/CPP/cmdichildwnd-class_6.cpp)]  
  
##  \<a name="cmdichildwnd__sethandles">\</a>  CMDIChildWnd::SetHandles  
 Sets the handles for menu and accelerator resources.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 The handle of a menu resource.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 The handle of an accelerator resource.  
  
### Remarks  
 Call this function to set the menu and accelerator resources used by the MDI child window object.  
  
## See Also  
 [MFC Sample MDI](../vs140/visual-c---samples.md)   
 [MFC Sample MDIDOCVW](../vs140/visual-c---samples.md)   
 [MFC Sample SNAPVW](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cframewnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd](../vs140/cwnd-class.md)   
 [CMDIFrameWnd](../vs140/cmdiframewnd-class.md)