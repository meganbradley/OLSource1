---
title: "CMFCDropDownFrame Class"
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
  - "CMFCDropDownFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCDropDownFrame class"
ms.assetid: 09ff81a9-de00-43ec-9df9-b626f7728c4b
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDropDownFrame Class
Provides drop-down frame window functionality to drop-down toolbars and drop-down toolbar buttons.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Default constructor.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Destructor.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCDropDownFrame::Create](#cmfcdropdownframe__create)|Creates a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Used by the framework to create a dynamic instance of this class type.|  
|[CMFCDropDownFrame::GetParentMenuBar](#cmfcdropdownframe__getparentmenubar)|Retrieves the parent menu bar of the drop-down frame.|  
|[CMFCDropDownFrame::GetParentPopupMenu](#cmfcdropdownframe__getparentpopupmenu)|Retrieves the parent pop-up menu of the drop-down frame.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Used by the framework to obtain a pointer to the [CRuntimeClass](../vs140/cruntimeclass-structure.md) object that is associated with this class type.|  
|[CMFCDropDownFrame::RecalcLayout](#cmfcdropdownframe__recalclayout)|Repositions the drop-down frame.|  
|[CMFCDropDownFrame::SetAutoDestroy](#cmfcdropdownframe__setautodestroy)|Sets whether the child drop-down toolbar window is destroyed automatically.|  
  
### Remarks  
 This class is not intended to be used directly from your code.  
  
 The framework uses this class to provide frame behavior to the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> classes. For more information about these classes, see [CMFCDropDownToolBar Class](../vs140/cmfcdropdowntoolbar-class.md) and [CMFCDropDownToolbarButton Class](../vs140/cmfcdropdowntoolbarbutton-class.md).  
  
## Example  
 The following example demonstrates how to retrieve a pointer to a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object from a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> class, and how to set the child drop-down toolbar window to be destroyed automatically.  
  
 [!code[NVC_MFC_RibbonApp#36](../vs140/codesnippet/CPP/cmfcdropdownframe-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CFrameWnd](../vs140/cframewnd-class.md)  
  
 [CMiniFrameWnd](../vs140/cminiframewnd-class.md)  
  
 [CMFCDropDownFrame](../vs140/cmfcdropdownframe-class.md)  
  
## Requirements  
 **Header:** afxdropdowntoolbar.h  
  
##  \<a name="cmfcdropdownframe__create">\</a>  CMFCDropDownFrame::Create  
 Creates a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|The parent window of the drop-down frame.|  
|[in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|The horizontal screen coordinate for the location of the down-down frame.|  
|[in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|The vertical screen coordinate for the location of the down-down frame.|  
|[in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|The toolbar that has the drop-down buttons that this method uses to populate the new drop-down frame object.|  
  
### Return Value  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> if the drop-down frame was successfully created; otherwise <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method calls the base [CMiniFrameWnd::CreateEx](../vs140/cminiframewnd-class.md#cminiframewnd__createex) method to create the drop-down frame window with the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> style. The drop-down frame window appears at the specified screen coordinates. This method fails if the [CMiniFrameWnd::CreateEx](../vs140/cminiframewnd-class.md#cminiframewnd__createex) method returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class creates a copy of the provided <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> parameter. This method copies the button images and button states from the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> parameter to the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> data member.  
  
##  \<a name="cmfcdropdownframe__getparentmenubar">\</a>  CMFCDropDownFrame::GetParentMenuBar  
 Retrieves the parent menu bar of the drop-down frame.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the parent menu bar of the drop-down frame, or <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if the frame has no parent.  
  
### Remarks  
 This method retrieves the parent menu bar from the parent button. This method returns <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> if the drop-down frame has no parent button or the parent button has no parent menu bar.  
  
##  \<a name="cmfcdropdownframe__getparentpopupmenu">\</a>  CMFCDropDownFrame::GetParentPopupMenu  
 Retrieves the parent pop-up menu of the drop-down frame.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the parent drop-down menu of the drop-down frame, or <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if the frame has no parent.  
  
### Remarks  
 This method retrieves the parent menu from the parent button. This method returns <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> if the drop-down frame has no parent button or the parent button has no parent menu.  
  
##  \<a name="cmfcdropdownframe__recalclayout">\</a>  CMFCDropDownFrame::RecalcLayout  
 Repositions the drop-down frame.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Unused.|  
  
### Remarks  
 The framework calls this method when the drop-down frame is created or the parent window is resized. This method calculates the position and size of the drop-down frame by using the position and size of the parent window.  
  
##  \<a name="cmfcdropdownframe__setautodestroy">\</a>  CMFCDropDownFrame::SetAutoDestroy  
 Sets whether the child drop-down toolbar window is destroyed automatically.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to automatically destroy the associated drop-down toolbar window; otherwise, <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
### Remarks  
 If <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, then the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> destructor destroys the associated drop-down toolbar window. The default value is <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCDropDownToolBar Class](../vs140/cmfcdropdowntoolbar-class.md)   
 [CMFCDropDownToolbarButton Class](../vs140/cmfcdropdowntoolbarbutton-class.md)