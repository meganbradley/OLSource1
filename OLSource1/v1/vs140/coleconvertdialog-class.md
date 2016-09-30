---
title: "COleConvertDialog Class"
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
  - "COleConvertDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleConvertDialog class"
  - "OLE Convert dialog box"
  - "dialog boxes, OLE"
  - "OLE dialog boxes, Convert"
  - "Convert dialog box"
ms.assetid: a7c57714-31e8-4b78-834d-8ddd1b856a1c
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleConvertDialog Class
For more information, see the             [OLEUICONVERT](http://msdn.microsoft.com/library/windows/desktop/ms686657) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleConvertDialog::COleConvertDialog](#coleconvertdialog__coleconvertdialog)|Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleConvertDialog::DoConvert](#coleconvertdialog__doconvert)|Performs the conversion specified in the dialog box.|  
|[COleConvertDialog::DoModal](#coleconvertdialog__domodal)|Displays the OLE Change Item dialog box.|  
|[COleConvertDialog::GetClassID](#coleconvertdialog__getclassid)|Gets the **CLSID** associated with the chosen item.|  
|[COleConvertDialog::GetDrawAspect](#coleconvertdialog__getdrawaspect)|Specifies whether to draw item as an icon.|  
|[COleConvertDialog::GetIconicMetafile](#coleconvertdialog__geticonicmetafile)|Gets a handle to the metafile associated with the iconic form of this item.|  
|[COleConvertDialog::GetSelectionType](#coleconvertdialog__getselectiontype)|Gets the type of selection chosen.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleConvertDialog::m_cv](#coleconvertdialog__m_cv)|A structure that controls the behavior of the dialog box.|  
  
## Remarks  
  
> [!NOTE]
>  Application Wizard-generated container code uses this class.  
  
 For more information about OLE-specific dialog boxes, see the article [Dialog Boxes in OLE](../vs140/dialog-boxes-in-ole.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 [COleDialog](../vs140/coledialog-class.md)  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxodlgs.h  
  
##  \<a name="coleconvertdialog__coleconvertdialog">\</a>  COleConvertDialog::COleConvertDialog  
 Constructs only a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Points to the item to be converted or activated.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Creation flag, which contains any number of the following values combined using the bitwise-or operator:  
  
-   **CF_SELECTCONVERTTO** Specifies that the Convert To radio button will be selected initially when the dialog box is called. This is the default.  
  
-   **CF_SELECTACTIVATEAS** Specifies that the Activate As radio button will be selected initially when the dialog box is called.  
  
-   **CF_SETCONVERTDEFAULT** Specifies that the class whose **CLSID** is specified by the **clsidConvertDefault** member of the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> structure will be used as the default selection in the class list box when the Convert To radio button is selected.  
  
-   **CF_SETACTIVATEDEFAULT** Specifies that the class whose **CLSID** is specified by the **clsidActivateDefault** member of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> structure will be used as the default selection in the class list box when the Activate As radio button is selected.  
  
-   **CF_SHOWHELPBUTTON** Specifies that the Help button will be displayed when the dialog box is called.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Points to the CLSID of the item to be converted or activated. If **NULL**, the **CLSID** associated with <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> will be used.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog box is set to the main application window.  
  
### Remarks  
 To display the dialog box, call the [DoModal](#coleconvertdialog__domodal) function.  
  
 For more information, see                         [CLSID Key](http://msdn.microsoft.com/library/windows/desktop/ms691424) and the                         [OLEUICONVERT](http://msdn.microsoft.com/library/windows/desktop/ms686657) structure.  
  
##  \<a name="coleconvertdialog__doconvert">\</a>  COleConvertDialog::DoConvert  
 Call this function, after returning successfully from [DoModal](#coleconvertdialog__domodal), either to convert or to activate an object of type [COleClientItem](../vs140/coleclientitem-class.md).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Points to the item to be converted or activated. Cannot be **NULL**.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 The item is converted or activated according to the information selected by the user in the Convert dialog box.  
  
##  \<a name="coleconvertdialog__domodal">\</a>  COleConvertDialog::DoModal  
 Call this function to display the OLE Convert dialog box.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 Completion status for the dialog box. One of the following values:  
  
-   **IDOK** if the dialog box was successfully displayed.  
  
-   **IDCANCEL** if the user canceled the dialog box.  
  
-   **IDABORT** if an error occurred. If **IDABORT** is returned, call the [COleDialog::GetLastError](../vs140/coledialog-class.md#coledialog__getlasterror) member function to get more information about the type of error that occurred. For a listing of possible errors, see the                                 [OleUIConvert](http://msdn.microsoft.com/library/windows/desktop/ms680694) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 If you want to initialize the various dialog box controls by setting members of the [m_cv](#coleconvertdialog__m_cv) structure, you should do this before calling <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 If <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> returns **IDOK**, you can call other member functions to retrieve the settings or information that was input by the user into the dialog box.  
  
##  \<a name="coleconvertdialog__getclassid">\</a>  COleConvertDialog::GetClassID  
 Call this function to get the **CLSID** associated with the item the user selected in the Convert dialog box.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The **CLSID** associated with the item that was selected in the Convert dialog box.  
  
### Remarks  
 Call this function only after [DoModal](#coleconvertdialog__domodal) returns **IDOK**.  
  
 For more information, see                         [CLSID Key](http://msdn.microsoft.com/library/windows/desktop/ms691424) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleconvertdialog__getdrawaspect">\</a>  COleConvertDialog::GetDrawAspect  
 Call this function to determine whether the user chose to display the selected item as an icon.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The method needed to render the object.  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> Returned if the Display As Icon check box was not checked.  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> Returned if the Display As Icon check box was checked.  
  
### Remarks  
 Call this function only after [DoModal](#coleconvertdialog__domodal) returns **IDOK**.  
  
 For more information on drawing aspect, see the                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) data structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleconvertdialog__geticonicmetafile">\</a>  COleConvertDialog::GetIconicMetafile  
 Call this function to get a handle to the metafile that contains the iconic aspect of the selected item.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The handle to the metafile containing the iconic aspect of the selected item, if the Display As Icon check box was checked when the dialog was dismissed by choosing **OK**; otherwise **NULL**.  
  
##  \<a name="coleconvertdialog__getselectiontype">\</a>  COleConvertDialog::GetSelectionType  
 Call this function to determine the type of conversion selected in the Convert dialog box.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 Type of selection made.  
  
### Remarks  
 The return type values are specified by the **Selection** enumeration type declared in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 Brief descriptions of these values follow:  
  
-   **COleConvertDialog::noConversion** Returned if either the dialog box was canceled or the user selected no conversion. If <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> returned **IDOK**, it is possible that the user selected a different icon than the one previously selected.  
  
-   **COleConvertDialog::convertItem** Returned if the Convert To radio button was checked, the user selected a different item to convert to, and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> returned **IDOK**.  
  
-   **COleConvertDialog::activateAs** Returned if the Activate As radio button was checked, the user selected a different item to activate, and <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> returned **IDOK**.  
  
##  \<a name="coleconvertdialog__m_cv">\</a>  COleConvertDialog::m_cv  
 Structure of type **OLEUICONVERT** used to control the behavior of the Convert dialog box.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 Members of this structure can be modified either directly or through member functions.  
  
 For more information, see the                         [OLEUICONVERT](http://msdn.microsoft.com/library/windows/desktop/ms686657) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [Base Class](../vs140/coledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDialog](../vs140/coledialog-class.md)