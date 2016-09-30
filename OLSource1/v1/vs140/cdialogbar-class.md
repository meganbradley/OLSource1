---
title: "CDialogBar Class"
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
  - "CDialogBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "dialog bars, Windows modeless dialog box"
  - "CDialogBar class"
  - "dialog boxes, modeless"
ms.assetid: da2f7a30-970c-44e3-87f0-6094bd002cab
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDialogBar Class
Provides the functionality of a Windows modeless dialog box in a control bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDialogBar::CDialogBar](#cdialogbar__cdialogbar)|Constructs a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDialogBar::Create](#cdialogbar__create)|Creates a Windows dialog bar and attaches it to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 A dialog bar resembles a dialog box in that it contains standard Windows controls that the user can tab between. Another similarity is that you create a dialog template to represent the dialog bar.  
  
 Creating and using a dialog bar is similar to creating and using a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object. First, use the [dialog editor](../vs140/dialog-editor.md) to define a dialog template with the style **WS_CHILD** and no other style. The template must not have the style **WS_VISIBLE**. In your application code, call the constructor to construct the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object, then call **Create** to create the dialog-bar window and attach it to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object.  
  
 For more information on <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, see the article [Dialog Bars](../vs140/dialog-bars.md) and [Technical Note 31](../vs140/tn031--control-bars.md), Control Bars.  
  
> [!NOTE]
>  In the current release, a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object cannot host Windows Forms controls. For more information about Windows Forms controls in Visual C++, see [Using Windows Forms in MFC](../vs140/using-a-windows-form-user-control-in-mfc.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CControlBar](../vs140/ccontrolbar-class.md)  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxext.h  
  
##  \<a name="cdialogbar__cdialogbar">\</a>  CDialogBar::CDialogBar  
 Constructs a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
##  \<a name="cdialogbar__create">\</a>  CDialogBar::Create  
 Loads the dialog-box resource template specified by <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, creates the dialog-bar window, sets its style, and associates it with the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A pointer to the parent <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A pointer to the name of the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object's dialog-box resource template.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 The toolbar style. Additional toolbar styles supported are:  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> Control bar is at top of the frame window.  
  
-   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> Control bar is at bottom of the frame window.  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> Control bar is not repositioned when the parent is resized.  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> Control bar displays tool tips.  
  
-   **CBRS_SIZE_DYNAMIC** Control bar is dynamic.  
  
-   **CBRS_SIZE_FIXED** Control bar is fixed.  
  
-   **CBRS_FLOATING** Control bar is floating.  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> Status bar displays information about the button.  
  
-   **CBRS_HIDE_INPLACE** Control bar is not displayed to the user.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The control ID of the dialog bar.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The resource ID of the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> object's dialog-box template.  
  
### Return Value  
 Nonzero if successful; otherwise 0.  
  
### Remarks  
 If you specify the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> alignment style, the dialog bar's width is that of the frame window and its height is that of the resource specified by <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>. If you specify the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> alignment style, the dialog bar's height is that of the frame window and its width is that of the resource specified by <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Example  
 [!code[NVC_MFCMessageMaps#13](../vs140/codesnippet/CPP/cdialogbar-class_1.cpp)]  
  
## See Also  
 [MFC Sample CTRLBARS](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFormView](../vs140/cformview-class.md)   
 [CControlBar](../vs140/ccontrolbar-class.md)