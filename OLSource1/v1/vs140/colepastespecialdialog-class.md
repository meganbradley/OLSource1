---
title: "COlePasteSpecialDialog Class"
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
  - "COlePasteSpecialDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Paste Special dialog box"
  - "dialog boxes, Paste Special"
  - "OLE Paste Special dialog box"
  - "COlePasteSpecialDialog class"
ms.assetid: 0e82ef9a-9bbe-457e-8240-42c86a0534f7
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePasteSpecialDialog Class
Used for the OLE Paste Special dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COlePasteSpecialDialog::COlePasteSpecialDialog](#colepastespecialdialog__colepastespecialdialog)|Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COlePasteSpecialDialog::AddFormat](#colepastespecialdialog__addformat)|Adds custom formats to the list of formats your application can paste.|  
|[COlePasteSpecialDialog::AddLinkEntry](#colepastespecialdialog__addlinkentry)|Adds a new entry to the list of supported Clipboard formats.|  
|[COlePasteSpecialDialog::AddStandardFormats](#colepastespecialdialog__addstandardformats)|Adds **CF_BITMAP**, **CF_DIB**, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and optionally <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to the list of formats your application can paste.|  
|[COlePasteSpecialDialog::CreateItem](#colepastespecialdialog__createitem)|Creates the item in the container document using the specified format.|  
|[COlePasteSpecialDialog::DoModal](#colepastespecialdialog__domodal)|Displays the OLE Paste Special dialog box.|  
|[COlePasteSpecialDialog::GetDrawAspect](#colepastespecialdialog__getdrawaspect)|Tells whether to draw item as an icon or not.|  
|[COlePasteSpecialDialog::GetIconicMetafile](#colepastespecialdialog__geticonicmetafile)|Gets a handle to the metafile associated with the iconic form of this item.|  
|[COlePasteSpecialDialog::GetPasteIndex](#colepastespecialdialog__getpasteindex)|Gets the index of available paste options that was chosen by the user.|  
|[COlePasteSpecialDialog::GetSelectionType](#colepastespecialdialog__getselectiontype)|Gets the type of selection chosen.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COlePasteSpecialDialog::m_ps](#colepastespecialdialog__m_ps)|A structure of type **OLEUIPASTESPECIAL** that controls the function of the dialog box.|  
  
## Remarks  
 Create an object of class <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> when you want to call this dialog box. After a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object has been constructed, you can use the [AddFormat](#colepastespecialdialog__addformat) and [AddStandardFormats](#colepastespecialdialog__addstandardformats) member functions to add Clipboard formats to the dialog box. You can also use the [m_ps](#colepastespecialdialog__m_ps) structure to initialize the values or states of controls in the dialog box. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> structure is of type **OLEUIPASTESPECIAL**.  
  
 For more information, see the                 [OLEUIPASTESPECIAL](http://msdn.microsoft.com/library/windows/desktop/ms692434) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information regarding OLE-specific dialog boxes, see the article [Dialog Boxes in OLE](../vs140/dialog-boxes-in-ole.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 [COleDialog](../vs140/coledialog-class.md)  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxodlgs.h  
  
##  \<a name="colepastespecialdialog__addformat">\</a>  COlePasteSpecialDialog::AddFormat  
 Call this function to add new formats to the list of formats your application can support in a Paste Special operation.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 *fmt*  
 Reference to the data type to add.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 String that describes the format to the user.  
  
 *lpszResult*  
 String that describes the result if this format is chosen in the dialog box.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The different linking and embedding options available for this format. This flag is a bitwise combination of one or more of the different values in the **OLEUIPASTEFLAG** enumerated type.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 The clipboard format to add.  
  
 *tymed*  
 The types of media available in this format. This is a bitwise combination of one or more of the values in the **TYMED** enumerated type.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 The ID of the string that identifies this format. The format of this string is two separate strings separated by a '\n' character. The first string is the same that would be passed in the                                 *lpstrFormat* parameter, and the second is the same as the                                 *lpstrResult* parameter.  
  
 *bEnableIcon*  
 Flag that determines whether the Display As Icon check box is enabled when this format is chosen in the list box.  
  
 *bLink*  
 Flag that determines whether the Paste Link radio button is enabled when this format is chosen in the list box.  
  
### Remarks  
 This function can be called to add either standard formats such as **CF_TEXT** or **CF_TIFF** or custom formats that your application has registered with the system. For more information about pasting data objects into your application, see the article [Data Objects and Data Sources: Manipulation](../vs140/data-objects-and-data-sources--manipulation.md).  
  
 For more information, see the                         [TYMED](http://msdn.microsoft.com/library/windows/desktop/ms691227) enumeration type and the                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information, see the                         [OLEUIPASTEFLAG](http://msdn.microsoft.com/library/windows/desktop/ms682172) enumerated type in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colepastespecialdialog__addlinkentry">\</a>  COlePasteSpecialDialog::AddLinkEntry  
 Adds a new entry to the list of supported Clipboard formats.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 The clipboard format to add.  
  
### Return Value  
 An                         [OLEUIPASTEFLAG](http://msdn.microsoft.com/library/windows/desktop/ms682172) structure containing the information for the new link entry.  
  
##  \<a name="colepastespecialdialog__addstandardformats">\</a>  COlePasteSpecialDialog::AddStandardFormats  
 Call this function to add the following Clipboard formats to the list of formats your application can support in a Paste Special operation:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 *bEnableLink*  
 Flag that determines whether to add <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to the list of formats your application can paste.  
  
### Remarks  
  
-   **CF_BITMAP**  
  
-   **CF_DIB**  
  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
-   **"Embedded Object"**  
  
-   (optionally) **"Link Source"**  
  
 These formats are used to support embedding and linking.  
  
##  \<a name="colepastespecialdialog__colepastespecialdialog">\</a>  COlePasteSpecialDialog::COlePasteSpecialDialog  
 Constructs a <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Creation flag, contains any number of the following flags combined using the bitwise-OR operator:  
  
-   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> Specifies that the Paste radio button will be checked initially when the dialog box is called. Cannot be used in combination with <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. This is the default.  
  
-   <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> Specifies that the Paste Link radio button will be checked initially when the dialog box is called. Cannot be used in combination with <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> Specifies that the Display As Icon check box will be checked initially when the dialog box is called.  
  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> Specifies that the Help button will be displayed when the dialog box is called.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Points to the [COleDataObject](../vs140/coledataobject-class.md) for pasting. If this value is **NULL**, it gets the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> from the Clipboard.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog box is set to the main application window.  
  
### Remarks  
 This function only constructs a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> object. To display the dialog box, call the [DoModal](#colepastespecialdialog__domodal) function.  
  
 For more information, see the                         [OLEUIPASTEFLAG](http://msdn.microsoft.com/library/windows/desktop/ms682172) enumerated type in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colepastespecialdialog__createitem">\</a>  COlePasteSpecialDialog::CreateItem  
 Creates the new item that was chosen in the Paste Special dialog box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 *pNewItem*  
 Points to a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> instance. Cannot be **NULL**.  
  
### Return Value  
 Nonzero if the item was created successfully; otherwise 0.  
  
### Remarks  
 This function should only be called after [DoModal](#colepastespecialdialog__domodal) returns **IDOK**.  
  
##  \<a name="colepastespecialdialog__domodal">\</a>  COlePasteSpecialDialog::DoModal  
 Displays the OLE Paste Special dialog box.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 Completion status for the dialog box. One of the following values:  
  
-   **IDOK** if the dialog box was successfully displayed.  
  
-   **IDCANCEL** if the user canceled the dialog box.  
  
-   **IDABORT** if an error occurred. If **IDABORT** is returned, call the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> member function to get more information about the type of error that occurred. For a listing of possible errors, see the                                 [OleUIPasteSpecial](http://msdn.microsoft.com/library/windows/desktop/ms694512) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 If you want to initialize the various dialog box controls by setting members of the [m_ps](#colepastespecialdialog__m_ps) structure, you should do this before calling <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 If <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> returns **IDOK**, you can call other member functions to retrieve the settings or information input by the user into the dialog box.  
  
##  \<a name="colepastespecialdialog__getdrawaspect">\</a>  COlePasteSpecialDialog::GetDrawAspect  
 Determines if the user chose to display the selected item as an icon.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The method needed to render the object.  
  
-   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> Returned if the Display As Icon check box was not checked when the dialog box was dismissed.  
  
-   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> Returned if the Display As Icon check box was checked when the dialog box was dismissed.  
  
### Remarks  
 Only call this function after [DoModal](#colepastespecialdialog__domodal) returns **IDOK**.  
  
 For more information on drawing aspect, see the                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colepastespecialdialog__geticonicmetafile">\</a>  COlePasteSpecialDialog::GetIconicMetafile  
 Gets the metafile associated with the item selected by the user.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 The handle to the metafile containing the iconic aspect of the selected item, if the Display As Icon check box was selected when the dialog box was dismissed by choosing **OK**; otherwise **NULL**.  
  
##  \<a name="colepastespecialdialog__getpasteindex">\</a>  COlePasteSpecialDialog::GetPasteIndex  
 Gets the index value associated with the entry the user selected.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 The index into the array of **OLEUIPASTEENTRY** structures that was selected by the user. The format that corresponds to the selected index should be used when performing the paste operation.  
  
### Remarks  
 For more information, see the                         [OLEUIPASTEENTRY](http://msdn.microsoft.com/library/windows/desktop/ms690165) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colepastespecialdialog__getselectiontype">\</a>  COlePasteSpecialDialog::GetSelectionType  
 Determines the type of selection the user made.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 Returns type of selection made.  
  
### Remarks  
 The return type values are specified by the **Selection** enumeration type declared in the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  
 Brief desccriptions of these values follow:  
  
-   **COlePasteSpecialDialog::pasteLink** The Paste Link radio button was checked and the chosen format was a standard OLE format.  
  
-   **COlePasteSpecialDialog::pasteNormal** The Paste radio button was checked and the chosen format was a standard OLE format.  
  
-   **COlePasteSpecialDialog::pasteOther** The selected format is not a standard OLE format.  
  
-   **COlePasteSpecialDialog::pasteStatic** The chosen format was a metafile.  
  
##  \<a name="colepastespecialdialog__m_ps">\</a>  COlePasteSpecialDialog::m_ps  
 Structure of type **OLEUIPASTESPECIAL** used to control the behavior of the Paste Special dialog box.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Remarks  
 Members of this structure can be modified directly or through member functions.  
  
 For more information, see the                         [OLEUIPASTESPECIAL](http://msdn.microsoft.com/library/windows/desktop/ms692434) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [MFC Sample OCLIENT](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/coledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDialog](../vs140/coledialog-class.md)