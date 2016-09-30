---
title: "CMFCRibbonMiniToolBar Class"
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
  - "CMFCRibbonMiniToolBar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonMiniToolBar class"
ms.assetid: 7017e963-aeaf-4fe9-b540-e15a7ed41e94
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonMiniToolBar Class
Implements a contextual popup toolbar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCRibbonMiniToolBar::IsContextMenuMode](#cmfcribbonminitoolbar__iscontextmenumode)||  
|[CMFCRibbonMiniToolBar::IsRibbonMiniToolBar](#cmfcribbonminitoolbar__isribbonminitoolbar)|(Overrides <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.)|  
|[CMFCRibbonMiniToolBar::SetCommands](#cmfcribbonminitoolbar__setcommands)|Sets the list of commands to be displayed on the toolbar.|  
|[CMFCRibbonMiniToolBar::Show](#cmfcribbonminitoolbar__show)|Displays the mini toolbar at the specified screen coordinates.|  
|[CMFCRibbonMiniToolBar::ShowWithContextMenu](#cmfcribbonminitoolbar__showwithcontextmenu)|Displays the mini toolbar together with a context menu.|  
  
## Remarks  
 The mini toolbar is typically displayed after the user selects an object in a document. For example, after the user selects a block of text in a word processing program, the application displays a mini toolbar that contains text formatting commands.  
  
 The mini toolbar becomes transparent when the mouse pointer is out of the bounds of the mini toolbar.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CFrameWnd](../vs140/cframewnd-class.md)  
  
 [CMiniFrameWnd](../vs140/cminiframewnd-class.md)  
  
 [CMFCPopupMenu](../vs140/cmfcpopupmenu-class.md)  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 [CMFCRibbonMiniToolBar](../vs140/cmfcribbonminitoolbar-class.md)  
  
## Requirements  
 **Header:** afxRibbonMiniToolBar.h  
  
##  \<a name="cmfcribbonminitoolbar__setcommands">\</a>  CMFCRibbonMiniToolBar::SetCommands  
 Sets the list of commands to be displayed on the toolbar.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The ribbon bar that the mini toolbar searches for the buttons to display.  
  
 [in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 The list of commands to be displayed on the mini toolbar. All ribbon categories are searched to find the associated buttons.  
  
### Remarks  
 Use this function to set the list of commands to be displayed in the mini toolbar.  
  
### Example  
 The following example demonstrates how to use the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class. This code snippet is part of the [MS Office 2007 Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MSOffice2007Demo#9](../vs140/codesnippet/CPP/cmfcribbonminitoolbar-class_1.cpp)]  
  
##  \<a name="cmfcribbonminitoolbar__show">\</a>  CMFCRibbonMiniToolBar::Show  
 Displays the mini toolbar at the specified screen coordinates.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Specifies the horizontal position of the mini toolbar in screen coordinates.  
  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies the vertical position of the mini toolbar in screen coordinates.  
  
### Return Value  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> if the mini toolbar was displayed successfully; otherwise, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcribbonminitoolbar__showwithcontextmenu">\</a>  CMFCRibbonMiniToolBar::ShowWithContextMenu  
 Displays the mini toolbar together with a context menu.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Specifies the horizontal position of the context menu in screen coordinates.  
  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Specifies the vertical position of the context menu in screen coordinates.  
  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Specifies the resource ID of the context menu to display.  
  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Identifies the window which receives messages from the context menu.  
  
### Return Value  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> if the context menu was displayed successfully; otherwise, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
### Remarks  
 Use this function to display a mini toolbar that has a context menu. The context menu is positioned 15 pixels below the mini toolbar.  
  
##  \<a name="cmfcribbonminitoolbar__iscontextmenumode">\</a>  CMFCRibbonMiniToolBar::IsContextMenuMode  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcribbonminitoolbar__isribbonminitoolbar">\</a>  CMFCRibbonMiniToolBar::IsRibbonMiniToolBar  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
  
### Remarks  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)