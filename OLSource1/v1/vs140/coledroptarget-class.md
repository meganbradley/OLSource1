---
title: "COleDropTarget Class"
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
  - "COleDropTarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "COleDropTarget class"
  - "drag and drop, drop target"
  - "drop commands, accepting"
  - "drop commands"
ms.assetid: a58c9a48-6a93-4357-b078-4594df258311
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleDropTarget Class
Provides the communication mechanism between a window and the OLE libraries.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[COleDropTarget::COleDropTarget](#coledroptarget__coledroptarget)|Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[COleDropTarget::OnDragEnter](#coledroptarget__ondragenter)|Called when the cursor first enters the window.|  
|[COleDropTarget::OnDragLeave](#coledroptarget__ondragleave)|Called when the cursor is dragged out of the window.|  
|[COleDropTarget::OnDragOver](#coledroptarget__ondragover)|Called repeatedly when the cursor is dragged over the window.|  
|[COleDropTarget::OnDragScroll](#coledroptarget__ondragscroll)|Called to determine whether the cursor is dragged into the scroll region of the window.|  
|[COleDropTarget::OnDrop](#coledroptarget__ondrop)|Called when data is dropped into the window, default handler.|  
|[COleDropTarget::OnDropEx](#coledroptarget__ondropex)|Called when data is dropped into the window, initial handler.|  
|[COleDropTarget::Register](#coledroptarget__register)|Registers the window as a valid drop target.|  
|[COleDropTarget::Revoke](#coledroptarget__revoke)|Causes the window to cease being a valid drop target.|  
  
## Remarks  
 Creating an object of this class allows a window to accept data through the OLE drag-and-drop mechanism.  
  
 To get a window to accept drop commands, you should first create an object of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class, and then call the [Register](#coledroptarget__register) function with a pointer to the desired <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object as the only parameter.  
  
 For more information on drag-and-drop operations using OLE, see the article [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxole.h  
  
##  \<a name="coledroptarget__coledroptarget">\</a>  COleDropTarget::COleDropTarget  
 Constructs an object of class <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 Call [Register](#coledroptarget__register) to associate this object with a window.  
  
##  \<a name="coledroptarget__ondragenter">\</a>  COleDropTarget::OnDragEnter  
 Called by the framework when the cursor is first dragged into the window.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Points to the window the cursor is entering.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Points to the data object containing the data that can be dropped.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Contains the state of the modifier keys. This is a combination of any number of the following: **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Contains the current location of the cursor in client coordinates.  
  
### Return Value  
 The effect that would result if a drop were attempted at the location specified by <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. It can be one or more of the following:  
  
-   <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> A drop would not be allowed.  
  
-   <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> A copy operation would be performed.  
  
-   <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> A move operation would be performed.  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> A link from the dropped data to the original data would be established.  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> A drag scroll operation is about to occur or is occurring in the target.  
  
### Remarks  
 Override this function to allow drop operations to occur in the window. The default implementation calls [CView::OnDragEnter](../vs140/cview-class.md#cview__ondragenter), which simply returns <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> by default.  
  
 For more information, see                         [IDropTarget::DragEnter](http://msdn.microsoft.com/library/windows/desktop/ms680106) in the                        [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledroptarget__ondragleave">\</a>  COleDropTarget::OnDragLeave  
 Called by the framework when the cursor leaves the window while a dragging operation is in effect.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Points to the window the cursor is leaving.  
  
### Remarks  
 Override this function if you want special behavior when the drag operation leaves the specified window. The default implementation of this function calls [CView::OnDragLeave](../vs140/cview-class.md#cview__ondragleave).  
  
 For more information, see                         [IDropTarget::DragLeave](http://msdn.microsoft.com/library/windows/desktop/ms680110) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledroptarget__ondragover">\</a>  COleDropTarget::OnDragOver  
 Called by the framework when the cursor is dragged over the window.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Points to the window that the cursor is over.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Points to the data object that contains the data to be dropped.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Contains the state of the modifier keys. This is a combination of any number of the following: **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Contains the current location of the cursor in client coordinates.  
  
### Return Value  
 The effect that would result if a drop were attempted at the location specified by <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. It can be one or more of the following:  
  
-   <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> A drop would not be allowed.  
  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> A copy operation would be performed.  
  
-   <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> A move operation would be performed.  
  
-   <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> A link from the dropped data to the original data would be established.  
  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> Indicates that a drag scroll operation is about to occur or is occurring in the target.  
  
### Remarks  
 This function should be overridden to allow drop operations to occur in the window. The default implementation of this function calls [CView::OnDragOver](../vs140/cview-class.md#cview__ondragover), which returns <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> by default. Because this function is called frequently during a drag-and-drop operation, it should be optimized as much as possible.  
  
 For more information, see                         [IDropTarget::DragOver](http://msdn.microsoft.com/library/windows/desktop/ms680129) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
### Example  
 [!code[NVC_MFCOleContainer#21](../vs140/codesnippet/CPP/coledroptarget-class_1.cpp)]  
  
##  \<a name="coledroptarget__ondragscroll">\</a>  COleDropTarget::OnDragScroll  
 Called by the framework before calling [OnDragEnter](#coledroptarget__ondragenter) or [OnDragOver](#coledroptarget__ondragover) to determine whether <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> is in the scrolling region.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Points to the window the cursor is currently over.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Contains the state of the modifier keys. This is a combination of any number of the following: **MK_CONTROL**, **MK_SHIFT**, **MK_ALT**, **MK_LBUTTON**, **MK_MBUTTON**, and **MK_RBUTTON**.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Contains the location of the cursor, in pixels, relative to the screen.  
  
### Return Value  
 The effect that would result if a drop were attempted at the location specified by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. It can be one or more of the following:  
  
-   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> A drop would not be allowed.  
  
-   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> A copy operation would be performed.  
  
-   <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> A move operation would be performed.  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> A link from the dropped data to the original data would be established.  
  
-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> Indicates that a drag scroll operation is about to occur or is occurring in the target.  
  
### Remarks  
 Override this function when you want to provide special behavior for this event. The default implementation of this function calls [CView::OnDragScroll](../vs140/cview-class.md#cview__ondragscroll), which returns <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and scrolls the window when the cursor is dragged into the default scroll region inside the border of the window.  
  
##  \<a name="coledroptarget__ondrop">\</a>  COleDropTarget::OnDrop  
 Called by the framework when a drop operation is to occur.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
 Points to the window the cursor is currently over.  
  
 <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 Points to the data object that contains the data to be dropped.  
  
 <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 The effect that the user chose for the drop operation. It can be one or more of the following:  
  
-   <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> A copy operation would be performed.  
  
-   <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> A move operation would be performed.  
  
-   <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> A link from the dropped data to the original data would be established.  
  
 <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
 Contains the location of the cursor, in pixels, relative to the screen.  
  
### Return Value  
 Nonzero if the drop is successful; otherwise 0.  
  
### Remarks  
 The framework first calls [OnDropEx](#coledroptarget__ondropex). If the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> function does not handle the drop, the framework then calls this member function, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>. Typically, the application overrides [OnDropEx](../vs140/cview-class.md#cview__ondropex) in the view class to handle right mouse-button drag and drop. Typically, the view class [OnDrop](../vs140/cview-class.md#cview__ondrop) is used to handle simple drag and drop.  
  
 The default implementation of <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> calls [CView::OnDrop](../vs140/cview-class.md#cview__ondrop), which simply returns **FALSE** by default.  
  
 For more information, see                         [IDropTarget::Drop](http://msdn.microsoft.com/library/windows/desktop/ms687242) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledroptarget__ondropex">\</a>  COleDropTarget::OnDropEx  
 Called by the framework when a drop operation is to occur.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
 Points to the window the cursor is currently over.  
  
 <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>  
 Points to the data object that contains the data to be dropped.  
  
 <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>  
 The effect that the user chose for the default drop operation based on the current key state. It can be <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. Drop effects are discussed in the Remarks section.  
  
 <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 A list of the drop effects that the drop source supports. Drop effect values can be combined using the bitwise OR ( **&#124;**) operation. Drop effects are discussed in the Remarks section.  
  
 <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 Contains the location of the cursor, in pixels, relative to the screen.  
  
### Return Value  
 The drop effect that resulted from the drop attempt at the location specified by <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>. Drop effects are discussed in the Remarks section.  
  
### Remarks  
 The framework first calls this function. If it does not handle the drop, the framework then calls [OnDrop](#coledroptarget__ondrop). Typically, you will override [OnDropEx](../vs140/cview-class.md#cview__ondropex) in the view class to support right mouse-button drag and drop. Typically, the view class [OnDrop](../vs140/cview-class.md#cview__ondrop) is used to handle the case of support for simple drag and drop.  
  
 The default implementation of <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> calls [CView::OnDropEx](../vs140/cview-class.md#cview__ondropex). By default, [CView::OnDropEx](../vs140/cview-class.md#cview__ondropex) simply returns a dummy value to indicate the [OnDrop](#coledroptarget__ondrop) member function should be called.  
  
 Drop effects describe the action associated with a drop operation. See the following list of drop effects:  
  
-   <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> A drop would not be allowed.  
  
-   <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> A copy operation would be performed.  
  
-   <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> A move operation would be performed.  
  
-   <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> A link from the dropped data to the original data would be established.  
  
-   <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> Indicates that a drag scroll operation is about to occur or is occurring in the target.  
  
 For more information, see                         [IDropTarget::Drop](http://msdn.microsoft.com/library/windows/desktop/ms687242) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledroptarget__register">\</a>  COleDropTarget::Register  
 Call this function to register your window with the OLE DLLs as a valid drop target.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>  
 Points to the window that is to be registered as a drop target.  
  
### Return Value  
 Nonzero if registration is successful; otherwise 0.  
  
### Remarks  
 This function must be called for drop operations to be accepted.  
  
 For more information, see                         [RegisterDragDrop](http://msdn.microsoft.com/library/windows/desktop/ms678405) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
##  \<a name="coledroptarget__revoke">\</a>  COleDropTarget::Revoke  
 Call this function before destroying any window that has been registered as a drop target through a call to [Register](#coledroptarget__register) to remove it from the list of drop targets.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Remarks  
 This function is called automatically from the [OnDestroy](../vs140/cwnd-class.md#cwnd__ondestroy) handler for the window that was registered, so it is usually not necessary to call this function explicitly.  
  
 For more information, see                         [RevokeDragDrop](http://msdn.microsoft.com/library/windows/desktop/ms692643) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## See Also  
 [MFC Sample HIERSVR](../vs140/visual-c---samples.md)   
 [MFC Sample OCLIENT](../vs140/visual-c---samples.md)   
 [Base Class](../vs140/ccmdtarget-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleDropSource](../vs140/coledropsource-class.md)