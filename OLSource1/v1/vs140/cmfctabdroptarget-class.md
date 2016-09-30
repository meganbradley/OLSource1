---
title: "CMFCTabDropTarget Class"
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
  - "CMFCTabDropTarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCTabDropTarget class"
ms.assetid: 9777b7b6-10da-4c4b-b1d1-7ea795b0f1cb
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCTabDropTarget Class
Provides the communication mechanism between a tab control and the OLE libraries.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|||  
|-|-|  
|Name|Description|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Default constructor.|  
  
### Public Methods  
  
|||  
|-|-|  
|Name|Description|  
|[CMFCTabDropTarget::OnDragEnter](#cmfctabdroptarget__ondragenter)|Called by the framework when the user drags an object into a tab window. (Overrides [COleDropTarget::OnDragEnter](../vs140/coledroptarget-class.md#coledroptarget__ondragenter).)|  
|[CMFCTabDropTarget::OnDragLeave](#cmfctabdroptarget__ondragleave)|Called by the framework when the user drags an object outside of the tab window that has focus. (Overrides [COleDropTarget::OnDragLeave](../vs140/coledroptarget-class.md#coledroptarget__ondragleave).)|  
|[CMFCTabDropTarget::OnDragOver](#cmfctabdroptarget__ondragover)|Called by the framework when the user drags an object onto the tab window that has focus. (Overrides [COleDropTarget::OnDragOver](../vs140/coledroptarget-class.md#coledroptarget__ondragover).)|  
|[CMFCTabDropTarget::OnDropEx](#cmfctabdroptarget__ondropex)|Called by the framework when the user releases the mouse button at the end of a drag operation. (Overrides [COleDropTarget::OnDropEx](../vs140/coledroptarget-class.md#coledroptarget__ondropex).)|  
|[CMFCTabDropTarget::Register](#cmfctabdroptarget__register)|Registers the control as one that can be the target of an OLE drag-and-drop operation.|  
  
### Remarks  
 This class provides drag-and-drop support to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class. If your application initializes the OLE libraries by using the [AfxOleInit](../vs140/afxoleinit.md) function, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects register themselves for drag-and-drop operations.  
  
 The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class extends its base class by making the tab that is under the cursor when a drag operation occurs active. For more information about drag-and-drop operations, see [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md).  
  
## Example  
 The following example demonstrates how to construct a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object and use its <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method.  
  
 [!code[NVC_MFC_RibbonApp#39](../vs140/codesnippet/CPP/cmfctabdroptarget-class_1.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [COleDropTarget](../vs140/coledroptarget-class.md)  
  
 [CMFCTabDropTarget](../vs140/cmfctabdroptarget-class.md)  
  
## Requirements  
 **Header:** afxbasetabctrl.h  
  
##  \<a name="cmfctabdroptarget__ondragenter">\</a>  CMFCTabDropTarget::OnDragEnter  
 Called by the framework when the user drags an object into a tab window.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Unused.|  
|[in] <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|A pointer to the object that the user drags.|  
|[in] <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Contains the state of the modifier keys. This is a combination of any number of the following: <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>.|  
|[in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|The location of the cursor in client coordinates.|  
  
### Return Value  
 The effect that results if the drop occurs at the location specified by <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>. It can be one or more of the following:  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
  
### Remarks  
 This method returns <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if the toolbar framework is not in customization mode or the Clipboard data format is unavailable. Otherwise, it returns the result of calling <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> with the provided parameters.  
  
 For more information about customization mode, see [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar-class.md#cmfctoolbar__iscustomizemode). For more information about Clipboard data formats, see [COleDataObject::IsDataAvailable](../vs140/coledataobject-class.md#coledataobject__isdataavailable).  
  
##  \<a name="cmfctabdroptarget__ondragleave">\</a>  CMFCTabDropTarget::OnDragLeave  
 Called by the framework when the user drags an object outside of the tab window that has focus.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Unused.|  
  
### Remarks  
 This method calls the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method to perform the drag operation.  
  
##  \<a name="cmfctabdroptarget__ondragover">\</a>  CMFCTabDropTarget::OnDragOver  
 Called by the framework when the user drags an object onto the tab window that has focus.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Unused.|  
|[in] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|A pointer to the object that the user drags.|  
|[in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Contains the state of the modifier keys. This is a combination of any number of the following: <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>.|  
|[in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|The location of the mouse pointer in client coordinates.|  
  
### Return Value  
 The effect that results if the drop occurs at the location specified by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. It can be one or more of the following:  
  
-   <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  
### Remarks  
 This method makes the tab that is under the cursor when a drag operation occurs active. It returns <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> if the toolbar framework is not in customization mode or the Clipboard data format is unavailable. Otherwise, it returns the result of calling <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> with the provided parameters.  
  
 For more information about customization mode, see [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar-class.md#cmfctoolbar__iscustomizemode). For more information about Clipboard data formats, see [COleDataObject::IsDataAvailable](../vs140/coledataobject-class.md#coledataobject__isdataavailable).  
  
##  \<a name="cmfctabdroptarget__ondropex">\</a>  CMFCTabDropTarget::OnDropEx  
 Called by the framework when the user releases the mouse button at the end of a drag operation.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Unused.|  
|[in] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|A pointer to the object that the user drags.|  
|[in] <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|The default drop operation.|  
|[in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|Unused.|  
|[in] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|The location of the mouse pointer in client coordinates.|  
  
### Return Value  
 The resulting drop effect. It can be one or more of the following:  
  
-   <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>  
  
### Remarks  
 This method calls <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> if the toolbar framework is in customization mode and the Clipboard data format is available. If the call to <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> returns a nonzero value, this method returns the default drop effect specified by <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>. Otherwise, this method returns <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>. For more information about drop effects, see [COleDropTarget::OnDropEx](../vs140/coledroptarget-class.md#coledroptarget__ondropex).  
  
 For more information about customization mode, see [CMFCToolBar::IsCustomizeMode](../vs140/cmfctoolbar-class.md#cmfctoolbar__iscustomizemode). For more information about Clipboard data formats, see [COleDataObject::IsDataAvailable](../vs140/coledataobject-class.md#coledataobject__isdataavailable).  
  
##  \<a name="cmfctabdroptarget__register">\</a>  CMFCTabDropTarget::Register  
 Registers the control as one that can be the target of an OLE drag-and-drop operation.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|The tab control to register as a drop target.|  
  
### Return Value  
 Nonzero if registration was successful; otherwise 0.  
  
### Remarks  
 This method calls [COleDropTarget::Register](../vs140/coledroptarget-class.md#coledroptarget__register) to register the control for drag-and-drop operations.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [Drag and Drop (OLE)](../vs140/drag-and-drop--ole-.md)