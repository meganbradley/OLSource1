---
title: "CMFCKeyMapDialog Class"
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
  - "CMFCKeyMapDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCKeyMapDialog class"
ms.assetid: 5feb4942-d636-462d-a162-0104dd320f4e
caps.latest.revision: 25
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCKeyMapDialog Class
The <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class supports a control that maps commands to keys on the keyboard.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCKeyMapDialog::CMFCKeyMapDlg](#cmfckeymapdialog__cmfckeymapdialog)|Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCKeyMapDialog::DoModal](#cmfckeymapdialog__domodal)|Displays a keyboard mapping dialog box.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCKeyMapDialog::FormatItem](#cmfckeymapdialog__formatitem)|Called by the framework to build a string that describes a key mapping. By default, the string contains the command name, the shortcut keys used, and the shortcut key description.|  
|[CMFCKeyMapDialog::GetCommandKeys](#cmfckeymapdialog__getcommandkeys)|Retrieves a string that contains a list of shortcut keys associated with the specified command.|  
|[CMFCKeyMapDialog::OnInsertItem](#cmfckeymapdialog__oninsertitem)|Called by the framework before a new item is inserted into the internal list control that supports the keyboard mapping control.|  
|[CMFCKeyMapDialog::OnPrintHeader](#cmfckeymapdialog__onprintheader)|Called by the framework to print the header for the keyboard map on a new page.|  
|[CMFCKeyMapDialog::OnPrintItem](#cmfckeymapdialog__onprintitem)|Called by the framework to print a keyboard mapping item.|  
|[CMFCKeyMapDialog::OnSetColumns](#cmfckeymapdialog__onsetcolumns)|Called by the framework to set captions for the columns in the internal list control that supports the keyboard mapping control.|  
|[CMFCKeyMapDialog::PrintKeyMap](#cmfckeymapdialog__printkeymap)|Called by the framework when a user clicks the **Print** button.|  
|[CMFCKeyMapDialog::SetColumnsWidth](#cmfckeymapdialog__setcolumnswidth)|Called by the framework to set the width of the columns in the internal list control that supports the keyboard mapping control.|  
  
## Remarks  
 Use the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class to implement a resizable keyboard mapping dialog box. The dialog box uses a list view control to display keyboard shortcuts and their associated commands.  
  
 To use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class in an application, pass in a pointer to the main frame window as a parameter to the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> constructor. Then call the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method to start a modal dialog box.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CDialogEx](../vs140/cdialogex-class.md)  
  
 [CMFCKeyMapDialog](../vs140/cmfckeymapdialog-class.md)  
  
## Requirements  
 **Header:** afxkeymapdialog.h  
  
##  \<a name="cmfckeymapdialog__cmfckeymapdialog">\</a>  CMFCKeyMapDialog::CMFCKeyMapDialog  
 Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 A pointer to the parent window of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object.  
  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> if the list of accelerator keys can be printed; otherwise, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
### Remarks  
  
### Example  
 The following example demonstrates how to construct an object of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class. This example is part of the [Visual Studio Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_VisualStudioDemo#21](../vs140/codesnippet/CPP/cmfckeymapdialog-class_1.cpp)]  
  
##  \<a name="cmfckeymapdialog__domodal">\</a>  CMFCKeyMapDialog::DoModal  
 Displays a keyboard mapping dialog box.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A signed integer, such as <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, that is passed to the [CDialog::EndDialog](../vs140/cdialog-class.md#cdialog__enddialog) method. The method, in turn, closes the dialog box. For more information, see [CDialog::DoModal](../vs140/cdialog-class.md#cdialog__domodal).  
  
### Remarks  
 The keyboard mapping dialog box enables you to select and assign accelerator keys to various categories of commands. In addition, you can copy the selected accelerator keys and their description to the clipboard.  
  
##  \<a name="cmfckeymapdialog__formatitem">\</a>  CMFCKeyMapDialog::FormatItem  
 Called by the framework to build a string that describes a key mapping. By default, the string contains the command name, the shortcut keys used, and the shortcut key description.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 The zero-based index of an item in the internal list of key mappings.  
  
### Return Value  
 A <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> object that contains the formatted item text.  
  
### Remarks  
  
##  \<a name="cmfckeymapdialog__getcommandkeys">\</a>  CMFCKeyMapDialog::GetCommandKeys  
 Retrieves a string value. The string contains a list of shortcut keys that are associated with a specified command.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 A command ID.  
  
### Return Value  
 A semicolon-delimited (';') list of shortcut keys that is associated with the specified command.  
  
### Remarks  
  
##  \<a name="cmfckeymapdialog__oninsertitem">\</a>  CMFCKeyMapDialog::OnInsertItem  
 Called by the framework before a new item is inserted into an internal list control that supports the keyboard mapping control.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A pointer to a toolbar button that is used to map a keyboard key combination to a command name and description. The key map item is stored in an internal list control.  
  
 [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 A zero-based index that specifies where to insert the new key map item in the internal list control.  
  
### Remarks  
  
##  \<a name="cmfckeymapdialog__onprintheader">\</a>  CMFCKeyMapDialog::OnPrintHeader  
 Called by the framework to print the header for the keyboard map on a new page.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The device context for the printer.  
  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 The page number to print.  
  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The horizontal offset of the header, in pixels.  
  
### Return Value  
 If successful, the height of the printed text. For more information, see the Return Value section of [CDC::DrawText](../vs140/cdc-class.md#cdc__drawtext).  
  
### Remarks  
 The framework uses this method to print the keyboard map. By default, this method prints the page number, application name, and dialog box title.  
  
##  \<a name="cmfckeymapdialog__onprintitem">\</a>  CMFCKeyMapDialog::OnPrintItem  
 Called by the framework to print a keyboard mapping item.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 The device context of the printer.  
  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The zero-based index of the item to print.  
  
 [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The vertical offset between the top of the page and the position of the item.  
  
 [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 The horizontal offset between the left of the page and the position of the item.  
  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to calculate the best height for the print item; <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> to truncate the print item so that it fits the default space.  
  
### Return Value  
 The height of the printed item.  
  
### Remarks  
 The framework calls this method to print a key map dialog box item. By default, this method prints the item's command name, shortcut keys, and command description.  
  
##  \<a name="cmfckeymapdialog__onsetcolumns">\</a>  CMFCKeyMapDialog::OnSetColumns  
 Called by the framework to set captions for the columns in the internal list control that supports the keyboard mapping control.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 By default, this method obtains the captions for the columns from three resources. The command column caption is from IDS_AFXBARRES_COMMAND, the key column caption is from IDS_AFXBARRES_KEYS, and the description column caption is from IDS_AFXBARRES_DESCRIPTION.  
  
##  \<a name="cmfckeymapdialog__printkeymap">\</a>  CMFCKeyMapDialog::PrintKeyMap  
 Called by the framework when a user clicks the **Print** button.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> method prints the key map. It initiates a new print job and then repeatedly calls the [CMFCKeyMapDialog::OnPrintHeader](#cmfckeymapdialog__onprintheader) and [CMFCKeyMapDialog::OnPrintItem](#cmfckeymapdialog__onprintitem) methods until all the key mappings are printed.  
  
##  \<a name="cmfckeymapdialog__setcolumnswidth">\</a>  CMFCKeyMapDialog::SetColumnsWidth  
 Called by the framework to set the width of the columns in the internal list control that supports the keyboard mapping control.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Remarks  
 This method sets the internal list control's columns to default widths. First, the width of the shortcut keys column is calculated. Then one-third of the remaining width is allocated to the command column and the remaining two-thirds is allocated to the description column.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCKeyboardManager](../vs140/ckeyboardmanager-class.md)