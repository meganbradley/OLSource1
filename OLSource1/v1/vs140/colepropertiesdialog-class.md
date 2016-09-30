---
title: "COlePropertiesDialog Class"
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
  - "COlePropertiesDialog"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OLE Object Properties dialog box"
  - "Object Properties dialog box"
  - "dialog boxes, OLE"
  - "OLE documents, modifying properties"
  - "property pages, OLE"
  - "COlePropertiesDialog class"
ms.assetid: a54dbc89-1447-4329-bd01-00e98ec9e935
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COlePropertiesDialog Class
Encapsulates the Windows common OLE Object Properties dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COlePropertiesDialog::COlePropertiesDialog](#colepropertiesdialog__colepropertiesdialog)|Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COlePropertiesDialog::DoModal](#colepropertiesdialog__domodal)|Displays the dialog box and allows the user to make a selection.|  
|[COlePropertiesDialog::OnApplyScale](#colepropertiesdialog__onapplyscale)|Called by the framework when the scaling of the document item has changed.|  
  
### Public Data Members  
  
|Name|Description|  
|----------|-----------------|  
|[COlePropertiesDialog::m_gp](#colepropertiesdialog__m_gp)|A structure used to initialize the "General" page of a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
|[COlePropertiesDialog::m_lp](#colepropertiesdialog__m_lp)|A structure used to initialize the "Link" page of a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.|  
|[COlePropertiesDialog::m_op](#colepropertiesdialog__m_op)|A structure used to initialize the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
|[COlePropertiesDialog::m_psh](#colepropertiesdialog__m_psh)|A structure used to add additional custom property pages.|  
|[COlePropertiesDialog::m_vp](#colepropertiesdialog__m_vp)|A structure used to customize the "View" page of a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 Common OLE Object Properties dialog boxes provide an easy way to display and modify the properties of an OLE document item in a manner consistent with Windows standards. These properties include, among others, information on the file represented by the document item, options for displaying the icon and image scaling, and information on the item's link (if the item is linked).  
  
 To use a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object, first create the object using the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> constructor. After the dialog box has been constructed, call the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> member function to display the dialog box and allow the user to modify any properties of the item. <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> returns whether the user selected the OK ( **IDOK**) or the Cancel ( **IDCANCEL**) button. In addition to the OK and Cancel buttons, there is an Apply button. When the user selects Apply, any changes made to the properties of the document item are applied to the item and its image is automatically updated, but remains active.  
  
 The [m_psh](#colepropertiesdialog__m_psh) data member is a pointer to a **PROPSHEETHEADER** structure, and in most cases you will not need to access it explicitly. One exception is when you need additional property pages beyond the default General, View, and Link pages. In this case, you can modify the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> data member to include your custom pages before calling the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member function.  
  
 For more information on OLE dialog boxes, see the article [Dialog Boxes in OLE](../vs140/dialog-boxes-in-ole.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CCommonDialog](../vs140/ccommondialog-class.md)  
  
 [COleDialog](../vs140/coledialog-class.md)  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxodlgs.h  
  
##  \<a name="colepropertiesdialog__colepropertiesdialog">\</a>  COlePropertiesDialog::COlePropertiesDialog  
 Creates a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Pointer to the document item whose properties are being accessed.  
  
 *nScaleMin*  
 Minimum scaling percentage for the document item image.  
  
 *nScaleMax*  
 Maximum scaling percentage for the document item image.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Pointer to the dialog box's parent or owner.  
  
### Remarks  
 Derive your common OLE Object Properties dialog class from <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> in order to implement scaling for your document items. Any dialog boxes implemented by an instance of this class will not support scaling of the document item.  
  
 By default, the common OLE Object Properties dialog box has three default pages:  
  
-   General  
  
     This page contains system information for the file represented by the selected document item. From this page, the user can convert the selected item to another type.  
  
-   View  
  
     This page contains options for displaying the item, changing the icon, and changing the scaling of the image.  
  
-   Link  
  
     This page contains options for changing the location of the linked item and updating the linked item. From this page, the user can break the link of the selected item.  
  
 To add pages beyond those provided by default, modify the [m_psh](#colepropertiesdialog__m_psh) member variable before exiting the constructor of your <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>-derived class. This is an advanced implementation of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> constructor.  
  
##  \<a name="colepropertiesdialog__domodal">\</a>  COlePropertiesDialog::DoModal  
 Call this member function to display the Windows common OLE Object Properties dialog box and allow the user to view and/or change the various properties of the document item.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 **IDOK** or **IDCANCEL** if successful; otherwise 0. **IDOK** and **IDCANCEL** are constants that indicate whether the user selected the OK or Cancel button.  
  
 If **IDCANCEL** is returned, you can call the Windows                         [CommDlgExtendedError](http://msdn.microsoft.com/library/windows/desktop/ms646916) function to determine whether an error occurred.  
  
##  \<a name="colepropertiesdialog__m_gp">\</a>  COlePropertiesDialog::m_gp  
 A structure of type                 [OLEUIGNRLPROPS](http://msdn.microsoft.com/library/windows/desktop/ms687297), used to initialize the General page of the OLE Object Properties dialog box.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 This page shows the type and size of an embedding and allows the user access to the Convert dialog box. This page also shows the link destination if the object is a link.  
  
 For more information on the **OLEUIGNRLPROPS** structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colepropertiesdialog__m_lp">\</a>  COlePropertiesDialog::m_lp  
 A structure of type                 [OLEUILINKPROPS](http://msdn.microsoft.com/library/windows/desktop/ms680735), used to initialize the Link page of the OLE Object Properties dialog box.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 This page shows the location of the linked item and allows the user to update, or break, the link to the item.  
  
 For more information on the **OLEUILINKPROPS** structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colepropertiesdialog__m_op">\</a>  COlePropertiesDialog::m_op  
 A structure of type                 [OLEUIOBJECTPROPS](http://msdn.microsoft.com/library/windows/desktop/ms687199), used to initialize the common OLE Object Properties dialog box.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 This structure contains members used to initialize the General, Link, and View pages.  
  
 For more information, see the **OLEUIOBJECTPROPS** and                         [OLEUILINKPROPS](http://msdn.microsoft.com/library/windows/desktop/ms680735) structures in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colepropertiesdialog__m_psh">\</a>  COlePropertiesDialog::m_psh  
 A structure of type                 [PROPSHEETHEADER](http://msdn.microsoft.com/library/windows/desktop/bb774546), whose members store the characteristics of the dialog object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 After constructing a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object, you can use <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> to set various aspects of the dialog box before calling the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> member function.  
  
 If you modify the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> data member directly, you will override any default behavior.  
  
 For more information on the **PROPSHEETHEADER** structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colepropertiesdialog__m_vp">\</a>  COlePropertiesDialog::m_vp  
 A structure of type                 [OLEUIVIEWPROPS](http://msdn.microsoft.com/library/windows/desktop/ms693751), used to initialize the View page of the OLE Object Properties dialog box.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 This page allows the user to toggle between "content" and "iconic" views of the object, and change its scaling within the container. It also allows the user access to the Change Icon dialog box when the object is being displayed as an icon.  
  
 For more information on the **OLEUIVIEWPROPS** structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="colepropertiesdialog__onapplyscale">\</a>  COlePropertiesDialog::OnApplyScale  
 Called by the framework when the scaling value has changed and either OK or Apply was selected.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Pointer to the document item whose properties are being accessed.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Numerical value of the dialog scale.  
  
 *bRelativeToOrig*  
 Indicates whether scaling applies to the original size of the document item.  
  
### Return Value  
 Nonzero if handled; otherwise 0.  
  
### Remarks  
 The default implementation does nothing. You must override this function to enable the scaling controls.  
  
> [!NOTE]
>  Before the common OLE Object Properties dialog box is displayed, the framework calls this function with a **NULL** for <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and a – 1 for <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>. This is done to determine if the scaling controls should be enabled.  
  
## See Also  
 [MFC Sample CIRC](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/coledialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDialog](../vs140/coledialog-class.md)   
 [CPropertyPage](../vs140/cpropertypage-class.md)