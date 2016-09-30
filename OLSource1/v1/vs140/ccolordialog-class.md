---
title: "CColorDialog Class"
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
  - "CColorDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "colors, dialog box"
  - "dialog boxes, colors"
  - "CColorDialog class"
ms.assetid: d013dc25-9290-4b5d-a97e-95ad7208e13b
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CColorDialog Class
Allows you to incorporate a color-selection dialog box into your application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CColorDialog::CColorDialog](#ccolordialog__ccolordialog)|Constructs a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CColorDialog::DoModal](#ccolordialog__domodal)|Displays a color dialog box and allows the user to make a selection.|  
|[CColorDialog::GetColor](#ccolordialog__getcolor)|Returns a **COLORREF** structure containing the values of the selected color.|  
|[CColorDialog::GetSavedCustomColors](#ccolordialog__getsavedcustomcolors)|Retrieves custom colors created by the user.|  
|[CColorDialog::SetCurrentColor](#ccolordialog__setcurrentcolor)|Forces the current color selection to the specified color.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CColorDialog::OnColorOK](#ccolordialog__oncolorok)|Override to validate the color entered into the dialog box.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CColorDialog::m_cc](#ccolordialog__m_cc)|A structure used to customize the settings of the dialog box.|  
  
## Remarks  
 A <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object is a dialog box with a list of colors that are defined for the display system. The user can select or create a particular color from the list, which is then reported back to the application when the dialog box exits.  
  
 To construct a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object, use the provided constructor or derive a new class and use your own custom constructor.  
  
 Once the dialog box has been constructed, you can set or modify any values in the [m_cc](#ccolordialog__m_cc) structure to initialize the values of the dialog box's controls. The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> structure is of type                 [CHOOSECOLOR](http://msdn.microsoft.com/library/windows/desktop/ms646830).  
  
 After initializing the dialog box's controls, call the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> member function to display the dialog box and allow the user to select a color. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> returns the user's selection of either the dialog box's OK ( **IDOK**) or Cancel ( **IDCANCEL**) button.  
  
 If <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns **IDOK**, you can use one of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>'s member functions to retrieve the information input by the user.  
  
 You can use the Windows                 [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred during initialization of the dialog box and to learn more about the error.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> relies on the COMMDLG.DLL file that ships with Windows versions 3.1 and later.  
  
 To customize the dialog box, derive a class from <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, provide a custom dialog template, and add a message map to process the notification messages from the extended controls. Any unprocessed messages should be passed to the base class.  
  
 Customizing the hook function is not required.  
  
> [!NOTE]
>  On some installations the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object will not display with a gray background if you have used the framework to make other <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> objects gray.  
  
 For more information on using <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, see [Common Dialog Classes](../vs140/common-dialog-classes.md)  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdlgs.h  
  
##  \<a name="ccolordialog__ccolordialog">\</a>  CColorDialog::CColorDialog  
 Constructs a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *clrInit*  
 The default color selection. If no value is specified, the default is RGB(0,0,0) (black).  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A set of flags that customize the function and appearance of the dialog box. For more information, see the                                 [CHOOSECOLOR](http://msdn.microsoft.com/library/windows/desktop/ms646830) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A pointer to the dialog box's parent or owner window.  
  
### Example  
 [!code[NVC_MFCDocView#49](../vs140/codesnippet/CPP/ccolordialog-class_1.cpp)]  
  
##  \<a name="ccolordialog__domodal">\</a>  CColorDialog::DoModal  
 Call this function to display the Windows common color dialog box and allow the user to select a color.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 **IDOK** or **IDCANCEL**. If **IDCANCEL** is returned, call the Windows                         [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred.  
  
 **IDOK** and **IDCANCEL** are constants that indicate whether the user selected the OK or Cancel button.  
  
### Remarks  
 If you want to initialize the various color dialog-box options by setting members of the [m_cc](#ccolordialog__m_cc) structure, you should do this before calling <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> but after the dialog-box object is constructed.  
  
 After calling <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, you can call other member functions to retrieve the settings or information input by the user into the dialog box.  
  
### Example  
  See the example for [CColorDialog::CColorDialog](#ccolordialog__ccolordialog).  
  
##  \<a name="ccolordialog__getcolor">\</a>  CColorDialog::GetColor  
 Call this function after calling <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to retrieve the information about the color the user selected.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A                         [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) value that contains the RGB information for the color selected in the color dialog box.  
  
### Example  
 [!code[NVC_MFCDocView#50](../vs140/codesnippet/CPP/ccolordialog-class_2.cpp)]  
  
##  \<a name="ccolordialog__getsavedcustomcolors">\</a>  CColorDialog::GetSavedCustomColors  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> objects permit the user, in addition to choosing colors, to define up to 16 custom colors.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to an array of 16 RGB color values that stores custom colors created by the user.  
  
### Remarks  
 The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> member function provides access to these colors. These colors can be retrieved after [DoModal](#ccolordialog__domodal) returns **IDOK**.  
  
 Each of the 16 RGB values in the returned array is initialized to RGB(255,255,255) (white). The custom colors chosen by the user are saved only between dialog box invocations within the application. If you wish to save these colors between invocations of the application, you must save them in some other manner, such as in an initialization (.INI) file.  
  
### Example  
 [!code[NVC_MFCDocView#51](../vs140/codesnippet/CPP/ccolordialog-class_3.cpp)]  
  
##  \<a name="ccolordialog__m_cc">\</a>  CColorDialog::m_cc  
 A structure of type                 [CHOOSECOLOR](http://msdn.microsoft.com/library/windows/desktop/ms646830), whose members store the characteristics and values of the dialog box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 After constructing a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object, you can use <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to set various aspects of the dialog box before calling the [DoModal](#ccolordialog__domodal) member function.  
  
### Example  
 [!code[NVC_MFCDocView#53](../vs140/codesnippet/CPP/ccolordialog-class_4.cpp)]  
  
##  \<a name="ccolordialog__oncolorok">\</a>  CColorDialog::OnColorOK  
 Override to validate the color entered into the dialog box.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the dialog box should not be dismissed; otherwise 0 to accept the color that was entered.  
  
### Remarks  
 Override this function only if you want to provide custom validation of the color the user selects in the color dialog box.  
  
 The user can select a color by one of the following two methods:  
  
-   Clicking a color on the color palette. The selected color's RGB values are then reflected in the appropriate RGB edit boxes.  
  
-   Entering values in the RGB edit boxes  
  
 Overriding <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> allows you to reject a color the user enters into a common color dialog box for any application-specific reason.  
  
 Normally, you do not need to use this function because the framework provides default validation of colors and displays a message box if an invalid color is entered.  
  
 You can call [SetCurrentColor](#ccolordialog__setcurrentcolor) from within <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to force a color selection. Once <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> has been fired (that is, the user clicks **OK** to accept the color change), you can call [GetColor](#ccolordialog__getcolor) to get the RGB value of the new color.  
  
### Example  
 [!code[NVC_MFCDocView#52](../vs140/codesnippet/CPP/ccolordialog-class_5.cpp)]  
  
##  \<a name="ccolordialog__setcurrentcolor">\</a>  CColorDialog::SetCurrentColor  
 Call this function after calling <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to force the current color selection to the color value specified in <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 An RGB color value.  
  
### Remarks  
 This function is called from within a message handler or <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>. The dialog box will automatically update the user's selection based on the value of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> parameter.  
  
### Example  
  See the example for [CColorDialog::OnColorOK](#ccolordialog__oncolorok).  
  
## See Also  
 [MFC Sample MDI](../vs140/visual-c---samples.md)   
 [MFC Sample DRAWCLI](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/ccommondialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)