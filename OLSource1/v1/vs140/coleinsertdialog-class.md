---
title: "COleInsertDialog Class"
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
  - "COleInsertDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE Insert Object dialog box"
  - "dialog boxes, OLE"
  - "COleInsertDialog class"
  - "Insert Object dialog box"
ms.assetid: a9ec610b-abde-431e-bd01-c40159a66dbb
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleInsertDialog Class
Used for the OLE Insert Object dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleInsertDialog::COleInsertDialog](#coleinsertdialog__coleinsertdialog)|Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleInsertDialog::CreateItem](#coleinsertdialog__createitem)|Creates the item selected in the dialog box.|  
|[COleInsertDialog::DoModal](#coleinsertdialog__domodal)|Displays the OLE Insert Object dialog box.|  
|[COleInsertDialog::GetClassID](#coleinsertdialog__getclassid)|Gets the **CLSID** associated with the chosen item.|  
|[COleInsertDialog::GetDrawAspect](#coleinsertdialog__getdrawaspect)|Tells whether to draw the item as an icon.|  
|[COleInsertDialog::GetIconicMetafile](#coleinsertdialog__geticonicmetafile)|Gets a handle to the metafile associated with the iconic form of this item.|  
|[COleInsertDialog::GetPathName](#coleinsertdialog__getpathname)|Gets the full path to the file chosen in the dialog box.|  
|[COleInsertDialog::GetSelectionType](#coleinsertdialog__getselectiontype)|Gets the type of object selected.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleInsertDialog::m_io](#coleinsertdialog__m_io)|A structure of type **OLEUIINSERTOBJECT** that controls the behavior of the dialog box.|  
  
## Remarks  
 Create an object of class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> when you want to call this dialog box. After a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object has been constructed, you can use the [m_io](#coleinsertdialog__m_io) structure to initialize the values or states of controls in the dialog box. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> structure is of type **OLEUIINSERTOBJECT**. For more information about using this dialog class, see the [DoModal](#coleinsertdialog__domodal) member function.  
  
> [!NOTE]
>  Application Wizard-generated container code uses this class.  
  
 For more information, see the                 [OLEUIINSERTOBJECT](http://msdn.microsoft.com/library/windows/desktop/ms691316) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information regarding OLE-specific dialog boxes, see the article [Dialog Boxes in OLE](../vs140/dialog-boxes-in-ole.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 [COleDialog](../vs140/coledialog-class.md)  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxodlgs.h  
  
##  \<a name="coleinsertdialog__coleinsertdialog">\</a>  COleInsertDialog::COleInsertDialog  
 This function constructs only a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Creation flag that contains any number of the following values to be combined using the bitwise-OR operator:  
  
-   **IOF_SHOWHELP** Specifies that the Help button will be displayed when the dialog box is called.  
  
-   **IOF_SELECTCREATENEW** Specifies that the Create New radio button will be selected initially when the dialog box is called. This is the default and cannot be used with **IOF_SELECTCREATEFROMFILE**.  
  
-   **IOF_SELECTCREATEFROMFILE** Specifies that the Create From File radio button will be selected initially when the dialog box is called. Cannot be used with **IOF_SELECTCREATENEW**.  
  
-   **IOF_CHECKLINK** Specifies that the Link check box will be checked initially when the dialog box is called.  
  
-   **IOF_DISABLELINK** Specifies that the Link check box will be disabled when the dialog box is called.  
  
-   **IOF_CHECKDISPLAYASICON** Specifies that the Display As Icon check box will be checked initially, the current icon will be displayed, and the Change Icon button will be enabled when the dialog box is called.  
  
-   **IOF_VERIFYSERVERSEXIST** Specifies that the dialog box should validate the classes it adds to the list box by ensuring that the servers specified in the registration database exist before the dialog box is displayed. Setting this flag can significantly impair performance.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog object is set to the main application window.  
  
### Remarks  
 To display the dialog box, call the [DoModal](#coleinsertdialog__domodal) function.  
  
##  \<a name="coleinsertdialog__createitem">\</a>  COleInsertDialog::CreateItem  
 Call this function to create an object of type [COleClientItem](../vs140/coleclientitem-class.md) only if [DoModal](#coleinsertdialog__domodal) returns **IDOK**.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Points to the item to be created.  
  
### Return Value  
 Nonzero if item was created; otherwise 0.  
  
### Remarks  
 You must allocate the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> object before you can call this function.  
  
##  \<a name="coleinsertdialog__domodal">\</a>  COleInsertDialog::DoModal  
 Call this function to display the OLE Insert Object dialog box.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 One of the following values:  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> inserts only DocObjects.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> inserts only ActiveX controls.  
  
 Zero inserts neither a DocObject nor an ActiveX control. This value results in the same implementation as the first prototype listed above.  
  
### Return Value  
 Completion status for the dialog box. One of the following values:  
  
-   IDOK if the dialog box was successfully displayed.  
  
-   IDCANCEL if the user canceled the dialog box.  
  
-   IDABORT if an error occurred. If IDABORT is returned, call the [COleDialog::GetLastError](../vs140/coledialog-class.md#coledialog__getlasterror) member function to get more information about the type of error that occurred. For a listing of possible errors, see the                                 [OleUIInsertObject](http://msdn.microsoft.com/library/windows/desktop/ms694325) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 If you want to initialize the various dialog box controls by setting members of the [m_io](#coleinsertdialog__m_io) structure, you should do this before calling <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
 If <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> returns IDOK, you can call other member functions to retrieve the settings or information input into the dialog box by the user.  
  
##  \<a name="coleinsertdialog__getclassid">\</a>  COleInsertDialog::GetClassID  
 Call this function to get the **CLSID** associated with the selected item only if [DoModal](#coleinsertdialog__domodal) returns **IDOK** and the selection type is **COleInsertDialog::createNewItem**.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 Returns the **CLSID** associated with the selected item.  
  
### Remarks  
 For more information, see                         [CLSID Key](http://msdn.microsoft.com/library/windows/desktop/ms691424) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleinsertdialog__getdrawaspect">\</a>  COleInsertDialog::GetDrawAspect  
 Call this function to determine if the user chose to display the selected item as an icon.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 The method needed to render the object.  
  
-   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> Returned if the Display As Icon check box was not checked.  
  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> Returned if the Display As Icon check box was checked.  
  
### Remarks  
 Call this function only if [DoModal](#coleinsertdialog__domodal) returns **IDOK**.  
  
 For more information on drawing aspect, see                         [FORMATETC](http://msdn.microsoft.com/library/windows/desktop/ms682177) data structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coleinsertdialog__geticonicmetafile">\</a>  COleInsertDialog::GetIconicMetafile  
 Call this function to get a handle to the metafile that contains the iconic aspect of the selected item.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The handle to the metafile containing the iconic aspect of the selected item, if the Display As Icon check box was checked when the dialog was dismissed by choosing **OK**; otherwise **NULL**.  
  
##  \<a name="coleinsertdialog__getpathname">\</a>  COleInsertDialog::GetPathName  
 Call this function to get the full path of the selected file only if [DoModal](#coleinsertdialog__domodal) returns **IDOK** and the selection type is not **COleInsertDialog::createNewItem**.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 The full path to the file selected in the dialog box. If the selection type is <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, this function returns a meaningless <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> in release mode or causes an assertion in debug mode.  
  
##  \<a name="coleinsertdialog__getselectiontype">\</a>  COleInsertDialog::GetSelectionType  
 Call this function to get the selection type chosen when the Insert Object dialog box was dismissed by choosing **OK**.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Return Value  
 Type of selection made.  
  
### Remarks  
 The return type values are specified by the **Selection** enumeration type declared in the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> class.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
 Brief descriptions of these values follow:  
  
-   **COleInsertDialog::createNewItem** The Create New radio button was selected.  
  
-   **COleInsertDialog::insertFromFile** The Create From File radio button was selected and the Link check box was not checked.  
  
-   **COleInsertDialog::linkToFile** The Create From File radio button was selected and the Link check box was checked.  
  
##  \<a name="coleinsertdialog__m_io">\</a>  COleInsertDialog::m_io  
 Structure of type **OLEUIINSERTOBJECT** used to control the behavior of the Insert Object dialog box.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 Members of this structure can be modified either directly or through member functions.  
  
 For more information, see the                         [OLEUIINSERTOBJECT](http://msdn.microsoft.com/library/windows/desktop/ms691316) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [MFC Sample OCLIENT](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/coledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDialog](../vs140/coledialog-class.md)