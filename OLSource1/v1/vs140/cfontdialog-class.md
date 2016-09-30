---
title: "CFontDialog Class"
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
  - "CFontDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFontDialog class"
  - "dialog boxes, fonts"
  - "fonts"
  - "fonts, selecting"
ms.assetid: 6228d500-ed0f-4156-81e5-ab0d57d1dcf4
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFontDialog Class
Allows you to incorporate a font-selection dialog box into your application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFontDialog::CFontDialog](#cfontdialog__cfontdialog)|Constructs a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFontDialog::DoModal](#cfontdialog__domodal)|Displays the dialog and allows the user to make a selection.|  
|[CFontDialog::GetCharFormat](#cfontdialog__getcharformat)|Retrieves the character formatting of the selected font.|  
|[CFontDialog::GetColor](#cfontdialog__getcolor)|Returns the color of the selected font.|  
|[CFontDialog::GetCurrentFont](#cfontdialog__getcurrentfont)|Assigns the characteristics of the currently selected font to a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> structure.|  
|[CFontDialog::GetFaceName](#cfontdialog__getfacename)|Returns the face name of the selected font.|  
|[CFontDialog::GetSize](#cfontdialog__getsize)|Returns the point size of the selected font.|  
|[CFontDialog::GetStyleName](#cfontdialog__getstylename)|Returns the style name of the selected font.|  
|[CFontDialog::GetWeight](#cfontdialog__getweight)|Returns the weight of the selected font.|  
|[CFontDialog::IsBold](#cfontdialog__isbold)|Determines whether the font is bold.|  
|[CFontDialog::IsItalic](#cfontdialog__isitalic)|Determines whether the font is italic.|  
|[CFontDialog::IsStrikeOut](#cfontdialog__isstrikeout)|Determines whether the font is displayed with strikeout.|  
|[CFontDialog::IsUnderline](#cfontdialog__isunderline)|Determines whether the font is underlined.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[CFontDialog::m_cf](#cfontdialog__m_cf)|A structure used to customize a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 A <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object is a dialog box with a list of fonts that are currently installed in the system. The user can select a particular font from the list, and this selection is then reported back to the application.  
  
 To construct a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object, use the provided constructor or derive a new subclass and use your own custom constructor.  
  
 Once a <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object has been constructed, you can use the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> structure to initialize the values or states of controls in the dialog box. The [m_cf](#cfontdialog__m_cf) structure is of type                 [CHOOSEFONT](http://msdn.microsoft.com/library/windows/desktop/ms646832). For more information on this structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 After initializing the dialog object's controls, call the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> member function to display the dialog box and allow the user to select a font. <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> returns whether the user selected the OK ( **IDOK**) or Cancel ( **IDCANCEL**) button.  
  
 If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> returns **IDOK**, you can use one of <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>'s member functions to retrieve the information input by the user.  
  
 You can use the Windows                 [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred during initialization of the dialog box and to learn more about the error. For more information on this function, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> relies on the COMMDLG.DLL file that ships with Windows versions 3.1 and later.  
  
 To customize the dialog box, derive a class from <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, provide a custom dialog template, and add a message-map to process the notification messages from the extended controls. Any unprocessed messages should be passed to the base class.  
  
 Customizing the hook function is not required.  
  
 For more information on using <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, see [Common Dialog Classes](../vs140/common-dialog-classes.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdlgs.h  
  
##  \<a name="cfontdialog__cfontdialog">\</a>  CFontDialog::CFontDialog  
 Constructs a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 l <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A pointer to a                                 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) data structure that allows you to set some of the font's characteristics.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A pointer to a                                 [CHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787881) data structure that allows you to set some of the font's characteristics in a rich edit control.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Specifies one or more choose-font flags. One or more preset values can be combined using the bitwise OR operator. If you modify the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>s structure member, be sure to use a bitwise OR operator in your changes to keep the default behavior intact. For details on each of these flags, see the description of the                                 [CHOOSEFONT](http://msdn.microsoft.com/library/windows/desktop/ms646832) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 pdcPrinter  
 A pointer to a printer-device context. If supplied, this parameter points to a printer-device context for the printer on which the fonts are to be selected.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A pointer to the font dialog box's parent or owner window.  
  
### Remarks  
 Note that the constructor automatically fills in the members of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> structure. You should only change these if you want a font dialog different than the default.  
  
> [!NOTE]
>  The first version of this function only exists when there is no rich edit control support.  
  
### Example  
 [!code[NVC_MFCDocView#78](../vs140/codesnippet/CPP/cfontdialog-class_1.cpp)]  
  
##  \<a name="cfontdialog__domodal">\</a>  CFontDialog::DoModal  
 Call this function to display the Windows common font dialog box and allow the user to choose a font.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 **IDOK** or **IDCANCEL**. If **IDCANCEL** is returned, call the Windows                         [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred.  
  
 **IDOK** and **IDCANCEL** are constants that indicate whether the user selected the OK or Cancel button.  
  
### Remarks  
 If you want to initialize the various font dialog controls by setting members of the [m_cf](#cfontdialog__m_cf) structure, you should do this before calling <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 If <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> returns **IDOK**, you can call other member functions to retrieve the settings or information input by the user into the dialog box.  
  
### Example  
  See the examples for [CFontDialog::CFontDialog](#cfontdialog__cfontdialog) and [CFontDialog::GetColor](#cfontdialog__getcolor).  
  
##  \<a name="cfontdialog__getcharformat">\</a>  CFontDialog::GetCharFormat  
 Retrieves the character formatting of the selected font.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 A                                 [CHARFORMAT](http://msdn.microsoft.com/library/windows/desktop/bb787881) structure containing information about the character formatting of the selected font.  
  
##  \<a name="cfontdialog__getcolor">\</a>  CFontDialog::GetColor  
 Call this function to retrieve the selected font color.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The color of the selected font.  
  
### Example  
 [!code[NVC_MFCDocView#79](../vs140/codesnippet/CPP/cfontdialog-class_2.cpp)]  
  
##  \<a name="cfontdialog__getcurrentfont">\</a>  CFontDialog::GetCurrentFont  
 Call this function to assign the characteristics of the currently selected font to the members of a                 [LOGFONT](http://msdn.microsoft.com/library/windows/desktop/dd145037) structure.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *lplf*  
 A pointer to a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> structure.  
  
### Remarks  
 Other <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> member functions are provided to access individual characteristics of the current font.  
  
 If this function is called during a call to [DoModal](#cfontdialog__domodal), it returns the current selection at the time (what the user sees or has changed in the dialog). If this function is called after a call to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> (only if <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> returns **IDOK**), it returns what the user actually selected.  
  
### Example  
 [!code[NVC_MFCDocView#80](../vs140/codesnippet/CPP/cfontdialog-class_3.cpp)]  
  
##  \<a name="cfontdialog__getfacename">\</a>  CFontDialog::GetFaceName  
 Call this function to retrieve the face name of the selected font.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The face name of the font selected in the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> dialog box.  
  
### Example  
 [!code[NVC_MFCDocView#81](../vs140/codesnippet/CPP/cfontdialog-class_4.cpp)]  
  
##  \<a name="cfontdialog__getsize">\</a>  CFontDialog::GetSize  
 Call this function to retrieve the size of the selected font.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The font's size, in tenths of a point.  
  
### Example  
 [!code[NVC_MFCDocView#82](../vs140/codesnippet/CPP/cfontdialog-class_5.cpp)]  
  
##  \<a name="cfontdialog__getstylename">\</a>  CFontDialog::GetStyleName  
 Call this function to retrieve the style name of the selected font.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The style name of the font.  
  
### Example  
 [!code[NVC_MFCDocView#83](../vs140/codesnippet/CPP/cfontdialog-class_6.cpp)]  
  
##  \<a name="cfontdialog__getweight">\</a>  CFontDialog::GetWeight  
 Call this function to retrieve the weight of the selected font.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The weight of the selected font.  
  
### Remarks  
 For more information on the weight of a font, see [CFont::CreateFont](../vs140/cfont-class.md#cfont__createfont).  
  
### Example  
 [!code[NVC_MFCDocView#84](../vs140/codesnippet/CPP/cfontdialog-class_7.cpp)]  
  
##  \<a name="cfontdialog__isbold">\</a>  CFontDialog::IsBold  
 Call this function to determine if the selected font is bold.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the selected font has the Bold characteristic enabled; otherwise 0.  
  
### Example  
 [!code[NVC_MFCDocView#85](../vs140/codesnippet/CPP/cfontdialog-class_8.cpp)]  
  
##  \<a name="cfontdialog__isitalic">\</a>  CFontDialog::IsItalic  
 Call this function to determine if the selected font is italic.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the selected font has the Italic characteristic enabled; otherwise 0.  
  
### Example  
 [!code[NVC_MFCDocView#86](../vs140/codesnippet/CPP/cfontdialog-class_9.cpp)]  
  
##  \<a name="cfontdialog__isstrikeout">\</a>  CFontDialog::IsStrikeOut  
 Call this function to determine if the selected font is displayed with strikeout.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the selected font has the Strikeout characteristic enabled; otherwise 0.  
  
### Example  
 [!code[NVC_MFCDocView#87](../vs140/codesnippet/CPP/cfontdialog-class_10.cpp)]  
  
##  \<a name="cfontdialog__isunderline">\</a>  CFontDialog::IsUnderline  
 Call this function to determine if the selected font is underlined.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 Nonzero if the selected font has the Underline characteristic enabled; otherwise 0.  
  
### Example  
 [!code[NVC_MFCDocView#88](../vs140/codesnippet/CPP/cfontdialog-class_11.cpp)]  
  
##  \<a name="cfontdialog__m_cf">\</a>  CFontDialog::m_cf  
 A structure whose members store the characteristics of the dialog object.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Remarks  
 After constructing a <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> object, you can use <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> to modify various aspects of the dialog box before calling the <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> member function. For more information on this structure, see                         [CHOOSEFONT](http://msdn.microsoft.com/library/windows/desktop/ms646832) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCDocView#89](../vs140/codesnippet/CPP/cfontdialog-class_12.cpp)]  
  
## See Also  
 [MFC Sample HIERSVR](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/ccommondialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)