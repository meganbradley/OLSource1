---
title: "COleUpdateDialog Class"
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
  - "COleUpdateDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Update dialog"
  - "links [C++], updating"
  - "updating OLE links"
  - "OLE dialog boxes, Edit Link"
  - "OLE link updating"
  - "COleUpdateDialog class"
ms.assetid: 699ca980-52b1-4cf8-9ab1-ac6767ad5b0e
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleUpdateDialog Class
Used for a special case of the OLE Edit Links dialog box, which should be used when you need to update only existing linked or embedded objects in a document.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleUpdateDialog::COleUpdateDialog](#coleupdatedialog__coleupdatedialog)|Constructs a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleUpdateDialog::DoModal](#coleupdatedialog__domodal)|Displays the **Edit Links** dialog box in an update mode.|  
  
## Remarks  
 For more information regarding OLE-specific dialog boxes, see the article [Dialog Boxes in OLE](../vs140/dialog-boxes-in-ole.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 [COleDialog](../vs140/coledialog-class.md)  
  
 [COleLinksDialog](../vs140/colelinksdialog-class.md)  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxodlgs.h  
  
##  \<a name="coleupdatedialog__coleupdatedialog">\</a>  COleUpdateDialog::COleUpdateDialog  
 Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Points to the document containing the links that may need updating.  
  
 *bUpdateLinks*  
 Flag that determines whether linked objects are to be updated.  
  
 *bUpdateEmbeddings*  
 Flag that determines whether embedded objects are to be updated.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog box will be set to the main application window.  
  
### Remarks  
 This function constructs only a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. To display the dialog box, call [DoModal](../vs140/colelinksdialog-class.md#colelinksdialog__domodal). This class should be used instead of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> when you want to update only existing linked or embedded items.  
  
##  \<a name="coleupdatedialog__domodal">\</a>  COleUpdateDialog::DoModal  
 Displays the Edit Links dialog box in update mode.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 Completion status for the dialog box. One of the following values:  
  
-   **IDOK** if the dialog box returned successfully.  
  
-   **IDCANCEL** if none of the linked or embedded items in the current document need updating.  
  
-   **IDABORT** if an error occurred. If **IDABORT** is returned, call the [COleDialog::GetLastError](../vs140/coledialog-class.md#coledialog__getlasterror) member function to get more information about the type of error that occurred. For a listing of possible errors, see the                                 [OleUIEditLinks](http://msdn.microsoft.com/library/windows/desktop/ms679703) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 All links and/or embeddings are updated unless the user selects the Cancel button.  
  
## See Also  
 [MFC Sample OCLIENT](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/colelinksdialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleLinksDialog](../vs140/colelinksdialog-class.md)