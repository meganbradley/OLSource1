---
title: "COleLinksDialog Class"
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
  - "COleLinksDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Edit Links dialog box"
  - "COleLinksDialog class"
  - "dialog boxes, OLE"
  - "OLE Edit Links dialog box"
ms.assetid: fb2eb638-2809-46db-ac74-392a732affc7
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleLinksDialog Class
Used for the OLE Edit Links dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleLinksDialog::COleLinksDialog](#colelinksdialog__colelinksdialog)|Constructs a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleLinksDialog::DoModal](#colelinksdialog__domodal)|Displays the OLE Edit Links dialog box.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COleLinksDialog::m_el](#colelinksdialog__m_el)|A structure of type **OLEUIEDITLINKS** that controls the behavior of the dialog box.|  
  
## Remarks  
 Create an object of class <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when you want to call this dialog box. After a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object has been constructed, you can use the [m_el](#colelinksdialog__m_el) structure to initialize the values or states of controls in the dialog box. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> structure is of type **OLEUIEDITLINKS**. For more information about using this dialog class, see the [DoModal](#colelinksdialog__domodal) member function.  
  
> [!NOTE]
>  Application Wizard-generated container code uses this class.  
  
 For more information, see the                 [OLEUIEDITLINKS](http://msdn.microsoft.com/library/windows/desktop/ms678492) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 For more information regarding OLE-specific dialog boxes, see the article [Dialog Boxes in OLE](../vs140/dialog-boxes-in-ole.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 [COleDialog](../vs140/coledialog-class.md)  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxodlgs.h  
  
##  \<a name="colelinksdialog__domodal">\</a>  COleLinksDialog::DoModal  
 Displays the OLE Edit Links dialog box.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Return Value  
 Completion status for the dialog box. One of the following values:  
  
-   **IDOK** if the dialog box was successfully displayed.  
  
-   **IDCANCEL** if the user canceled the dialog box.  
  
-   **IDABORT** if an error occurred. If **IDABORT** is returned, call the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> member function to get more information about the type of error that occurred. For a listing of possible errors, see the                                 [OleUIEditLinks](http://msdn.microsoft.com/library/windows/desktop/ms679703) function in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Remarks  
 If you want to initialize the various dialog box controls by setting members of the [m_el](#colelinksdialog__m_el) structure, you should do it before calling <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, but after the dialog object is constructed.  
  
##  \<a name="colelinksdialog__colelinksdialog">\</a>  COleLinksDialog::COleLinksDialog  
 Constructs a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Points to the OLE document that contains the links to be edited.  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Points to the current view on <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Creation flag, which contains either 0 or **ELF_SHOWHELP** to specify whether the Help button will be displayed when the dialog box is displayed.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Points to the parent or owner window object (of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) to which the dialog object belongs. If it is **NULL**, the parent window of the dialog box is set to the main application window.  
  
### Remarks  
 This function constructs only a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object. To display the dialog box, call the [DoModal](#colelinksdialog__domodal) function.  
  
##  \<a name="colelinksdialog__m_el">\</a>  COleLinksDialog::m_el  
 Structure of type **OLEUIEDITLINKS** used to control the behavior of the Edit Links dialog box.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 Members of this structure can be modified either directly or through member functions.  
  
 For more information, see the                         [OLEUIEDITLINKS](http://msdn.microsoft.com/library/windows/desktop/ms678492) structure in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [Base Class](../vs140/coledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDialog](../vs140/coledialog-class.md)