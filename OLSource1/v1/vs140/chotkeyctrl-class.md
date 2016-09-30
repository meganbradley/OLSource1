---
title: "CHotKeyCtrl Class"
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
  - "CHotKeyCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "hot key controls"
  - "CHotKeyCtrl class"
  - "Windows common controls [C++], CHotKeyCtrl"
ms.assetid: 896f9766-0718-4f58-aab2-20325e118ca6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CHotKeyCtrl Class
Provides the functionality of the Windows common hot key control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CHotKeyCtrl::CHotKeyCtrl](#chotkeyctrl__chotkeyctrl)|Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CHotKeyCtrl::Create](#chotkeyctrl__create)|Creates a hot key control and attaches it to a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
|[CHotKeyCtrl::CreateEx](#chotkeyctrl__createex)|Creates a hot key control with the specified Windows extended styles and attaches it to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|[CHotKeyCtrl::GetHotKey](#chotkeyctrl__gethotkey)|Retrieves the virtual key code and modifier flags of a hot key from a hot key control.|  
|[CHotKeyCtrl::GetHotKeyName](#chotkeyctrl__gethotkeyname)|Retrieves the key name, in the local character set, assigned to a hot key.|  
|[CHotKeyCtrl::GetKeyName](#chotkeyctrl__getkeyname)|Retrieves the key name, in the local character set, assigned to the specified virtual key code.|  
|[CHotKeyCtrl::SetHotKey](#chotkeyctrl__sethotkey)|Sets the hot key combination for a hot key control.|  
|[CHotKeyCtrl::SetRules](#chotkeyctrl__setrules)|Defines the invalid combinations and the default modifier combination for a hot key control.|  
  
## Remarks  
 A "hot key control" is a window that enables the user to create a hot key. A "hot key" is a key combination that the user can press to perform an action quickly. (For example, a user can create a hot key that activates a given window and brings it to the top of the Z order.) The hot key control displays the user's choices and ensures that the user selects a valid key combination.  
  
 This control (and therefore the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class) is available only to programs running under Windows 95/98 and Windows NT version 3.51 and later.  
  
 When the user has chosen a key combination, the application can retrieve the specified key combination from the control and use the **WM_SETHOTKEY** message to set up the hot key in the system. Whenever the user presses the hot key thereafter, from any part of the system, the window specified in the **WM_SETHOTKEY** message receives a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> message specifying **SC_HOTKEY**. This message activates the window that receives it. The hot key remains valid until the application that called **WM_SETHOTKEY** exits.  
  
 This mechanism is different from the hot key support that depends on the **WM_HOTKEY** message and the Windows                 [RegisterHotKey](http://msdn.microsoft.com/library/windows/desktop/ms646309) and                 [UnregisterHotKey](http://msdn.microsoft.com/library/windows/desktop/ms646327) functions.  
  
 For more information on using <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, see [Controls](../vs140/controls--mfc-.md) and [Using CHotKeyCtrl](../vs140/using-chotkeyctrl.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcmn.h  
  
##  \<a name="chotkeyctrl__chotkeyctrl">\</a>  CHotKeyCtrl::CHotKeyCtrl  
 Constructs a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="chotkeyctrl__create">\</a>  CHotKeyCtrl::Create  
 Creates a hot key control and attaches it to a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Specifies the hot key control's style. Apply any combination of control styles. See                                 [Common Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Specifies the hot key control's size and position. It can be either a [CRect](../vs140/crect-class.md) object or a [RECT](../vs140/rect-structure.md) structure.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Specifies the hot key control's parent window, usually a [CDialog](../vs140/cdialog-class.md). It must not be **NULL**.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Specifies the hot key control's ID.  
  
### Return Value  
 Nonzero, if initialization was successful; otherwise 0.  
  
### Remarks  
 You construct a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object in two steps. First, call the constructor and then call **Create**, which creates the hot key control and attaches it to the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object.  
  
 If you want to use extended windows styles with your control, call [CreateEx](#chotkeyctrl__createex) instead of **Create**.  
  
##  \<a name="chotkeyctrl__createex">\</a>  CHotKeyCtrl::CreateEx  
 Call this function to create a control (a child window) and associate it with the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Specifies the extended style of the control being created. For a list of extended Windows styles, see the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameter for                                 [CreateWindowEx](http://msdn.microsoft.com/library/windows/desktop/ms632680) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Specifies the hot key control's style. Apply any combination of control styles. For more information, see                                 [Common Control Styles](http://msdn.microsoft.com/library/windows/desktop/bb775498) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A reference to a                                 [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure describing the size and position of the window to be created, in client coordinates of <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A pointer to the window that is the control's parent.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The control's child-window ID.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 Use <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> instead of [Create](#chotkeyctrl__create) to apply extended Windows styles, specified by the Windows extended style preface **WS_EX_**.  
  
##  \<a name="chotkeyctrl__gethotkey">\</a>  CHotKeyCtrl::GetHotKey  
 Retrieves the virtual key code and modifier flags of a keyboard shortcut from a hot key control.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Virtual key code of the keyboard shortcut. For a list of standard virtual key codes, see Winuser.h.  
  
 [out] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A bitwise combination (OR) of flags that indicate the modifier keys in the keyboard shortcut.  
  
 The modifier flags are as follows:  
  
|Flag|Corresponding Key|  
|----------|-----------------------|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|ALT key|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|CTRL key|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|Extended key|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|SHIFT key|  
  
### Return Value  
 In the first overloaded method, a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> that contains the virtual key code and modifier flags. The low-order byte of the low-order word contains the virtual key code, the high-order byte of the low-order word contains the modifier flags, and the high-order word is zero.  
  
### Remarks  
 The virtual key code and the modifier keys together define the keyboard shortcut.  
  
##  \<a name="chotkeyctrl__gethotkeyname">\</a>  CHotKeyCtrl::GetHotKeyName  
 Call this member function to get the localized name of the hot key.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The localized name of the currently selected hot key. If there is no selected hot key, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> returns an empty string.  
  
### Remarks  
 The name that this member function returns comes from the keyboard driver. You can install a non-localized keyboard driver in a localized version of Windows, and vice versa.  
  
##  \<a name="chotkeyctrl__getkeyname">\</a>  CHotKeyCtrl::GetKeyName  
 Call this member function to get the localized name of the key assigned to a specified virtual key code.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 The virtual key code.  
  
 *fExtended*  
 If the virtual key code is an extended key, **TRUE**; otherwise **FALSE**.  
  
### Return Value  
 The localized name of the key specified by the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> parameter. If the key has no mapped name, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> returns an empty string.  
  
### Remarks  
 The key name that this function returns comes from the keyboard driver, so you can install a non-localized keyboard driver in a localized version of Windows, and vice versa.  
  
### Example  
  [!code[NVC_MFCControlLadenDialog#69](../vs140/codesnippet/CPP/chotkeyctrl-class_1.cpp)]  
  
##  \<a name="chotkeyctrl__sethotkey">\</a>  CHotKeyCtrl::SetHotKey  
 Sets the keyboard shortcut for a hot key control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 Virtual key code of the keyboard shortcut. For a list of standard virtual key codes, see Winuser.h.  
  
 [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A bitwise combination (OR) of flags that indicate the modifier keys in the keyboard shortcut.  
  
 The modifier flags are as follows:  
  
|Flag|Corresponding Key|  
|----------|-----------------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|ALT key|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|CTRL key|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Extended key|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|SHIFT key|  
  
### Remarks  
 The virtual key code and the modifier keys together define the keyboard shortcut.  
  
##  \<a name="chotkeyctrl__setrules">\</a>  CHotKeyCtrl::SetRules  
 Call this function to define the invalid combinations and the default modifier combination for a hot key control.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Array of flags that specifies invalid key combinations. It can be a combination of the following values:  
  
-   <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> ALT  
  
-   <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> CTRL  
  
-   <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> CTRL+ALT  
  
-   <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> Unmodified keys  
  
-   <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> SHIFT  
  
-   <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> SHIFT+ALT  
  
-   <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> SHIFT+CTRL  
  
-   <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> SHIFT+CTRL+ALT  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Array of flags that specifies the key combination to use when the user enters an invalid combination. For more information on the modifier flags, see [GetHotKey](#chotkeyctrl__gethotkey).  
  
### Remarks  
 When a user enters an invalid key combination, as defined by flags specified in <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, the system uses the OR operator to combine the keys entered by the user with the flags specified in <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. The resulting key combination is converted into a string and then displayed in the hot key control.  
  
## See Also  
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)