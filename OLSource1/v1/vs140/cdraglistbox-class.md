---
title: "CDragListBox Class"
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
  - "CDragListBox"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "drag list box [C++]"
  - "dragging list items"
  - "CDragListBox class"
  - "Windows [C++], list boxes"
  - "list boxes"
ms.assetid: fee20b42-60ae-4aa9-83f9-5a3d9b96e33b
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDragListBox Class
In addition to providing the functionality of a Windows list box, the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class allows the user to move list box items, such as filenames, within the list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CDragListBox::CDragListBox](#cdraglistbox__cdraglistbox)|Constructs a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CDragListBox::BeginDrag](#cdraglistbox__begindrag)|Called by the framework when a drag operation starts.|  
|[CDragListBox::CancelDrag](#cdraglistbox__canceldrag)|Called by the framework when a drag operation has been canceled.|  
|[CDragListBox::Dragging](#cdraglistbox__dragging)|Called by the framework during a drag operation.|  
|[CDragListBox::DrawInsert](#cdraglistbox__drawinsert)|Draws the insertion guide of the drag list box.|  
|[CDragListBox::Dropped](#cdraglistbox__dropped)|Called by the framework after the item has been dropped.|  
|[CDragListBox::ItemFromPt](#cdraglistbox__itemfrompt)|Returns the coordinates of the item being dragged.|  
  
## Remarks  
 List boxes with this capability allow users to order the items in a list in whatever manner is most useful to them. By default, the list box will move the item to the new location in the list. However, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects can be customized to copy items instead of moving them.  
  
 The list box control associated with the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class must not have the **LBS_SORT** or the **LBS_MULTIPLESELECT** style. For a description of list box styles, see [List-Box Styles](../vs140/list-box-styles.md).  
  
 To use a drag list box in an existing dialog box of your application, add a list box control to your dialog template using the dialog editor and then assign a member variable (of Category <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and Variable Type <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>) corresponding to the list box control in your dialog template.  
  
 For more information on assigning controls to member variables, see [Shortcut for Defining Member Variables for Dialog Controls](../vs140/defining-member-variables-for-dialog-controls.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CListBox](../vs140/clistbox-class.md)  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxcmn.h  
  
##  \<a name="cdraglistbox__begindrag">\</a>  CDragListBox::BeginDrag  
 Called by the framework when an event occurs that could begin a drag operation, such as pressing the left mouse button.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 A [CPoint](../vs140/cpoint-class.md) object that contains the coordinates of the item being dragged.  
  
### Return Value  
 Nonzero if dragging is allowed, otherwise 0.  
  
### Remarks  
 Override this function if you want to control what happens when a drag operation begins. The default implementation captures the mouse and stays in drag mode until the user clicks the left or right mouse button or presses ESC, at which time the drag operation is canceled.  
  
##  \<a name="cdraglistbox__canceldrag">\</a>  CDragListBox::CancelDrag  
 Called by the framework when a drag operation has been canceled.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A [CPoint](../vs140/cpoint-class.md) object that contains the coordinates of the item being dragged.  
  
### Remarks  
 Override this function to handle any special processing for your list box control.  
  
##  \<a name="cdraglistbox__cdraglistbox">\</a>  CDragListBox::CDragListBox  
 Constructs a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="cdraglistbox__dragging">\</a>  CDragListBox::Dragging  
 Called by the framework when a list box item is being dragged within the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 A [CPoint](../vs140/cpoint-class.md) object that contains the x and y screen coordinates of the cursor.  
  
### Return Value  
 The resource ID of the cursor to be displayed. The following values are possible:  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> Indicates that the item will be copied.  
  
-   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> Indicates that the item will be moved.  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> Indicates that the current drop target is not acceptable.  
  
### Remarks  
 The default behavior returns <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. Override this function if you want to provide additional functionality.  
  
##  \<a name="cdraglistbox__drawinsert">\</a>  CDragListBox::DrawInsert  
 Called by the framework to draw the insertion guide before the item with the indicated index.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 Zero-based index of the insertion point.  
  
### Remarks  
 A value of - 1 clears the insertion guide. Override this function to modify the appearance or behavior of the insertion guide.  
  
##  \<a name="cdraglistbox__dropped">\</a>  CDragListBox::Dropped  
 Called by the framework when an item is dropped within a <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 *nSrcIndex*  
 Specifies the zero-based index of the dropped string.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A [CPoint](../vs140/cpoint-class.md) object that contains the coordinates of the drop site.  
  
### Remarks  
 The default behavior copies the list box item and its data to the new location and then deletes the original item. Override this function to customize the default behavior, such as enabling copies of list box items to be dragged to other locations within the list.  
  
##  \<a name="cdraglistbox__itemfrompt">\</a>  CDragListBox::ItemFromPt  
 Call this function to retrieve the zero-based index of the list box item located at <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 A [CPoint](../vs140/cpoint-class.md) object containing the coordinates of a point within the list box.  
  
 *bAutoScroll*  
 Nonzero if scrolling is allowed, otherwise 0.  
  
### Return Value  
 Zero-based index of the drag list box item.  
  
## See Also  
 [MFC Sample TSTCON](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox](../vs140/clistbox-class.md)