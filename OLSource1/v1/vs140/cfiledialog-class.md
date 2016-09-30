---
title: "CFileDialog Class"
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
  - "CFileDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileDialog class"
  - "common file dialog boxes"
  - "dialog boxes, common"
ms.assetid: fda4fd3c-08b8-4ce0-8e9d-7bab23f8c6c0
caps.latest.revision: 47
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFileDialog Class
Encapsulates the common dialog box that is used for file open or file save operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CFileDialog::CFileDialog](#cfiledialog__cfiledialog)|Constructs a <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFileDialog::AddCheckButton](#cfiledialog__addcheckbutton)|Adds a check button to the dialog.|  
|[CFileDialog::AddComboBox](#cfiledialog__addcombobox)|Adds a combo box to the dialog.|  
|[CFileDialog::AddControlItem](#cfiledialog__addcontrolitem)|Adds an item to a container control in the dialog.|  
|[CFileDialog::AddEditBox](#cfiledialog__addeditbox)|Adds an edit box to the dialog.|  
|[CFileDialog::AddMenu](#cfiledialog__addmenu)|Adds a menu to the dialog.|  
|[CFileDialog::AddPlace](#cfiledialog__addplace)|Overloaded. Adds a folder to the list of places available for the user to open or save items.|  
|[CFileDialog::AddPushButton](#cfiledialog__addpushbutton)|Adds a button to the dialog.|  
|[CFileDialog::AddRadioButtonList](#cfiledialog__addradiobuttonlist)|Adds an option button (also known as radio button) group to the dialog.|  
|[CFileDialog::AddSeparator](#cfiledialog__addseparator)|Adds a separator to the dialog.|  
|[CFileDialog::AddText](#cfiledialog__addtext)|Adds text content to the dialog.|  
|[CFileDialog::ApplyOFNToShellDialog](#cfiledialog__applyofntoshelldialog)|Updates the state of the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> to match the parameters and flags stored in the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> member variable.|  
|[CFileDialog::DoModal](#cfiledialog__domodal)|Displays the dialog box and enables the user to make a selection.|  
|[CFileDialog::EnableOpenDropDown](#cfiledialog__enableopendropdown)|Enables a drop-down list on the **Open** or **Save** button in the dialog.|  
|[CFileDialog::EndVisualGroup](#cfiledialog__endvisualgroup)|Stops the addition of elements to a visual group in the dialog.|  
|[CFileDialog::GetCheckButtonState](#cfiledialog__getcheckbuttonstate)|Gets the current state of a check button (check box) in the dialog.|  
|[CFileDialog::GetControlItemState](#cfiledialog__getcontrolitemstate)|Gets the current state of an item in a container control found in the dialog.|  
|[CFileDialog::GetControlState](#cfiledialog__getcontrolstate)|Gets the current visibility and enabled states of a given control.|  
|[CFileDialog::GetEditBoxText](#cfiledialog__geteditboxtext)|Gets the current text in an edit box control.|  
|[CFileDialog::GetFileExt](#cfiledialog__getfileext)|Returns the extension of the selected file.|  
|[CFileDialog::GetFileName](#cfiledialog__getfilename)|Returns the file name of the selected file.|  
|[CFileDialog::GetFileTitle](#cfiledialog__getfiletitle)|Returns the title of the selected file.|  
|[CFileDialog::GetFolderPath](#cfiledialog__getfolderpath)|Retrieves the path of the currently open folder or directory for an Explorer-style **Open** or **Save As** common dialog box.|  
|[CFileDialog::GetIFileDialogCustomize](#cfiledialog__getifiledialogcustomize)|Retrieves the internal COM object for a customized <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> object.|  
|[CFileDialog::GetIFileOpenDialog](#cfiledialog__getifileopendialog)|Retrieves the internal COM object for a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> that is used as an **Open** file dialog box.|  
|[CFileDialog::GetIFileSaveDialog](#cfiledialog__getifilesavedialog)|Retrieves the internal COM object for a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> that is used as a **Save** file dialog box.|  
|[CFileDialog::GetNextPathName](#cfiledialog__getnextpathname)|Returns the full path of the next selected file.|  
|[CFileDialog::GetOFN](#cfiledialog__getofn)|Retrieves the <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> structure of the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> object.|  
|[CFileDialog::GetPathName](#cfiledialog__getpathname)|Returns the full path of the selected file.|  
|[CFileDialog::GetReadOnlyPref](#cfiledialog__getreadonlypref)|Returns the read-only status of the selected file.|  
|[CFileDialog::GetResult](#cfiledialog__getresult)|Gets the choice that the user made in the dialog.|  
|[CFileDialog::GetResults](#cfiledialog__getresults)|Gets the user's choices in a dialog that allows multiple selection.|  
|[CFileDialog::GetSelectedControlItem](#cfiledialog__getselectedcontrolitem)|Gets a particular item from specified container controls in the dialog.|  
|[CFileDialog::GetStartPosition](#cfiledialog__getstartposition)|Returns the position of the first element of the file name list.|  
|[CFileDialog::HideControl](#cfiledialog__hidecontrol)|Hides the specified control in an Explorer-style **Open** or **Save As** common dialog box.|  
|[CFileDialog::IsPickFoldersMode](#cfiledialog__ispickfoldersmode)|Determines if the current dialog in folder picker mode.|  
|[CFileDialog::MakeProminent](#cfiledialog__makeprominent)|Places a control in the dialog so that it stands out compared to other added controls.|  
|[CFileDialog::RemoveControlItem](#cfiledialog__removecontrolitem)|Removes an item from a container control in the dialog.|  
|[CFileDialog::SetCheckButtonState](#cfiledialog__setcheckbuttonstate)|Sets the current state of a check button (check box) in the dialog.|  
|[CFileDialog::SetControlItemState](#cfiledialog__setcontrolitemstate)|Sets the current state of an item in a container control found in the dialog.|  
|[CFileDialog::SetControlItemText](#cfiledialog__setcontrolitemtext)|Sets the text of a control item. For example, the text that accompanies a radio button or an item in a menu.|  
|[CFileDialog::SetControlLabel](#cfiledialog__setcontrollabel)|Sets the text associated with a control, such as button text or an edit box label.|  
|[CFileDialog::SetControlState](#cfiledialog__setcontrolstate)|Sets the current visibility and enabled states of a given control.|  
|[CFileDialog::SetControlText](#cfiledialog__setcontroltext)|Sets the text for the specified control in an Explorer-style **Open** or **Save As** common dialog box.|  
|[CFileDialog::SetDefExt](#cfiledialog__setdefext)|Sets the default file name extension for an Explorer-style **Open** or **Save As** common dialog box.|  
|[CFileDialog::SetEditBoxText](#cfiledialog__seteditboxtext)|Sets the current text in an edit box control.|  
|[CFileDialog::SetProperties](#cfiledialog__setproperties)|Provides a property store that defines the default values to be used for the item being saved.|  
|[CFileDialog::SetSelectedControlItem](#cfiledialog__setselectedcontrolitem)|Sets the selected state of a particular item in an option button group or a combo box found in the dialog.|  
|[CFileDialog::SetTemplate](#cfiledialog__settemplate)|Sets the dialog box template for the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> object.|  
|[CFileDialog::StartVisualGroup](#cfiledialog__startvisualgroup)|Declares a visual group in the dialog. Subsequent calls to any "add" method add those elements to this group.|  
|[CFileDialog::UpdateOFNFromShellDialog](#cfiledialog__updateofnfromshelldialog)|Updates the data stored in the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> member variable to match the current state of the file dialog box.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CFileDialog::OnButtonClicked](#cfiledialog__onbuttonclicked)|Called when the button is clicked.|  
|[CFileDialog::OnCheckButtonToggled](#cfiledialog__oncheckbuttontoggled)|Called when the check box is checked/unchecked.|  
|[CFileDialog::OnControlActivating](#cfiledialog__oncontrolactivating)|Called when the control is being active.|  
|[CFileDialog::OnFileNameChange](#cfiledialog__onfilenamechange)|Handles the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> message.|  
|[CFileDialog::OnFileNameOK](#cfiledialog__onfilenameok)|Validates the file name entered in the dialog box.|  
|[CFileDialog::OnFolderChange](#cfiledialog__onfolderchange)|Handles the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> message.|  
|[CFileDialog::OnInitDone](#cfiledialog__oninitdone)|Handles the <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> message.|  
|[CFileDialog::OnItemSelected](#cfiledialog__onitemselected)|Called when the container item is being selected.|  
|[CFileDialog::OnLBSelChangedNotify](#cfiledialog__onlbselchangednotify)|Allows you to perform custom actions when the file selection changes.|  
|[CFileDialog::OnShareViolation](#cfiledialog__onshareviolation)|Handles share violations.|  
|[CFileDialog::OnTypeChange](#cfiledialog__ontypechange)|Handles the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> message.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[m_ofn](#cfiledialog__m_ofn)|The Windows <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> structure. Provides access to basic file dialog box parameters.|  
  
## Remarks  
 Common file dialog boxes let you implement file-selection dialog boxes, for example, **Open File** and **Save As**, in a manner that is consistent with Windows standards.  
  
 You can use [CFileDialog](../vs140/cfiledialog-class.md) as is with the constructor provided, or you can derive your own dialog box class from <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> and write a constructor to suit your needs. In either case, these dialog boxes will behave like standard MFC dialog boxes because they are derived from the [CCommonDialog Class](../vs140/ccommondialog-class.md). <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> relies on the COMMDLG.DLL file that is included in Windows.  
  
 Both the appearance and the functionality of the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> with [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] differ from the earlier versions of Windows. The default <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> automatically uses the new [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style without code changes if a program is compiled and run under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]. Use the <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> parameter in the constructor to manually override this automatic update. The exception to the automatic update is customized dialog boxes. They will not be converted to the new style. For more information about the constructor, see [CFileDialog::CFileDialog](#cfiledialog__cfiledialog).  
  
> [!NOTE]
>  The control ID system differs in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] from earlier versions of Windows when you use a <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>. You must update all references to <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> controls in code before you can port your project from an earlier version of Windows.  
  
 Some <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> methods are not supported under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]. Check the individual method topic for information about whether the method is supported. In addition, the following inherited functions are not supported under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]:  
  
-   [CDialog::OnInitDialog](../vs140/cdialog-class.md#cdialog__oninitdialog)  
  
-   [CDialog::OnSetFont](../vs140/cdialog-class.md#cdialog__onsetfont)  
  
 The windows messages for the <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> class vary based on what operating system you are using. For example, Windows XP does not support [CDialog::OnCancel](../vs140/cdialog-class.md#cdialog__oncancel) and [CDialog::OnOK](../vs140/cdialog-class.md#cdialog__onok) for the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> class. However, [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] does support them. For more information about the different messages that are generated and the order in which they are received, see [CFileDialog Sample: Logging Event Order](../vs140/visual-c---samples.md).  
  
 To use a <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> object, first create the object by using the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> constructor. After the dialog box has been constructed, you can set or modify any values in the [CFileDialog::m_ofn](#cfiledialog__m_ofn) structure to initialize the values or states of the dialog box controls. The <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> structure is of type <CodeContentPlaceHolder>91\</CodeContentPlaceHolder>. For more information, see the                 [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 After you initialize the dialog box controls, call the [CFileDialog::DoModal](#cfiledialog__domodal) method to display the dialog box so that the user can type the path and file name. <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> returns whether the user clicked the OK (IDOK) or the Cancel (IDCANCEL) button. If <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> returns IDOK, you can use one of the <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> public member functions to retrieve the information put in by the user.  
  
> [!NOTE]
>  Under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], multiple calls to                     [IFileDialog::SetFileTypes](http://msdn.microsoft.com/library/windows/desktop/bb775980) causes an error. The second call to <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> for any instance of a <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> will return <CodeContentPlaceHolder>97\</CodeContentPlaceHolder> in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]. Some <CodeContentPlaceHolder>98\</CodeContentPlaceHolder> method functions call <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>. For example, two calls to <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> for the same instance of a <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> generates [ASSERT](../vs140/assert--mfc-.md).  
  
 <CodeContentPlaceHolder>102\</CodeContentPlaceHolder> includes several protected members that let you do custom handling of share violations, file name validation, and list-box change notification. These protected members are callback functions that most applications do not have to use because default handling is performed automatically. Message-map entries for these functions are not required because they are standard virtual functions.  
  
 You can use the Windows                 [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred during initialization of the dialog box and to learn more about the error.  
  
 The destruction of <CodeContentPlaceHolder>103\</CodeContentPlaceHolder> objects is handled automatically. You do not have to call [CDialog::EndDialog](../vs140/cdialog-class.md#cdialog__enddialog).  
  
 To let the user select multiple files, set the <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> flag before you call <CodeContentPlaceHolder>105\</CodeContentPlaceHolder>. You must supply your own file name buffer to accommodate the returned list of multiple file names. Do this by replacing <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> with a pointer to a buffer you have allocated, after you construct the <CodeContentPlaceHolder>107\</CodeContentPlaceHolder>, but before you call <CodeContentPlaceHolder>108\</CodeContentPlaceHolder>.  
  
 Additionally, you must set <CodeContentPlaceHolder>109\</CodeContentPlaceHolder> by using the number of characters in the buffer pointed to by <CodeContentPlaceHolder>110\</CodeContentPlaceHolder>. If you set the maximum number of files to be selected to <CodeContentPlaceHolder>111\</CodeContentPlaceHolder>, the required buffer size is <CodeContentPlaceHolder>112\</CodeContentPlaceHolder>. The first item returned in the buffer is the path to the folder where the files were selected. For [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]-style dialog boxes, the directory and file name strings are null-terminated, with an extra null character after the last file name. This format enables the Explorer-style dialog boxes to return long file names that include spaces. For old-style dialog boxes, the directory and file name strings are separated by spaces and the function uses short file names for file names with spaces.  
  
 The following example demonstrates how to use a buffer to retrieve and list multiple file names.  
  
 [!code[NVC_MFCFiles#23](../vs140/codesnippet/CPP/cfiledialog-class_1.cpp)]  
  
 To change the buffer size in response to the user selecting multiple file names, you must derive a new class from <CodeContentPlaceHolder>113\</CodeContentPlaceHolder> and override the [OnFileNameChange](#cfiledialog__onfilenamechange) method.  
  
 If you derive a new class from <CodeContentPlaceHolder>114\</CodeContentPlaceHolder>, you can use a message map to handle any messages. To extend the default message handling, derive a class from <CodeContentPlaceHolder>115\</CodeContentPlaceHolder>, add a message map to the new class, and provide member functions for the new messages. You do not have to provide a hook function to customize the dialog box.  
  
 To customize the dialog box, derive a class from <CodeContentPlaceHolder>116\</CodeContentPlaceHolder>, provide a custom dialog box template, and add a message map to process the notification messages from the extended controls. Pass any unprocessed messages to the base class. You do not have to customize the hook function.  
  
 When you are using the [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style of the <CodeContentPlaceHolder>117\</CodeContentPlaceHolder>, you cannot use message maps and dialog box templates. Instead, you must use the COM interfaces for similar functionality.  
  
 For more information about how to use <CodeContentPlaceHolder>118\</CodeContentPlaceHolder>, see [Common Dialog Classes](../vs140/common-dialog-classes.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 <CodeContentPlaceHolder>119\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxdlgs.h  
  
##  \<a name="cfiledialog__addcheckbutton">\</a>  CFileDialog::AddCheckButton  
 Adds a check button to the dialog.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>120\</CodeContentPlaceHolder>  
 The ID of the check button to add.  
  
 <CodeContentPlaceHolder>121\</CodeContentPlaceHolder>  
 The check button name.  
  
 <CodeContentPlaceHolder>122\</CodeContentPlaceHolder>  
 A Boolean indicating the current state of the check button. <CodeContentPlaceHolder>123\</CodeContentPlaceHolder> if checked; <CodeContentPlaceHolder>124\</CodeContentPlaceHolder> otherwise  
  
### Remarks  
  
##  \<a name="cfiledialog__addcombobox">\</a>  CFileDialog::AddComboBox  
 Adds a combo box to the dialog.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>125\</CodeContentPlaceHolder>  
 The ID of the combo box to add.  
  
### Remarks  
  
##  \<a name="cfiledialog__addcontrolitem">\</a>  CFileDialog::AddControlItem  
 Adds an item to a container control in the dialog.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>126\</CodeContentPlaceHolder>  
 The ID of the container control to add the item to.  
  
 <CodeContentPlaceHolder>127\</CodeContentPlaceHolder>  
 The ID of the item.  
  
 <CodeContentPlaceHolder>128\</CodeContentPlaceHolder>  
 Item's text.  
  
### Remarks  
  
##  \<a name="cfiledialog__addeditbox">\</a>  CFileDialog::AddEditBox  
 Adds an edit box to the dialog.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>129\</CodeContentPlaceHolder>  
 The ID of the edit box to add.  
  
 <CodeContentPlaceHolder>130\</CodeContentPlaceHolder>  
 The edit box name.  
  
### Remarks  
  
##  \<a name="cfiledialog__addmenu">\</a>  CFileDialog::AddMenu  
 Adds a menu to the dialog.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>131\</CodeContentPlaceHolder>  
 The ID of the menu to add.  
  
 <CodeContentPlaceHolder>132\</CodeContentPlaceHolder>  
 The menu name.  
  
### Remarks  
  
##  \<a name="cfiledialog__addplace">\</a>  CFileDialog::AddPlace  
 Adds a folder to the list of places available for the user to open or save items.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>133\</CodeContentPlaceHolder>  
 A path to the folder to be made available to the user. This can only be a folder.  
  
 <CodeContentPlaceHolder>134\</CodeContentPlaceHolder>  
 Specifies where the folder is placed within the list.  
  
 <CodeContentPlaceHolder>135\</CodeContentPlaceHolder>  
 A pointer to an IShellItem that represents the folder to be made available to the user. This can only be a folder.  
  
### Remarks  
  
##  \<a name="cfiledialog__addpushbutton">\</a>  CFileDialog::AddPushButton  
 Adds a button to the dialog.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>136\</CodeContentPlaceHolder>  
 The ID of the button to add.  
  
 <CodeContentPlaceHolder>137\</CodeContentPlaceHolder>  
 The button name.  
  
### Remarks  
  
##  \<a name="cfiledialog__addradiobuttonlist">\</a>  CFileDialog::AddRadioButtonList  
 Adds an option button (also known as radio button) group to the dialog.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>138\</CodeContentPlaceHolder>  
 The ID of the option button group to add.  
  
### Remarks  
  
##  \<a name="cfiledialog__addseparator">\</a>  CFileDialog::AddSeparator  
 Adds a separator to the dialog.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>139\</CodeContentPlaceHolder>  
 The ID of the separator add.  
  
### Remarks  
  
##  \<a name="cfiledialog__addtext">\</a>  CFileDialog::AddText  
 Adds text to the dialog.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>140\</CodeContentPlaceHolder>  
 The ID of the text to add.  
  
 <CodeContentPlaceHolder>141\</CodeContentPlaceHolder>  
 The text name.  
  
### Remarks  
  
##  \<a name="cfiledialog__applyofntoshelldialog">\</a>  CFileDialog::ApplyOFNToShellDialog  
 Updates the current state of the [CFileDialog](../vs140/cfiledialog-class.md) based on the values stored in the <CodeContentPlaceHolder>142\</CodeContentPlaceHolder> data structure.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 In versions of Windows before [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], the member                         [OPENFILENAME](https://msdn.microsoft.com/en-us/library/ms911906.aspx) data structure was continuously synchronized with the state of the <CodeContentPlaceHolder>143\</CodeContentPlaceHolder>. Any changes to the [m_ofn](#cfiledialog__m_ofn) member variable were immediately reflected in the state of the dialog box. Also, any changes to the state of the dialog box immediately update the <CodeContentPlaceHolder>144\</CodeContentPlaceHolder> member variable.  
  
 In [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], the values in the <CodeContentPlaceHolder>145\</CodeContentPlaceHolder> member variable and state of the <CodeContentPlaceHolder>146\</CodeContentPlaceHolder> are not guaranteed to be synchronized. This function forces the state of the <CodeContentPlaceHolder>147\</CodeContentPlaceHolder> to be updated to match the <CodeContentPlaceHolder>148\</CodeContentPlaceHolder> structure. Windows calls this function automatically during [CFileDialog::DoModal](#cfiledialog__domodal).  
  
 For more information about how to use the <CodeContentPlaceHolder>149\</CodeContentPlaceHolder> class under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], see [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
### Example  
  See the example for [CFileDialog::UpdateOFNFromShellDialog](#cfiledialog__updateofnfromshelldialog).  
  
##  \<a name="cfiledialog__cfiledialog">\</a>  CFileDialog::CFileDialog  
 Call this function to construct a standard Windows file dialog box.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in]  <CodeContentPlaceHolder>150\</CodeContentPlaceHolder>  
 The parameter that specifies what type of dialog box to create. Set it to <CodeContentPlaceHolder>151\</CodeContentPlaceHolder> to construct a **File Open** dialog box. Set it to <CodeContentPlaceHolder>152\</CodeContentPlaceHolder> to construct a **File Save As** dialog box.  
  
 [in]  <CodeContentPlaceHolder>153\</CodeContentPlaceHolder>  
 The default file name extension. If the user does not include a known extension (one that has an association on the user’s computer) in the Filename box, the extension specified by <CodeContentPlaceHolder>154\</CodeContentPlaceHolder> is automatically appended to the file name. If this parameter is <CodeContentPlaceHolder>155\</CodeContentPlaceHolder>, no extension is appended.  
  
 [in]  <CodeContentPlaceHolder>156\</CodeContentPlaceHolder>  
 The initial file name that appears in the Filename box. If <CodeContentPlaceHolder>157\</CodeContentPlaceHolder>, no initial file name appears.  
  
 [in]  <CodeContentPlaceHolder>158\</CodeContentPlaceHolder>  
 A combination of one or more flags that you can use to customize the dialog box. For a description of these flags, see the                                 [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. If you modify the <CodeContentPlaceHolder>159\</CodeContentPlaceHolder> structure member, use a bitwise-OR operator in your changes to keep the default behavior intact.  
  
 [in]  <CodeContentPlaceHolder>160\</CodeContentPlaceHolder>  
 A series of string pairs that specify filters you can apply to the file. If you specify file filters, only files that match filter criteria will appear in the Files list. See the Remarks section for more information about how to work with file filters.  
  
 [in]  <CodeContentPlaceHolder>161\</CodeContentPlaceHolder>  
 A pointer to the parent or owner window of the file dialog box.  
  
 [in]  <CodeContentPlaceHolder>162\</CodeContentPlaceHolder>  
 The size of the <CodeContentPlaceHolder>163\</CodeContentPlaceHolder> structure. This value depends on the operating system version. MFC used this parameter to determine the appropriate kind of dialog box to create (for example, new [!INCLUDE[win2kfamily](../vs140/includes/win2kfamily_md.md)] dialog boxes instead of NT4 dialog boxes). The default size of 0 means that the MFC code will determine the correct dialog box size to use based on the operating system version on which the program is run.  
  
 [in]  <CodeContentPlaceHolder>164\</CodeContentPlaceHolder>  
 **Note** This parameter is available in Visual Studio 2008 and later and is will cause the new-style dialog to be used only if you are running in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] or later.  
  
 The parameter that specifies the style of the file dialog. Set it to <CodeContentPlaceHolder>165\</CodeContentPlaceHolder> to use the new Vista style file dialogs. Otherwise, the old style of dialog boxes will be used. See the Remarks section for more information about running under Vista.  
  
### Remarks  
 Either a **File Open** or **File Save As** dialog box is constructed, depending on the value of <CodeContentPlaceHolder>166\</CodeContentPlaceHolder>.  
  
 Specifying a default extension using <CodeContentPlaceHolder>167\</CodeContentPlaceHolder> may not produce the behavior that you expect, because it is seldom predictable what extensions have file associations on the user’s computer. If you need more control over the appending of a default extension, you can derive your own class from <CodeContentPlaceHolder>168\</CodeContentPlaceHolder>, and override the <CodeContentPlaceHolder>169\</CodeContentPlaceHolder> method to perform your own extension handling.  
  
 To enable the user to select multiple files, set the <CodeContentPlaceHolder>170\</CodeContentPlaceHolder> flag before you call [DoModal](#cfiledialog__domodal). You must supply your own file name buffer to store the returned list of multiple file names. Do this by replacing <CodeContentPlaceHolder>171\</CodeContentPlaceHolder> with a pointer to a buffer you have allocated, after you construct the [CFileDialog](../vs140/cfiledialog-class.md), but before you call <CodeContentPlaceHolder>172\</CodeContentPlaceHolder>. Additionally, you must set <CodeContentPlaceHolder>173\</CodeContentPlaceHolder> with the number of characters in the buffer pointed to by <CodeContentPlaceHolder>174\</CodeContentPlaceHolder>. If you set the maximum number of files to be selected to <CodeContentPlaceHolder>175\</CodeContentPlaceHolder>, the necessary buffer size is <CodeContentPlaceHolder>176\</CodeContentPlaceHolder>*(_MAX_PATH + 1) + 1. For example:  
  
 [!code[NVC_MFCFiles#23](../vs140/codesnippet/CPP/cfiledialog-class_1.cpp)]  
  
 To enable the user to resize an Explorer-style dialog box by using either the mouse or keyboard, set the <CodeContentPlaceHolder>177\</CodeContentPlaceHolder> flag. Setting this flag is necessary only if you provide a hook procedure or custom template. The flag works only with an Explorer-style dialog box; old-style dialog boxes cannot be resized.  
  
 The <CodeContentPlaceHolder>178\</CodeContentPlaceHolder> parameter is used to determine the type of file name a file must have to be displayed in the file list. The first string in the string pair describes the filter; the second string indicates the file name extension to use. Multiple extensions may be specified by using a semicolon (the ';' character) as the delimiter. The string ends with two '&#124;' characters, followed by a <CodeContentPlaceHolder>179\</CodeContentPlaceHolder> character. You can also use a [CString](../vs140/using-cstring.md) object for this parameter.  
  
 For example, [!INCLUDE[ofprexcel](../vs140/includes/ofprexcel_md.md)] allows users to open files that have extensions .xlc (chart) or .xls (worksheet), among others. The filter for Excel could be written as:  
  
 [!code[NVC_MFCFiles#24](../vs140/codesnippet/CPP/cfiledialog-class_2.cpp)]  
  
 However, if you plan to use this string to directly update the <CodeContentPlaceHolder>180\</CodeContentPlaceHolder> structure, you should delimit your strings with the null character, '\0', instead of the vertical bars ('&#124;').  
  
 The <CodeContentPlaceHolder>181\</CodeContentPlaceHolder> parameter is applicable only when running under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]. Under earlier versions of Windows, this parameter is ignored. If <CodeContentPlaceHolder>182\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>183\</CodeContentPlaceHolder>, when you compile a program with [!INCLUDE[vs_orcas_long](../vs140/includes/vs_orcas_long_md.md)] or later, the new Vista style **File Dialog** will be used. Otherwise, the previous MFC style **File Dialog** will be used. See [CFileDialog Class](../vs140/cfiledialog-class.md) for more information.  
  
 Dialog templates are not supported on dialogs based on <CodeContentPlaceHolder>184\</CodeContentPlaceHolder>  
  
### Example  
  See the example for [CFileDialog::DoModal](#cfiledialog__domodal).  
  
##  \<a name="cfiledialog__domodal">\</a>  CFileDialog::DoModal  
 Call this function to display the Windows common file dialog box and allow the user to browse files and directories and enter a filename.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Return Value  
 **IDOK** or **IDCANCEL**. If **IDCANCEL** is returned, call the Windows                         [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred.  
  
 **IDOK** and **IDCANCEL** are constants that indicate whether the user selected the OK or Cancel button.  
  
### Remarks  
 If you want to initialize the various file dialog-box options by setting members of the **m_ofn** structure, you should do this before calling <CodeContentPlaceHolder>185\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 For example, if you want to allow the user to select multiple files, set the <CodeContentPlaceHolder>186\</CodeContentPlaceHolder> flag before calling <CodeContentPlaceHolder>187\</CodeContentPlaceHolder>, as shown in the code example in [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
 When the user clicks the dialog box's OK or Cancel buttons, or selects the Close option from the dialog box's control menu, control is returned to your application. You can then call other member functions to retrieve the settings or information the user inputs into the dialog box.  
  
 <CodeContentPlaceHolder>188\</CodeContentPlaceHolder> is a virtual function overridden from class <CodeContentPlaceHolder>189\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCFiles#25](../vs140/codesnippet/CPP/cfiledialog-class_3.cpp)]  
  
##  \<a name="cfiledialog__enableopendropdown">\</a>  CFileDialog::EnableOpenDropDown  
 Enables a drop-down list on the Open or Save button in the dialog.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>190\</CodeContentPlaceHolder>  
 The ID of the drop-down list.  
  
### Remarks  
  
##  \<a name="cfiledialog__endvisualgroup">\</a>  CFileDialog::EndVisualGroup  
 Stops the addition of elements to a visual group in the dialog.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Return Value  
 Returns S_OK if successful; an error value otherwise.  
  
### Remarks  
  
##  \<a name="cfiledialog__getcheckbuttonstate">\</a>  CFileDialog::GetCheckButtonState  
 Retrieves the current state of a check button (check box) in the dialog.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>191\</CodeContentPlaceHolder>  
 The ID of the check box.  
  
 <CodeContentPlaceHolder>192\</CodeContentPlaceHolder>  
 The state of the check box. <CodeContentPlaceHolder>193\</CodeContentPlaceHolder> indicates checked; <CodeContentPlaceHolder>194\</CodeContentPlaceHolder> indicates unchecked.  
  
### Remarks  
  
##  \<a name="cfiledialog__getcontrolitemstate">\</a>  CFileDialog::GetControlItemState  
 Retrieves the current state of an item in a container control found in the dialog.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>195\</CodeContentPlaceHolder>  
 The ID of the container control.  
  
 <CodeContentPlaceHolder>196\</CodeContentPlaceHolder>  
 The ID of the item.  
  
 <CodeContentPlaceHolder>197\</CodeContentPlaceHolder>  
 A reference to a variable that receives one of more values from the CDCONTROLSTATE enumeration that indicates the current state of the control.  
  
### Remarks  
  
##  \<a name="cfiledialog__getcontrolstate">\</a>  CFileDialog::GetControlState  
 Retrieves the current visibility and enabled states of a given control.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>198\</CodeContentPlaceHolder>  
 The ID of the control.  
  
 <CodeContentPlaceHolder>199\</CodeContentPlaceHolder>  
 A reference to a variable that receives one or more values from the CDCONTROLSTATE enumeration that indicates the current state of the control.  
  
### Remarks  
  
##  \<a name="cfiledialog__geteditboxtext">\</a>  CFileDialog::GetEditBoxText  
 Retrieves the current text in an edit box control.  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>200\</CodeContentPlaceHolder>  
 The ID of the edit box.  
  
 <CodeContentPlaceHolder>201\</CodeContentPlaceHolder>  
 The text value.  
  
### Remarks  
  
##  \<a name="cfiledialog__getfileext">\</a>  CFileDialog::GetFileExt  
 Call this function to retrieve the extension of the filename entered into the dialog box.  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
### Return Value  
 The extension of the filename.  
  
### Remarks  
 For example, if the name of the file entered is DATA.TXT, <CodeContentPlaceHolder>202\</CodeContentPlaceHolder> returns "TXT".  
  
 If <CodeContentPlaceHolder>203\</CodeContentPlaceHolder> has the <CodeContentPlaceHolder>204\</CodeContentPlaceHolder> flag set, this string contains a sequence of null-terminated strings, with the first string being the directory path of the file group selected, followed by the names of all files selected by the user. To retrieve file pathnames, use the [GetStartPosition](#cfiledialog__getstartposition) and [GetNextPathName](#cfiledialog__getnextpathname) member functions.  
  
##  \<a name="cfiledialog__getfilename">\</a>  CFileDialog::GetFileName  
 Call this function to retrieve the name of the filename entered in the dialog box.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
### Return Value  
 The name of the file.  
  
### Remarks  
 The name of the file includes both the prefix and the extension. For example, <CodeContentPlaceHolder>205\</CodeContentPlaceHolder> will return "TEXT.DAT" for the file C:\FILES\TEXT.DAT.  
  
 If <CodeContentPlaceHolder>206\</CodeContentPlaceHolder> has the <CodeContentPlaceHolder>207\</CodeContentPlaceHolder> flag set, you should call [GetStartPosition](#cfiledialog__getstartposition) and [GetNextPathName](#cfiledialog__getnextpathname) to retrieve a file pathname.  
  
##  \<a name="cfiledialog__getfiletitle">\</a>  CFileDialog::GetFileTitle  
 Call this function to retrieve the title of the file entered in the dialog box.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
### Return Value  
 The title of the file.  
  
### Remarks  
 The title of the file includes only its prefix, without the path or the extension. For example, <CodeContentPlaceHolder>208\</CodeContentPlaceHolder> will return "TEXT" for the file C:\FILES\TEXT.DAT.  
  
 If <CodeContentPlaceHolder>209\</CodeContentPlaceHolder> has the <CodeContentPlaceHolder>210\</CodeContentPlaceHolder> flag set, this string contains a sequence of null-terminated strings, with the first string being the directory path of the file group selected, followed by the names of all files selected by the user. For this reason, use the [GetStartPosition](#cfiledialog__getstartposition) and [GetNextPathName](#cfiledialog__getnextpathname) member functions to retrieve the next file name in the list.  
  
### Example  
  See the example for [CFileDialog::DoModal](#cfiledialog__domodal).  
  
##  \<a name="cfiledialog__getfolderpath">\</a>  CFileDialog::GetFolderPath  
 Call this member function to retrieve the path of the currently open folder or directory for an Explorer-style Open or Save As common dialog box.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
### Return Value  
 A [CString](../vs140/cstringt-class.md) object containing the currently open folder or directory.  
  
### Remarks  
 The dialog box must have been created with the **OFN_EXPLORER** style; otherwise, the method will fail with an assertion.  
  
 You can call this method only while the dialog box is being displayed. After the dialog box has been closed, this function will no longer work, and the method will fail with an assertion.  
  
##  \<a name="cfiledialog__getifiledialogcustomize">\</a>  CFileDialog::GetIFileDialogCustomize  
 Retrieves a pointer to the internal COM object for a given [CFileDialog](../vs140/cfiledialog-class.md).  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
### Return Value  
 The pointer to the internal COM object for the <CodeContentPlaceHolder>211\</CodeContentPlaceHolder>. It is your responsibility to release this pointer appropriately.  
  
### Remarks  
 Use this function only under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] with an object that has <CodeContentPlaceHolder>212\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>213\</CodeContentPlaceHolder>. If you use this function when <CodeContentPlaceHolder>214\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>215\</CodeContentPlaceHolder>, it will return <CodeContentPlaceHolder>216\</CodeContentPlaceHolder> in release mode and throw an assertion in debug mode.  
  
 For more information about the <CodeContentPlaceHolder>217\</CodeContentPlaceHolder> interface,  see                         [IFileDialogCustomize](http://msdn.microsoft.com/library/windows/desktop/bb775912).  
  
### Example  
 This example retrieves the internal COM object. To run this code example, you must compile it under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)].  
  
 [!code[NVC_MFC_CFileDialog#4](../vs140/codesnippet/CPP/cfiledialog-class_4.cpp)]  
  
##  \<a name="cfiledialog__getifileopendialog">\</a>  CFileDialog::GetIFileOpenDialog  
 Retrieves a pointer to the internal COM object for a given <CodeContentPlaceHolder>218\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
### Return Value  
 The pointer to the internal COM object for the <CodeContentPlaceHolder>219\</CodeContentPlaceHolder>. It is your responsibility to release this pointer appropriately.  
  
### Remarks  
 Use this function only under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] with an object that has <CodeContentPlaceHolder>220\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>221\</CodeContentPlaceHolder>. This function returns <CodeContentPlaceHolder>222\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>223\</CodeContentPlaceHolder> is not an **Open** dialog box or if <CodeContentPlaceHolder>224\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>225\</CodeContentPlaceHolder>. In this final case, the function only returns <CodeContentPlaceHolder>226\</CodeContentPlaceHolder> in release mode - in debug mode it will throw an assertion.  
  
 For more information about the <CodeContentPlaceHolder>227\</CodeContentPlaceHolder> interface, see                         [IFileOpenDialog](http://msdn.microsoft.com/library/windows/desktop/bb775834).  
  
### Example  
 This example retrieves the internal COM object. To run this code, you must compile it under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)].  
  
 [!code[NVC_MFC_CFileDialog#2](../vs140/codesnippet/CPP/cfiledialog-class_5.cpp)]  
  
##  \<a name="cfiledialog__getifilesavedialog">\</a>  CFileDialog::GetIFileSaveDialog  
 Retrieves a pointer to the internal COM object for a given <CodeContentPlaceHolder>228\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
### Return Value  
 The pointer to the internal COM object for the <CodeContentPlaceHolder>229\</CodeContentPlaceHolder>. It is your responsibility to release this pointer appropriately.  
  
### Remarks  
 Use this function only under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] with an object that has <CodeContentPlaceHolder>230\</CodeContentPlaceHolder> set to <CodeContentPlaceHolder>231\</CodeContentPlaceHolder>. This function will return <CodeContentPlaceHolder>232\</CodeContentPlaceHolder> if the <CodeContentPlaceHolder>233\</CodeContentPlaceHolder> is not a **Save** dialog box or if <CodeContentPlaceHolder>234\</CodeContentPlaceHolder> is set to <CodeContentPlaceHolder>235\</CodeContentPlaceHolder>. In this final case, the function only returns <CodeContentPlaceHolder>236\</CodeContentPlaceHolder> in release mode - in debug mode it will throw an assertion.  
  
 For more information about the <CodeContentPlaceHolder>237\</CodeContentPlaceHolder> interface, see                         [IFileSaveDialog](http://msdn.microsoft.com/library/windows/desktop/bb775688).  
  
### Example  
 This example retrieves the internal COM object. To run this code example, you must compile it under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)].  
  
 [!code[NVC_MFC_CFileDialog#3](../vs140/codesnippet/CPP/cfiledialog-class_6.cpp)]  
  
##  \<a name="cfiledialog__getnextpathname">\</a>  CFileDialog::GetNextPathName  
 Call this function to retrieve the next filename from the group selected in the dialog box.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>238\</CodeContentPlaceHolder>  
 A reference to a **POSITION** value returned by a previous <CodeContentPlaceHolder>239\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>240\</CodeContentPlaceHolder> function call. **NULL** if the end of the list has been reached.  
  
### Return Value  
 The full path of the file.  
  
### Remarks  
 The path of the filename includes the file's title plus the entire directory path. For example, <CodeContentPlaceHolder>241\</CodeContentPlaceHolder> will return "C:\FILES\TEXT.DAT" for the file C:\FILES\TEXT.DAT. You can use <CodeContentPlaceHolder>242\</CodeContentPlaceHolder> in a forward iteration loop if you establish the initial position with a call to <CodeContentPlaceHolder>243\</CodeContentPlaceHolder>.  
  
 If the selection consists of only one file, that file name will be returned.  
  
##  \<a name="cfiledialog__getofn">\</a>  CFileDialog::GetOFN  
 Retrieves the associated **OPENFILENAME** structure.  
  
<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
### Return Value  
 An                         [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure.  
  
### Remarks  
 Use the second version of this function to initialize the appearance of a **File Open** or **File Save As** dialog box after it is constructed but before it is displayed with the <CodeContentPlaceHolder>244\</CodeContentPlaceHolder> member function. For example, you can set the **lpstrTitle** member of **m_ofn** to the caption you want the dialog box to have.  
  
##  \<a name="cfiledialog__getpathname">\</a>  CFileDialog::GetPathName  
 Call this function to retrieve the full path of the file entered in the dialog box.  
  
<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
### Return Value  
 The full path of the file.  
  
### Remarks  
 The path of the filename includes the file's title plus the entire directory path. For example, <CodeContentPlaceHolder>245\</CodeContentPlaceHolder> will return "C:\FILES\TEXT.DAT" for the file C:\FILES\TEXT.DAT.  
  
 If <CodeContentPlaceHolder>246\</CodeContentPlaceHolder> has the <CodeContentPlaceHolder>247\</CodeContentPlaceHolder> flag set, this string contains a sequence of null-teminated strings, with the first string being the directory path of the file group selected, followed by the names of all files selected by the user. For this reason, use the [GetStartPosition](#cfiledialog__getstartposition) and [GetNextPathName](#cfiledialog__getnextpathname) member functions to retrieve the next file name in the list.  
  
### Example  
  See the example for [CFileDialog::DoModal](#cfiledialog__domodal).  
  
##  \<a name="cfiledialog__getreadonlypref">\</a>  CFileDialog::GetReadOnlyPref  
 Call this function to determine whether the Read Only check box has been selected in the Windows standard File Open and File Save As dialog boxes.  
  
<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
### Return Value  
 Non-zero if the Read Only check box in the dialog box is selected; otherwise 0.  
  
### Remarks  
 You can hide the Read Only check box by setting the <CodeContentPlaceHolder>248\</CodeContentPlaceHolder> style in the [CFileDialog](../vs140/cfiledialog-class.md) constructor.  
  
> [!NOTE]
>  [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style <CodeContentPlaceHolder>249\</CodeContentPlaceHolder> objects do not support this function. Attempting to use this function on a [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style <CodeContentPlaceHolder>250\</CodeContentPlaceHolder> will throw [CNotSupportedException](../vs140/cnotsupportedexception-class.md). See [CFileDialog Class](../vs140/cfiledialog-class.md) for more information.  
  
##  \<a name="cfiledialog__getresult">\</a>  CFileDialog::GetResult  
 Retrieves the choice that the user made in the dialog.  
  
<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to an IShellItem that represents the user's choice.  
  
### Remarks  
  
##  \<a name="cfiledialog__getresults">\</a>  CFileDialog::GetResults  
 Retrieves the user's choices in a dialog that allows multiple selection.  
  
<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to an IShellItemArray through which the items selected in the dialog can be accessed.  
  
### Remarks  
  
##  \<a name="cfiledialog__getselectedcontrolitem">\</a>  CFileDialog::GetSelectedControlItem  
 Retrieves a particular item from the specified container control in the dialog.  
  
<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>251\</CodeContentPlaceHolder>  
 The ID of the container control.  
  
 <CodeContentPlaceHolder>252\</CodeContentPlaceHolder>  
 The ID of the item that the user selected in the control.  
  
### Remarks  
  
##  \<a name="cfiledialog__getstartposition">\</a>  CFileDialog::GetStartPosition  
 Call this member function to retrieve the position of the first file pathname in the list, if <CodeContentPlaceHolder>253\</CodeContentPlaceHolder> has the <CodeContentPlaceHolder>254\</CodeContentPlaceHolder> flag set.  
  
<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
### Return Value  
 A **POSITION** value that can be used for iteration; **NULL** if the list is empty.  
  
##  \<a name="cfiledialog__hidecontrol">\</a>  CFileDialog::HideControl  
 Call this member function to hide the specified control in an Explorer-style Open or Save As common dialog box.  
  
<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>255\</CodeContentPlaceHolder>  
 The ID of the control to hide.  
  
### Remarks  
 The dialog box must have been created with the **OFN_EXPLORER** style; otherwise, the function will fail with an assertion.  
  
##  \<a name="cfiledialog__ispickfoldersmode">\</a>  CFileDialog::IsPickFoldersMode  
 Determines if the current dialog is in folder picker mode.  
  
<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>256\</CodeContentPlaceHolder> if the dialog is in folder picker mode; otherwise <CodeContentPlaceHolder>257\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cfiledialog__m_ofn">\</a>  CFileDialog::m_ofn  
 <CodeContentPlaceHolder>258\</CodeContentPlaceHolder> is a structure of type <CodeContentPlaceHolder>259\</CodeContentPlaceHolder>. The data in this structure represents the current state of the <CodeContentPlaceHolder>260\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this structure to initialize the appearance of a **File Open** or **File Save As** dialog box after you construct it but before you display it with the [DoModal](#cfiledialog__domodal) method. For example, you can set the <CodeContentPlaceHolder>261\</CodeContentPlaceHolder> member of <CodeContentPlaceHolder>262\</CodeContentPlaceHolder> to the caption you want the dialog box to have.  
  
 With the [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style of [CFileDialog](../vs140/cfiledialog-class.md), <CodeContentPlaceHolder>263\</CodeContentPlaceHolder> is not guaranteed to always match the state of the dialog box. It is synchronized with the dialog box in earlier versions of Windows. See [CFileDialog::ApplyOFNToShellDialog](#cfiledialog__applyofntoshelldialog) and [CFileDialog::UpdateOFNFromShellDialog](#cfiledialog__updateofnfromshelldialog) for more information about synchronizing the <CodeContentPlaceHolder>264\</CodeContentPlaceHolder> structure and the <CodeContentPlaceHolder>265\</CodeContentPlaceHolder> state under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)].  
  
 [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style file dialogs do not support certain members and flags of the <CodeContentPlaceHolder>266\</CodeContentPlaceHolder>. As a result, these will have no effect.  
  
 The following is a list of the members that are not supported by [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]:  
  
-   <CodeContentPlaceHolder>267\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>268\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>269\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>270\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>271\</CodeContentPlaceHolder>  
  
 The following flags are not supported and therefore have no effect when you use the [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style of <CodeContentPlaceHolder>272\</CodeContentPlaceHolder>:  
  
-   OFN_ENABLEHOOK  
  
-   OFN_ENABLEINCLUDENOTIFY  
  
-   OFN_ENABLETEMPLATE  
  
-   OFN_ENABLETEMPLATEHANDLE  
  
-   OFN_EXPLORER  
  
-   OFN_EXTENSIONDIFFERENT  
  
-   OFN_HIDEREADONLY  
  
-   OFN_LONGNAMES - effectively always on in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]  
  
-   OFN_NOLONGNAMES - effectively always off in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]  
  
-   OFN_NONETWORKBUTTON - effectively always on in [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)]  
  
-   OFN_READONLY  
  
-   OFN_SHOWHELP  
  
 For more information about this structure, see the                         [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)]. For more information about the different behavior of the <CodeContentPlaceHolder>273\</CodeContentPlaceHolder> under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], see [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
##  \<a name="cfiledialog__makeprominent">\</a>  CFileDialog::MakeProminent  
 Places a control in the dialog so that it stands out compared to other controls.  
  
<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>274\</CodeContentPlaceHolder>  
 The ID of the control.  
  
### Remarks  
  
##  \<a name="cfiledialog__onbuttonclicked">\</a>  CFileDialog::OnButtonClicked  
 Called when the button is clicked.  
  
<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>275\</CodeContentPlaceHolder>  
 The ID of the button.  
  
### Remarks  
  
##  \<a name="cfiledialog__oncheckbuttontoggled">\</a>  CFileDialog::OnCheckButtonToggled  
 Called when the check box is checked or unchecked.  
  
<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>276\</CodeContentPlaceHolder>  
 The ID of the check box.  
  
 <CodeContentPlaceHolder>277\</CodeContentPlaceHolder>  
 Checked or unchecked.  
  
### Remarks  
  
##  \<a name="cfiledialog__oncontrolactivating">\</a>  CFileDialog::OnControlActivating  
 Called when the control is activated.  
  
<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>278\</CodeContentPlaceHolder>  
 The ID of the control.  
  
### Remarks  
  
##  \<a name="cfiledialog__onfilenamechange">\</a>  CFileDialog::OnFileNameChange  
 Override this method if you want to handle the <CodeContentPlaceHolder>279\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
### Remarks  
 The system sends the <CodeContentPlaceHolder>280\</CodeContentPlaceHolder> message when the user selects a new file or folder in the file list of the **Open** or **Save As** dialog box. Override this method if you want to perform any actions in response to this message.  
  
 The system sends this message only if the dialog box was created with the OFN_EXPLORER flag turned on. For more information about the notification, see                         [CDN_SELCHANGE](http://msdn.microsoft.com/library/windows/desktop/ms646865). For information about the OFN_EXPLORER flag, see the                         [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure and                         [Open and Save As Dialog Boxes](http://msdn.microsoft.com/library/windows/desktop/ms646960).  
  
##  \<a name="cfiledialog__onfilenameok">\</a>  CFileDialog::OnFileNameOK  
 Override this function only if you want to provide custom validation of filenames that are entered into a common file dialog box.  
  
<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
### Return Value  
 1 if the filename is not a valid filename; otherwise 0.  
  
### Remarks  
 This function allows you to reject a filename for any application-specific reason. Normally, you do not need to use this function because the framework provides default validation of filenames and displays a message box if an invalid filename is entered.  
  
 If 1 is returned, the dialog box will remain displayed for the user to enter another filename. The dialog procedure dismisses the dialog if the return is 0. Other nonzero return values are currently reserved and should not be used.  
  
##  \<a name="cfiledialog__onfolderchange">\</a>  CFileDialog::OnFolderChange  
 Override this function to handle the **WM_NOTIFYCDN_FOLDERCHANGE** message.  
  
<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
### Remarks  
 The notification message is sent when a new folder is opened in the Open or Save As dialog box.  
  
 Notification is sent only if the dialog box was created with the OFN_EXPLORER style. For more information about the notification, see                         [CDN_FOLDERCHANGE](http://msdn.microsoft.com/library/windows/desktop/ms646859). For information about the OFN_EXPLORER style, see the                         [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure and                         [Open and Save As Dialog Boxes](http://msdn.microsoft.com/library/windows/desktop/ms646960).  
  
##  \<a name="cfiledialog__oninitdone">\</a>  CFileDialog::OnInitDone  
 Override this function to handle the <CodeContentPlaceHolder>281\</CodeContentPlaceHolder> message.  
  
<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
### Remarks  
 The system sends this notification message when the system has finished arranging controls in the **Open** or **Save As** dialog box to make room for the controls of the child dialog box.  
  
 The system sends this only if the dialog box was created with the OFN_EXPLORER style. For more information about the notification, see                         [CDN_INITDONE](http://msdn.microsoft.com/library/windows/desktop/ms646863). For information about the OFN_EXPLORER style, see the                         [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure and                         [Open and Save As Dialog Boxes](http://msdn.microsoft.com/library/windows/desktop/ms646960).  
  
> [!NOTE]
>  [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style file dialogs do not support this function. Attempting to use this function on a [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style file dialog will throw [CNotSupportedException](../vs140/cnotsupportedexception-class.md). See [CFileDialog Class](../vs140/cfiledialog-class.md) for more information.  
  
##  \<a name="cfiledialog__onitemselected">\</a>  CFileDialog::OnItemSelected  
 Called when the container item is selected.  
  
<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>282\</CodeContentPlaceHolder>  
 The ID of the container control.  
  
 <CodeContentPlaceHolder>283\</CodeContentPlaceHolder>  
 The ID of the item.  
  
### Remarks  
  
##  \<a name="cfiledialog__onlbselchangednotify">\</a>  CFileDialog::OnLBSelChangedNotify  
 This function is called whenever the current selection in a list box is about to change.  
  
<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
### Parameters  
 *nIDBox*  
 The ID of the list box or combo box in which the selection occurred.  
  
 <CodeContentPlaceHolder>284\</CodeContentPlaceHolder>  
 The index of the current selection.  
  
 <CodeContentPlaceHolder>285\</CodeContentPlaceHolder>  
 The control notification code. This parameter must have one of the following values:  
  
-   **CD_LBSELCHANGE** Specifies <CodeContentPlaceHolder>286\</CodeContentPlaceHolder> is the selected item in a single-selection list box.  
  
-   **CD_LBSELSUB** Specifies that <CodeContentPlaceHolder>287\</CodeContentPlaceHolder> is no longer selected in a multiselection list box.  
  
-   **CD_LBSELADD** Specifies that <CodeContentPlaceHolder>288\</CodeContentPlaceHolder> is selected in a multiselection list box.  
  
-   **CD_LBSELNOITEMS** Specifies that no selection exists in a multiselection list box.  
  
### Remarks  
 Override this function to provide custom handling of selection changes in the list box. For example, you can use this function to display the access rights or date-last-modified of each file the user selects.  
  
##  \<a name="cfiledialog__onshareviolation">\</a>  CFileDialog::OnShareViolation  
 Override this function to provide custom handling of share violations.  
  
<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>289\</CodeContentPlaceHolder>  
 The path of the file on which the share violation occurred.  
  
### Return Value  
 One of the following values:  
  
-   **OFN_SHAREFALLTHROUGH** The filename is returned from the dialog box.  
  
-   **OFN_SHARENOWARN** No further action needs to be taken.  
  
-   **OFN_SHAREWARN** The user receives the standard warning message for this error.  
  
### Remarks  
 Normally, you do not need to use this function because the framework provides default checking of share violations and displays a message box if a share violation occurs.  
  
 If you want to disable share violation checking, use the bitwise OR operator to combine the flag **OFN_SHAREAWARE** with <CodeContentPlaceHolder>290\</CodeContentPlaceHolder>.  
  
##  \<a name="cfiledialog__ontypechange">\</a>  CFileDialog::OnTypeChange  
 Override this function to handle the **WM_NOTIFYCDN_TYPECHANGE** message.  
  
<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
### Remarks  
 The notification message is sent when the user selects a new file type from the list of file types in the Open or Save As dialog box.  
  
 Notification is sent only if the dialog box was created with the OFN_EXPLORER style. For more information about the notification, see                         [CDN_TYPECHANGE](http://msdn.microsoft.com/library/windows/desktop/ms646868). For information about the OFN_EXPLORER style, see the                         [OPENFILENAME](http://msdn.microsoft.com/library/windows/desktop/ms646839) structure and                         [Open and Save As Dialog Boxes](http://msdn.microsoft.com/library/windows/desktop/ms646960).  
  
##  \<a name="cfiledialog__removecontrolitem">\</a>  CFileDialog::RemoveControlItem  
 Removes an item from a container control in the dialog.  
  
<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>291\</CodeContentPlaceHolder>  
 The ID of the container control to remove the item from.  
  
 <CodeContentPlaceHolder>292\</CodeContentPlaceHolder>  
 The ID of the item.  
  
### Remarks  
  
##  \<a name="cfiledialog__setcheckbuttonstate">\</a>  CFileDialog::SetCheckButtonState  
 Sets the current state of a check button (check box) in the dialog.  
  
<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>293\</CodeContentPlaceHolder>  
 The ID of the check box.  
  
 <CodeContentPlaceHolder>294\</CodeContentPlaceHolder>  
 The state of the check box. <CodeContentPlaceHolder>295\</CodeContentPlaceHolder> indicates checked; <CodeContentPlaceHolder>296\</CodeContentPlaceHolder> indicates Unchecked.  
  
### Remarks  
  
##  \<a name="cfiledialog__setcontrolitemstate">\</a>  CFileDialog::SetControlItemState  
 Sets the current state of an item in a container control found in the dialog.  
  
<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>297\</CodeContentPlaceHolder>  
 The ID of the container control.  
  
 <CodeContentPlaceHolder>298\</CodeContentPlaceHolder>  
 The ID of the item.  
  
 <CodeContentPlaceHolder>299\</CodeContentPlaceHolder>  
 One or more values from the CDCONTROLSTATE enumeration that indicate the new state of the control.  
  
### Remarks  
  
##  \<a name="cfiledialog__setcontrolitemtext">\</a>  CFileDialog::SetControlItemText  
 Sets the text of a control item. For example, the text that accompanies a radio button or an item in a menu.  
  
<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>300\</CodeContentPlaceHolder>  
 The ID of the container control.  
  
 <CodeContentPlaceHolder>301\</CodeContentPlaceHolder>  
 The ID of the item.  
  
 <CodeContentPlaceHolder>302\</CodeContentPlaceHolder>  
 Item's text.  
  
### Remarks  
  
##  \<a name="cfiledialog__setcontrollabel">\</a>  CFileDialog::SetControlLabel  
 Sets the text associated with a control, such as button text or an edit box label.  
  
<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>303\</CodeContentPlaceHolder>  
 The ID of the control.  
  
 <CodeContentPlaceHolder>304\</CodeContentPlaceHolder>  
 The control name.  
  
### Remarks  
  
##  \<a name="cfiledialog__setcontrolstate">\</a>  CFileDialog::SetControlState  
 Sets the current visibility and enabled states of a given control.  
  
<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>305\</CodeContentPlaceHolder>  
 The ID of the control.  
  
 <CodeContentPlaceHolder>306\</CodeContentPlaceHolder>  
 One or more values from the CDCONTROLSTATE enumeration that indicate the current state of the control.  
  
### Remarks  
  
##  \<a name="cfiledialog__setcontroltext">\</a>  CFileDialog::SetControlText  
 Call this method to set the text for the specified control in an Explorer-style **Open** or **Save As** dialog box.  
  
<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>307\</CodeContentPlaceHolder>  
 The ID of the control for which to set the text.  
  
 [in] <CodeContentPlaceHolder>308\</CodeContentPlaceHolder>  
 A pointer to the string that contains the text to set for the control.  
  
### Remarks  
 Both versions of this function are valid for applications that use Unicode. However, only the version with the LPCSTR type is valid for applications that use [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)].  
  
 To use this method, you must create the dialog box with the OFN_EXPLORER style. Otherwise, the function will fail with an assertion.  
  
##  \<a name="cfiledialog__setdefext">\</a>  CFileDialog::SetDefExt  
 Call this function to set the default file name extension for an Explorer-style Open or Save As common dialog box.  
  
<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>309\</CodeContentPlaceHolder>  
 A pointer to a string containing the default extension to use for the dialog box object. This string must not contain a period (.).  
  
### Remarks  
 The dialog box must have been created with the **OFN_EXPLORER** style; otherwise, the function will fail with an assertion.  
  
##  \<a name="cfiledialog__seteditboxtext">\</a>  CFileDialog::SetEditBoxText  
 Sets the current text in an edit box control.  
  
<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>310\</CodeContentPlaceHolder>  
 The ID of the edit box.  
  
 <CodeContentPlaceHolder>311\</CodeContentPlaceHolder>  
 The text value.  
  
### Remarks  
  
##  \<a name="cfiledialog__setproperties">\</a>  CFileDialog::SetProperties  
 Provides a property store that defines the default values to be used for the item being saved.  
  
<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>312\</CodeContentPlaceHolder>  
 A list of predefined properties separated by ";". For a list of the flags, see the <CodeContentPlaceHolder>313\</CodeContentPlaceHolder> section of [OPENFILENAME](assetId:///8cecfd45-f7c1-4f8d-81a0-4e7fecc3b104).  
  
### Remarks  
  
##  \<a name="cfiledialog__setselectedcontrolitem">\</a>  CFileDialog::SetSelectedControlItem  
 Sets the selected state of a particular item in an option button group or a combo box found in the dialog.  
  
<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>314\</CodeContentPlaceHolder>  
 The ID of the container control.  
  
 <CodeContentPlaceHolder>315\</CodeContentPlaceHolder>  
 The ID of the item that the user selected in the control.  
  
### Remarks  
  
##  \<a name="cfiledialog__settemplate">\</a>  CFileDialog::SetTemplate  
 Sets the dialog box template for the [CFileDialog](../vs140/cfiledialog-class.md) object.  
  
<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>316\</CodeContentPlaceHolder>  
 Contains the ID number of the template resource for the non-Explorer <CodeContentPlaceHolder>317\</CodeContentPlaceHolder> object. This template is only used on Windows NT 3.51 or when the OFN_EXPLORER style is not present.  
  
 [in] <CodeContentPlaceHolder>318\</CodeContentPlaceHolder>  
 Contains the ID number of the template resource for the Explorer <CodeContentPlaceHolder>319\</CodeContentPlaceHolder> object. This template is used only on [!INCLUDE[WinNt4Family](../vs140/includes/winnt4family_md.md)] and later versions, Windows 95 and later versions, or when the OFN_EXPLORER style is present.  
  
 [in] <CodeContentPlaceHolder>320\</CodeContentPlaceHolder>  
 Contains the name of the template resource for the non-Explorer <CodeContentPlaceHolder>321\</CodeContentPlaceHolder> object. This template is only used on Windows NT 3.51 or when the OFN_EXPLORER style is not present.  
  
 [in] <CodeContentPlaceHolder>322\</CodeContentPlaceHolder>  
 Contains the name of the template resource of the Explorer <CodeContentPlaceHolder>323\</CodeContentPlaceHolder> object. This template is used only on [!INCLUDE[WinNt4Family](../vs140/includes/winnt4family_md.md)] and later versions, Windows 95 and later versions, or when the OFN_EXPLORER style is present.  
  
### Remarks  
 The system will use only one of the specified templates. The system determines which template to use based on the presence of the OFN_EXPLORER style and the operating system that the application is running on. By specifying both a non-Explorer and Explorer-style template, it is easy to support Windows NT 3.51, [!INCLUDE[WinNt4Family](../vs140/includes/winnt4family_md.md)] and later versions, and Windows 95 and later versions.  
  
> [!NOTE]
>  [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style file dialog boxes do not support this function. Attempting to use this function on a [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)] style file dialog box will throw [CNotSupportedException](../vs140/cnotsupportedexception-class.md). See [CFileDialog Class](../vs140/cfiledialog-class.md) for more information. An alternative is to use a customized dialog. For more information about using a custom <CodeContentPlaceHolder>324\</CodeContentPlaceHolder>, see                             [IFileDialogCustomize](http://msdn.microsoft.com/library/windows/desktop/bb775912).  
  
##  \<a name="cfiledialog__startvisualgroup">\</a>  CFileDialog::StartVisualGroup  
 Declares a visual group in the dialog. Subsequent calls to any "add" method add those elements to this group.  
  
<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>325\</CodeContentPlaceHolder>  
 The ID of the visual group.  
  
 <CodeContentPlaceHolder>326\</CodeContentPlaceHolder>  
 The group name.  
  
### Remarks  
  
##  \<a name="cfiledialog__updateofnfromshelldialog">\</a>  CFileDialog::UpdateOFNFromShellDialog  
 Updates the <CodeContentPlaceHolder>327\</CodeContentPlaceHolder> data structure of the [CFileDialog](../vs140/cfiledialog-class.md) based on the current state of the internal object.  
  
<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
### Remarks  
 In versions of Windows before [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], the member                         [OPENFILENAME](https://msdn.microsoft.com/en-us/library/ms911906.aspx) data structure was continuously synchronized with the state of the <CodeContentPlaceHolder>328\</CodeContentPlaceHolder>. Any changes to the [m_ofn](#cfiledialog__m_ofn) member variable directly affected the state of the dialog box. Also, any changes to the state of the dialog immediately updated the m_ofn member variable.  
  
 In [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], the <CodeContentPlaceHolder>329\</CodeContentPlaceHolder> data structure is not automatically updated. To guarantee the accuracy of the data in the <CodeContentPlaceHolder>330\</CodeContentPlaceHolder> member variable, you should call the <CodeContentPlaceHolder>331\</CodeContentPlaceHolder> function before accessing the data. Windows calls this function automatically during the processing of                         [IFileDialog::OnFileOK](http://msdn.microsoft.com/library/windows/desktop/bb775879).  
  
 For more information about how to use the <CodeContentPlaceHolder>332\</CodeContentPlaceHolder> class under [!INCLUDE[wiprlhext](../vs140/includes/wiprlhext_md.md)], see [CFileDialog Class](../vs140/cfiledialog-class.md).  
  
### Example  
 This example updates the <CodeContentPlaceHolder>333\</CodeContentPlaceHolder> before displaying it. Before updating the <CodeContentPlaceHolder>334\</CodeContentPlaceHolder> member variable, we need to synchronize it to the current state of the dialog box.  
  
 [!code[NVC_MFC_CFileDialog#1](../vs140/codesnippet/CPP/cfiledialog-class_7.cpp)]  
  
## See Also  
 [Base Class](../vs140/ccommondialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)