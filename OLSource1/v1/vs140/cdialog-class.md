---
title: "CDialog Class"
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
  - "CDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "modal dialog boxes, creating"
  - "MFC dialog boxes, base class"
  - "modeless dialog boxes, creating"
  - "modeless dialog boxes, displaying"
  - "CDialog class"
ms.assetid: ca64b77e-2cd2-47e3-8eff-c2645ad578f9
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialog Class
The base class used for displaying dialog boxes on the screen.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDialog::CDialog](#cdialog__cdialog)|Constructs a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDialog::Create](#cdialog__create)|Initializes the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object. Creates a modeless dialog box and attaches it to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object.|  
|[CDialog::CreateIndirect](#cdialog__createindirect)|Creates a modeless dialog box from a dialog-box template in memory (not resource-based).|  
|[CDialog::DoModal](#cdialog__domodal)|Calls a modal dialog box and returns when done.|  
|[CDialog::EndDialog](#cdialog__enddialog)|Closes a modal dialog box.|  
|[CDialog::GetDefID](#cdialog__getdefid)|Gets the ID of the default pushbutton control for a dialog box.|  
|[CDialog::GotoDlgCtrl](#cdialog__gotodlgctrl)|Moves the focus to a specified dialog-box control in the dialog box.|  
|[CDialog::InitModalIndirect](#cdialog__initmodalindirect)|Creates a modal dialog box from a dialog-box template in memory (not resource-based). The parameters are stored until the function <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is called.|  
|[CDialog::MapDialogRect](#cdialog__mapdialogrect)|Converts the dialog-box units of a rectangle to screen units.|  
|[CDialog::NextDlgCtrl](#cdialog__nextdlgctrl)|Moves the focus to the next dialog-box control in the dialog box.|  
|[CDialog::OnInitDialog](#cdialog__oninitdialog)|Override to augment dialog-box initialization.|  
|[CDialog::OnSetFont](#cdialog__onsetfont)|Override to specify the font that a dialog-box control is to use when it draws text.|  
|[CDialog::PrevDlgCtrl](#cdialog__prevdlgctrl)|Moves the focus to the previous dialog-box control in the dialog box.|  
|[CDialog::SetDefID](#cdialog__setdefid)|Changes the default pushbutton control for a dialog box to a specified pushbutton.|  
|[CDialog::SetHelpID](#cdialog__sethelpid)|Sets a context-sensitive help ID for the dialog box.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDialog::OnCancel](#cdialog__oncancel)|Override to perform the Cancel button or ESC key action. The default closes the dialog box and **DoModal** returns **IDCANCEL**.|  
|[CDialog::OnOK](#cdialog__onok)|Override to perform the OK button action in a modal dialog box. The default closes the dialog box and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> returns **IDOK**.|  
  
## Remarks  
 Dialog boxes are of two types: modal and modeless. A modal dialog box must be closed by the user before the application continues. A modeless dialog box allows the user to display the dialog box and return to another task without canceling or removing the dialog box.  
  
 A <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object is a combination of a dialog template and a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>-derived class. Use the dialog editor to create the dialog template and store it in a resource, then use the Add Class wizard to create a class derived from <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 A dialog box, like any other window, receives messages from Windows. In a dialog box, you are particularly interested in handling notification messages from the dialog box's controls since that is how the user interacts with your dialog box. Use the Properties window to select which messages you wish to handle and it will add the appropriate message-map entries and message-handler member functions to the class for you. You only need to write application-specific code in the handler member functions.  
  
 If you prefer, you can always write message-map entries and member functions manually.  
  
 In all but the most trivial dialog box, you add member variables to your derived dialog class to store data entered in the dialog box's controls by the user or to display data for the user. You can use the Add Variable wizard to create member variables and associate them with controls. At the same time, you choose a variable type and permissible range of values for each variable. The code wizard adds the member variables to your derived dialog class.  
  
 A data map is generated to automatically handle the exchange of data between the member variables and the dialog box's controls. The data map provides functions that initialize the controls in the dialog box with the proper values, retrieve the data, and validate the data.  
  
 To create a modal dialog box, construct an object on the stack using the constructor for your derived dialog class and then call <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> to create the dialog window and its controls. If you wish to create a modeless dialog, call **Create** in the constructor of your dialog class.  
  
 You can also create a template in memory by using a                 [DLGTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms645394) data structure as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. After you construct a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object, call [CreateIndirect](#cdialog__createindirect) to create a modeless dialog box, or call [InitModalIndirect](#cdialog__initmodalindirect) and [DoModal](#cdialog__domodal) to create a modal dialog box.  
  
 The exchange and validation data map is written in an override of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> that is added to your new dialog class. See the [DoDataExchange](../vs140/cwnd-class.md#cwnd__dodataexchange) member function in <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> for more on the exchange and validation functionality.  
  
 Both the programmer and the framework call <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> indirectly through a call to [CWnd::UpdateData](../vs140/cwnd-class.md#cwnd__updatedata).  
  
 The framework calls <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> when the user clicks the OK button to close a modal dialog box. (The data is not retrieved if the Cancel button is clicked.) The default implementation of [OnInitDialog](#cdialog__oninitdialog) also calls <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> to set the initial values of the controls. You typically override <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to further initialize controls. <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> is called after all the dialog controls are created and just before the dialog box is displayed.  
  
 You can call <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> at any time during the execution of a modal or modeless dialog box.  
  
 If you develop a dialog box by hand, you add the necessary member variables to the derived dialog-box class yourself, and you add member functions to set or get these values.  
  
 A modal dialog box closes automatically when the user presses the OK or Cancel buttons or when your code calls the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> member function.  
  
 When you implement a modeless dialog box, always override the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> member function and call <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> from within it. Don't call the base class <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, because it calls <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, which will make the dialog box invisible but will not destroy it. You should also override <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> for modeless dialog boxes in order to delete **this**, since modeless dialog boxes are usually allocated with **new**. Modal dialog boxes are usually constructed on the frame and do not need <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> cleanup.  
  
 For more information on <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, see:  
  
-   [Dialog Boxes](../vs140/dialog-boxes.md)  
  
-   Knowledge Base article Q262954 : HOWTO: Create a Resizeable Dialog Box with Scroll Bars  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxwin.h  
  
##  \<a name="cdialog__cdialog">\</a>  CDialog::CDialog  
 To construct a resource-based modal dialog box, call either public form of the constructor.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 Contains a null-terminated string that is the name of a dialog-box template resource.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 Contains the ID number of a dialog-box template resource.  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type [CWnd](../vs140/cwnd-class.md)) to which the dialog object belongs. If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
### Remarks  
 One form of the constructor provides access to the dialog resource by template name. The other constructor provides access by template ID number, usually with an **IDD_** prefix (for example, IDD_DIALOG1).  
  
 To construct a modal dialog box from a template in memory, first invoke the parameterless, protected constructor and then call <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.  
  
 After you construct a modal dialog box with one of the above methods, call <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>.  
  
 To construct a modeless dialog box, use the protected form of the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> constructor. The constructor is protected because you must derive your own dialog-box class to implement a modeless dialog box. Construction of a modeless dialog box is a two-step process. First call the constructor; then call the **Create** member function to create a resource-based dialog box, or call <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to create the dialog box from a template in memory.  
  
##  \<a name="cdialog__create">\</a>  CDialog::Create  
 Call **Create** to create a modeless dialog box using a dialog-box template from a resource.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
 Contains a null-terminated string that is the name of a dialog-box template resource.  
  
 <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 Points to the parent window object (of type [CWnd](../vs140/cwnd-class.md)) to which the dialog object belongs. If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 Contains the ID number of a dialog-box template resource.  
  
### Return Value  
 Both forms return nonzero if dialog-box creation and initialization were successful; otherwise 0.  
  
### Remarks  
 You can put the call to **Create** inside the constructor or call it after the constructor is invoked.  
  
 Two forms of the **Create** member function are provided for access to the dialog-box template resource by either template name or template ID number (for example, IDD_DIALOG1).  
  
 For either form, pass a pointer to the parent window object. If <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> is **NULL**, the dialog box will be created with its parent or owner window set to the main application window.  
  
 The **Create** member function returns immediately after it creates the dialog box.  
  
 Use the **WS_VISIBLE** style in the dialog-box template if the dialog box should appear when the parent window is created. Otherwise, you must call <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. For further dialog-box styles and their application, see the                         [DLGTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms645394) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] and [Window Styles](../vs140/window-styles.md) in the                         *MFC Reference*.  
  
 Use the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> function to destroy a dialog box created by the **Create** function.  
  
### Example  
 [!code[NVC_MFCControlLadenDialog#62](../vs140/codesnippet/CPP/cdialog-class_1.cpp)]  
  
##  \<a name="cdialog__createindirect">\</a>  CDialog::CreateIndirect  
 Call this member function to create a modeless dialog box from a dialog-box template in memory.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
 Points to memory that contains a dialog-box template used to create the dialog box. This template is in the form of a                                 [DLGTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms645394) structure and control information, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Points to the dialog object's parent window object (of type [CWnd](../vs140/cwnd-class.md)). If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Points to a **DLGINIT** resource.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 Contains a handle to global memory containing a dialog-box template. This template is in the form of a **DLGTEMPLATE** structure and data for each control in the dialog box.  
  
### Return Value  
 Nonzero if the dialog box was created and initialized successfully; otherwise 0.  
  
### Remarks  
 The <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> member function returns immediately after it creates the dialog box.  
  
 Use the **WS_VISIBLE** style in the dialog-box template if the dialog box should appear when the parent window is created. Otherwise, you must call <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> to cause it to appear. For more information on how you can specify other dialog-box styles in the template, see the                         [DLGTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms645394) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 Use the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> function to destroy a dialog box created by the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> function.  
  
 Dialog boxes that contain ActiveX controls require additional information provided in a **DLGINIT** resource. For more information, see Knowledge Base article Q231591, " HOWTO: Use a Dialog Template to Create a MFC Dialog with an ActiveX Control." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at                         [http://support.microsoft.com](http://support.microsoft.com/).  
  
##  \<a name="cdialog__domodal">\</a>  CDialog::DoModal  
 Call this member function to invoke the modal dialog box and return the dialog-box result when done.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 An <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> value that specifies the value of the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> parameter that was passed to the [CDialog::EndDialog](#cdialog__enddialog) member function, which is used to close the dialog box. The return value is –1 if the function could not create the dialog box, or **IDABORT** if some other error occurred, in which case the [Output window](../vs140/output-window.md) will contain error information from                         [GetLastError](http://msdn.microsoft.com/library/windows/desktop/ms679360).  
  
### Remarks  
 This member function handles all interaction with the user while the dialog box is active. This is what makes the dialog box modal; that is, the user cannot interact with other windows until the dialog box is closed.  
  
 If the user clicks one of the pushbuttons in the dialog box, such as OK or Cancel, a message-handler member function, such as [OnOK](#cdialog__onok) or [OnCancel](#cdialog__oncancel), is called to attempt to close the dialog box. The default <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> member function will validate and update the dialog-box data and close the dialog box with result **IDOK**, and the default <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> member function will close the dialog box with result **IDCANCEL** without validating or updating the dialog-box data. You can override these message-handler functions to alter their behavior.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> is now called for modal dialog box message processing.  
  
### Example  
 [!code[NVC_MFCControlLadenDialog#63](../vs140/codesnippet/CPP/cdialog-class_2.cpp)]  
  
##  \<a name="cdialog__enddialog">\</a>  CDialog::EndDialog  
 Call this member function to terminate a modal dialog box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>  
 Contains the value to be returned from the dialog box to the caller of <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>.  
  
### Remarks  
 This member function returns <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> as the return value of <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>. You must use the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> function to complete processing whenever a modal dialog box is created.  
  
 You can call <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> at any time, even in [OnInitDialog](#cdialog__oninitdialog), in which case you should close the dialog box before it is shown or before the input focus is set.  
  
 <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> does not close the dialog box immediately. Instead, it sets a flag that directs the dialog box to close as soon as the current message handler returns.  
  
### Example  
 [!code[NVC_MFCControlLadenDialog#64](../vs140/codesnippet/CPP/cdialog-class_3.cpp)]  
  
 [!code[NVC_MFCControlLadenDialog#65](../vs140/codesnippet/CPP/cdialog-class_4.cpp)]  
  
##  \<a name="cdialog__getdefid">\</a>  CDialog::GetDefID  
 Call the <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> member function to get the ID of the default pushbutton control for a dialog box.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 A 32-bit value ( <CodeContentPlaceHolder>79\</CodeContentPlaceHolder>). If the default pushbutton has an ID value, the high-order word contains **DC_HASDEFID** and the low-order word contains the ID value. If the default pushbutton does not have an ID value, the return value is 0.  
  
### Remarks  
 This is usually an OK button.  
  
##  \<a name="cdialog__gotodlgctrl">\</a>  CDialog::GotoDlgCtrl  
 Moves the focus to the specified control in the dialog box.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>80\</CodeContentPlaceHolder>  
 Identifies the window (control) that is to receive the focus.  
  
### Remarks  
 To get a pointer to the control (child window) to pass as <CodeContentPlaceHolder>81\</CodeContentPlaceHolder>, call the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> member function, which returns a pointer to a [CWnd](../vs140/cwnd-class.md) object.  
  
### Example  
  See the example for [CWnd::GetDlgItem](../vs140/cwnd-class.md#cwnd__getdlgitem).  
  
##  \<a name="cdialog__initmodalindirect">\</a>  CDialog::InitModalIndirect  
 Call this member function to initialize a modal dialog object using a dialog-box template that you construct in memory.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>  
 Points to memory that contains a dialog-box template used to create the dialog box. This template is in the form of a                                 [DLGTEMPLATE](http://msdn.microsoft.com/library/windows/desktop/ms645394) structure and control information, as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>  
 Contains a handle to global memory containing a dialog-box template. This template is in the form of a **DLGTEMPLATE** structure and data for each control in the dialog box.  
  
 <CodeContentPlaceHolder>85\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type [CWnd](../vs140/cwnd-class.md)) to which the dialog object belongs. If it is **NULL**, the dialog object's parent window is set to the main application window.  
  
 <CodeContentPlaceHolder>86\</CodeContentPlaceHolder>  
 Points to a **DLGINIT** resource.  
  
### Return Value  
 Nonzero if the dialog object was created and initialized successfully; otherwise 0.  
  
### Remarks  
 To create a modal dialog box indirectly, first allocate a global block of memory and fill it with the dialog box template. Then call the empty <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> constructor to construct the dialog-box object. Next, call <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> to store your handle to the in-memory dialog-box template. The Windows dialog box is created and displayed later, when the [DoModal](#cdialog__domodal) member function is called.  
  
 Dialog boxes that contain ActiveX controls require additional information provided in a **DLGINIT** resource. For more information, see Knowledge Base article Q231591, " HOWTO: Use a Dialog Template to Create a MFC Dialog with an ActiveX Control." Knowledge Base articles are available in the MSDN Library Visual Studio documentation or at                         [http://support.microsoft.com](http://support.microsoft.com/).  
  
##  \<a name="cdialog__mapdialogrect">\</a>  CDialog::MapDialogRect  
 Call to convert the dialog-box units of a rectangle to screen units.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>89\</CodeContentPlaceHolder>  
 Points to a [RECT](../vs140/rect-structure.md) structure or [CRect](../vs140/crect-class.md) object that contains the dialog-box coordinates to be converted.  
  
### Remarks  
 Dialog-box units are stated in terms of the current dialog-box base unit derived from the average width and height of characters in the font used for dialog-box text. One horizontal unit is one-fourth of the dialog-box base-width unit, and one vertical unit is one-eighth of the dialog-box base height unit.  
  
 The **GetDialogBaseUnits** Windows function returns size information for the system font, but you can specify a different font for each dialog box if you use the **DS_SETFONT** style in the resource-definition file. The <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> Windows function uses the appropriate font for this dialog box.  
  
 The <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> member function replaces the dialog-box units in <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> with screen units (pixels) so that the rectangle can be used to create a dialog box or position a control within a box.  
  
##  \<a name="cdialog__nextdlgctrl">\</a>  CDialog::NextDlgCtrl  
 Moves the focus to the next control in the dialog box.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 If the focus is at the last control in the dialog box, it moves to the first control.  
  
##  \<a name="cdialog__oncancel">\</a>  CDialog::OnCancel  
 The framework calls this method when the user clicks **Cancel** or presses the ESC key in a modal or modeless dialog box.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 Override this method to perform actions (such as restoring old data) when a user closes the dialog box by clicking **Cancel** or hitting the ESC key. The default closes a modal dialog box by calling [EndDialog](#cdialog__enddialog) and causing [DoModal](#cdialog__domodal) to return IDCANCEL.  
  
 If you implement the **Cancel** button in a modeless dialog box, you must override the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> method and call [DestroyWindow](../vs140/cwnd-class.md#cwnd__destroywindow) inside it. Do not call the base-class method, because it calls <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>, which will make the dialog box invisible but not destroy it.  
  
> [!NOTE]
>  You cannot override this method when you use a <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> object in a program that is compiled under Windows XP. For more information about <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>, see [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
### Example  
 [!code[NVC_MFCControlLadenDialog#66](../vs140/codesnippet/CPP/cdialog-class_5.cpp)]  
  
##  \<a name="cdialog__oninitdialog">\</a>  CDialog::OnInitDialog  
 This method is called in response to the <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Specifies whether the application has set the input focus to one of the controls in the dialog box. If <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> returns nonzero, Windows sets the input focus to the default location, the first control in the dialog box. The application can return 0 only if it has explicitly set the input focus to one of the controls in the dialog box.  
  
### Remarks  
 Windows sends the <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> message to the dialog box during the [Create](#cdialog__create), [CreateIndirect](#cdialog__createindirect), or [DoModal](#cdialog__domodal) calls, which occur immediately before the dialog box is displayed.  
  
 Override this method if you want to perform special processing when the dialog box is initialized. In the overridden version, first call the base class <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> but ignore its return value. You will typically return <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> from your overridden method.  
  
 Windows calls the <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> function by using the standard global dialog-box procedure common to all Microsoft Foundation Class Library dialog boxes. It does not call this function through your message map, and therefore you do not need a message map entry for this method.  
  
> [!NOTE]
>  You cannot override this method when you use a <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> object in a program that is compiled under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]. For more information about changes to <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] see [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
### Example  
 [!code[NVC_MFCControlLadenDialog#67](../vs140/codesnippet/CPP/cdialog-class_6.cpp)]  
  
##  \<a name="cdialog__onok">\</a>  CDialog::OnOK  
 Called when the user clicks the **OK** button (the button with an ID of IDOK).  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Remarks  
 Override this method to perform actions when the **OK** button is activated. If the dialog box includes automatic data validation and exchange, the default implementation of this method validates the dialog box data and updates the appropriate variables in your application.  
  
 If you implement the **OK** button in a modeless dialog box, you must override the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> method and call [DestroyWindow](../vs140/cwnd-class.md#cwnd__destroywindow) inside it. Do not call the base-class method, because it calls [EndDialog](#cdialog__enddialog) which makes the dialog box invisible but does not destroy it.  
  
> [!NOTE]
>  You cannot override this method when you use a <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> object in a program that is compiled under Windows XP. For more information about <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, see [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
### Example  
 [!code[NVC_MFCControlLadenDialog#68](../vs140/codesnippet/CPP/cdialog-class_7.cpp)]  
  
##  \<a name="cdialog__onsetfont">\</a>  CDialog::OnSetFont  
 Specifies the font a dialog-box control will use when drawing text.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>  
 Specifies a pointer to the font that will be used as the default font for all controls in this dialog box.  
  
### Remarks  
 The dialog box will use the specified font as the default for all its controls.  
  
 The dialog editor typically sets the dialog-box font as part of the dialog-box template resource.  
  
> [!NOTE]
>  You cannot override this method when you use a <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> object in a program that is compiled under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]. For more information about changes to <CodeContentPlaceHolder>110\</CodeContentPlaceHolder> under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] see [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
##  \<a name="cdialog__prevdlgctrl">\</a>  CDialog::PrevDlgCtrl  
 Sets the focus to the previous control in the dialog box.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Remarks  
 If the focus is at the first control in the dialog box, it moves to the last control in the box.  
  
##  \<a name="cdialog__setdefid">\</a>  CDialog::SetDefID  
 Changes the default pushbutton control for a dialog box.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>  
 Specifies the ID of the pushbutton control that will become the default.  
  
##  \<a name="cdialog__sethelpid">\</a>  CDialog::SetHelpID  
 Sets a context-sensitive help ID for the dialog box.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 *nIDR*  
 Specifies the context-sensitive help ID.  
  
## See Also  
 [MFC Sample DLGCBR32](../vs140/visual-c---samples.md)   
 [MFC Sample DLGTEMPL](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/cwnd-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)