---
title: "CTabView Class"
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
  - "CTabView"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTabView class"
ms.assetid: 8e6ecd9d-d28d-432b-8ec8-0446f0204d52
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabView Class
The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class simplifies the use of the tab control class ( [CMFCTabCtrl](../vs140/ctabview-class.md)) in applications that use MFC's document/view architecture.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[AddView](#ctabview__addview)|Adds a new view to the tab control.|  
|[FindTab](#ctabview__findtab)|Returns the index of the specified view in the tab control.|  
|[GetActiveView](#ctabview__getactiveview)|Returns a pointer to the currently active view|  
|[GetTabControl](#ctabview__gettabcontrol)|Returns a reference to the tab control associated with the view.|  
|[RemoveView](#ctabview__removeview)|Removes the view from the tab control.|  
|[SetActiveView](#ctabview__setactiveview)|Makes a view active.|  
  
### Protected Methods  
  
|Name|Description|  
|----------|-----------------|  
|[IsScrollBar](#ctabview__isscrollbar)|Called by the framework when creating a tab view to determine whether the tab view has a shared horizontal scroll bar.|  
|[OnActivateView](#ctabview__onactivateview)|Called by the framework when the tab view is made active or inactive.|  
  
## Remarks  
 This class makes it easy to put a tabbed view into a document/view application. <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>-derived class that contains an embedded <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> handles all messages required to support the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object. Simply derive a class from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and plug it into your application, then add <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>-derived classes by using the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method. The tab control will display those views as tabs.  
  
 For example, you might have a document that can be represented in different ways: as a spreadsheet, a chart, an editable form, and so on. You can create individual views drawing the data as needed, insert them into your <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>-derived object and have them tabbed without any additional coding.  
  
 [TabbedView Sample: MFC Tabbed View Application](../vs140/visual-c---samples.md) illustrates usage of <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Example  
 The following example shows how <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is used in the TabbedView sample.  
  
 [!code[NVC_MFC_TabbedView#1](../vs140/codesnippet/CPP/ctabview-class_1.h)]  
  
## Requirements  
 **Header:** afxTabView.h  
  
##  \<a name="ctabview__addview">\</a>  CTabView::AddView  
 Adds a view to the tab control.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A pointer to a runtime class of the inserted view.  
  
 [in] <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Specifies the tab's text.  
  
 [in] <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Specifies the zero-based position at which to insert the view. If the position is -1 the new tab is inserted at the end.  
  
 [in] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A pointer to the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> of the view.  
  
### Return Value  
 A view index if this method succeeds. Otherwise, -1.  
  
### Remarks  
 Call this function to add a view to the tab control that is embedded in a frame.  
  
##  \<a name="ctabview__findtab">\</a>  CTabView::FindTab  
 Returns the index of the specified view in the tab control.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The handle of the view.  
  
### Return Value  
 The index of the view if it is found; otherwise, -1.  
  
### Remarks  
 Call this function to retrieve the index of a view that has a specified handle.  
  
##  \<a name="ctabview__getactiveview">\</a>  CTabView::GetActiveView  
 Returns a pointer to the currently active view.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Return Value  
 A valid pointer to the active view, or <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> if there is no active view.  
  
### Remarks  
  
##  \<a name="ctabview__gettabcontrol">\</a>  CTabView::GetTabControl  
 Returns a reference to the tab control associated with the view.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A reference to the tab control associated with the view.  
  
##  \<a name="ctabview__isscrollbar">\</a>  CTabView::IsScrollBar  
 Called by the framework when creating a tab view to determine whether the tab view has a shared horizontal scroll bar.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if the tab view should be created together with a shared scroll bar. Otherwise, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>.  
  
### Remarks  
 The framework calls this method when a <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object is being created.  
  
 Override the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method in a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>-derived class and return <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> if you want to create a view that has a shared horizontal scroll bar.  
  
##  \<a name="ctabview__onactivateview">\</a>  CTabView::OnActivateView  
 Called by the framework when the tab view is made active or inactive.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 A pointer to the view.  
  
### Remarks  
 The default implementation does nothing. Override this method in a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>-derived class to process this notification.  
  
##  \<a name="ctabview__removeview">\</a>  CTabView::RemoveView  
 Removes the view from the tab control.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 The index of the view to remove.  
  
### Return Value  
 The index of the removed view if this method succeeds. Otherwise -1.  
  
### Remarks  
  
##  \<a name="ctabview__setactiveview">\</a>  CTabView::SetActiveView  
 Makes a view active.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 The zero-based index of the tab view.  
  
### Return Value  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> if the specified view was made active, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> if the view's index is invalid.  
  
### Remarks  
 For more information see [CMFCTabCtrl::SetActiveTab](../vs140/cmfctabctrl-class.md#cmfctabctrl__setactivetab).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCTabCtrl](../vs140/ctabview-class.md)   
 [CView](../vs140/cview-class.md)