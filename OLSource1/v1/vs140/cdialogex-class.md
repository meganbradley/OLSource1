---
title: "CDialogEx Class"
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
  - "CDialogEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDialogEx class"
  - "CDialogEx::PreTranslateMessage method"
ms.assetid: a6ed3b1f-aef8-4b66-ac78-2160faf63c13
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogEx Class
The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class specifies the background color and background image of a dialog box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDialogEx::CDialogEx](#cdialogex__cdialogex)|Constructs a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDialogEx::SetBackgroundColor](#cdialogex__setbackgroundcolor)|Sets the background color of the dialog box.|  
|[CDialogEx::SetBackgroundImage](#cdialogex__setbackgroundimage)|Sets the background image of the dialog box.|  
  
## Remarks  
 To use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class, derive your dialog box class from the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class instead of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class.  
  
 Dialog box images are stored in a resource file. The framework automatically deletes any image that is loaded from the resource file. To programmatically delete the current background image, call the [SetBackgroundImage](#cdialogex__setbackgroundimage) method or implement an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> event handler. When you call the [SetBackgroundImage](#cdialogex__setbackgroundimage) method, pass in an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> parameter as the image handle. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object will take ownership of the image and delete it if the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> flag is <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
 A <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object can be a parent of a [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object. The [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object calls the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> method when the [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object opens. Afterward, the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object handles any menu event until the [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md) object is closed.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CDialog](../vs140/cdialog-class.md)  
  
 [CDialogEx](../vs140/cdialogex-class.md)  
  
## Requirements  
 **Header:** afxdialogex.h  
  
##  \<a name="cdialogex__cdialogex">\</a>  CDialogEx::CDialogEx  
 Constructs a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The resource ID of a dialog box template.  
  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 The resource name of a dialog box template.  
  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A pointer to the parent window. The default value is <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 A pointer to the parent window. The default value is <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cdialogex__setbackgroundcolor">\</a>  CDialogEx::SetBackgroundColor  
 Sets the background color of the dialog box.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 An RGB color value.  
  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> to immediately update the screen; otherwise, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
### Remarks  
  
##  \<a name="cdialogex__setbackgroundimage">\</a>  CDialogEx::SetBackgroundImage  
 Sets the background image of the dialog box.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 A handle to the background image.  
  
 [in] <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 The resource ID of the background image.  
  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 One of the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> values that specify the location of the image. Valid values include BACKGR_TILE, BACKGR_TOPLEFT, BACKGR_TOPRIGHT, BACKGR_BOTTOMLEFT, and BACKGR_BOTTOMRIGHT. The default value is BACKGR_TILE.  
  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> to automatically destroy the background image; otherwise, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> to immediately redraw the dialog box; otherwise, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
### Return Value  
 In the second method overload syntax, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if the method is successful; otherwise, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
### Remarks  
 The image that you specify is not stretched to fit the dialog box client area.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md)   
 [CMFCContextMenuManager](../vs140/ccontextmenumanager-class.md)