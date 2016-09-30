---
title: "CMFCShellTreeCtrl Class"
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
  - "CMFCShellTreeCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCShellTreeCtrl class"
ms.assetid: 3d1da715-9554-4ed7-968c-055c48146267
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellTreeCtrl Class
The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> class extends [CTreeCtrl Class](../vs140/ctreectrl-class.md) functionality by displaying a hierarchy of Shell items.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCShellTreeCtrl::EnableShellContextMenu](#cmfcshelltreectrl__enableshellcontextmenu)|Enables or disables the shortcut menu.|  
|[CMFCShellTreeCtrl::GetFlags](#cmfcshelltreectrl__getflags)|Returns a combination of flags that are passed to                                         [IShellFolder::EnumObjects](http://msdn.microsoft.com/library/windows/desktop/bb775066).|  
|[CMFCShellTreeCtrl::GetItemPath](#cmfcshelltreectrl__getitempath)|Retrieves the path to an item.|  
|[CMFCShellTreeCtrl::GetRelatedList](#cmfcshelltreectrl__getrelatedlist)|Returns a pointer to the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object that is used together with this <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object to create an Explorer-like window.|  
|[CMFCShellTreeCtrl::OnChildNotify](#cmfcshelltreectrl__onchildnotify)|This member function is called by this window's parent window when it receives a notification message that applies to this window. (Overrides [CWnd::OnChildNotify](../vs140/cwnd-class.md#cwnd__onchildnotify).)|  
|[CMFCShellTreeCtrl::OnGetItemIcon](#cmfcshelltreectrl__ongetitemicon)||  
|[CMFCShellTreeCtrl::OnGetItemText](#cmfcshelltreectrl__ongetitemtext)||  
|[CMFCShellTreeCtrl::Refresh](#cmfcshelltreectrl__refresh)|Refreshes and repaints the current <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object.|  
|[CMFCShellTreeCtrl::SelectPath](#cmfcshelltreectrl__selectpath)|Selects the appropriate tree control item based on a supplied PIDL or string path.|  
|[CMFCShellTreeCtrl::SetFlags](#cmfcshelltreectrl__setflags)|Sets flags to filter the tree context (similar to the flags used by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>).|  
|[CMFCShellTreeCtrl::SetRelatedList](#cmfcshelltreectrl__setrelatedlist)|Sets a relation between the current <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> object and a <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
  
## Remarks  
 This class extends the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> class by enabling your program to include Windows Shell items in the tree. This class can be associated with a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> object to create a complete Explorer window. Then, selecting an item in the tree will display a list of Windows Shell items in the associated list.  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CTreeCtrl](../vs140/ctreectrl-class.md)  
  
 [CMFCShellTreeCtrl](../vs140/cmfcshelltreectrl-class.md)  
  
## Requirements  
 **Header:** afxshelltreeCtrl.h  
  
## Example  
 The following example demonstrates how to create an object of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class. This code snippet is part of the [Explorer sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_Explorer#4](../vs140/codesnippet/CPP/cmfcshelltreectrl-class_1.h)]  
[!code[NVC_MFC_Explorer#5](../vs140/codesnippet/CPP/cmfcshelltreectrl-class_2.cpp)]  
  
##  \<a name="cmfcshelltreectrl__enableshellcontextmenu">\</a>  CMFCShellTreeCtrl::EnableShellContextMenu  
 Enables the shortcut menu.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 A Boolean that specifies whether to enable the shortcut menu.  
  
##  \<a name="cmfcshelltreectrl__getflags">\</a>  CMFCShellTreeCtrl::GetFlags  
 Returns the flags set for the [CMFCShellTreeCtrl Class](../vs140/cmfcshelltreectrl-class.md) object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 A <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> value that specifies the combination of flags currently set.  
  
### Remarks  
 The flags set in the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> are sent to the method                         [IShellFolder::EnumObjects](http://msdn.microsoft.com/library/windows/desktop/bb775066) whenever the object is refreshed. You can change the flags with the [CMFCShellTreeCtrl::SetFlags](#cmfcshelltreectrl__setflags) method.  
  
##  \<a name="cmfcshelltreectrl__getitempath">\</a>  CMFCShellTreeCtrl::GetItemPath  
 Retrieves the path of an item in the [CMFCShellTreeCtrl Class](../vs140/cmfcshelltreectrl-class.md) object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
 A reference to a string parameter. The method writes the path of the item to this parameter.  
  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The method retrieves the path for this tree control item.  
  
### Return Value  
 Nonzero if successful; 0 otherwise.  
  
### Remarks  
 If this method fails, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> contains the empty string.  
  
 If you do not specify <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, this method tries to obtain the string for the currently selected item. If no item is selected and <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, this method fails.  
  
##  \<a name="cmfcshelltreectrl__getrelatedlist">\</a>  CMFCShellTreeCtrl::GetRelatedList  
 Returns a pointer to the [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md) object that is associated with this [CMFCShellTreeCtrl](../vs140/cmfcshelltreectrl-class.md) object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object that is associated with this tree control object.  
  
### Remarks  
 By using a <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object together with a <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object, you can create an Explorer-like window. Use the method [CMFCShellTreeCtrl::SetRelatedList](#cmfcshelltreectrl__setrelatedlist) to associate the two classes. After they are associated, the framework automatically updates the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> if the selection in the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> changes.  
  
##  \<a name="cmfcshelltreectrl__onchildnotify">\</a>  CMFCShellTreeCtrl::OnChildNotify  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcshelltreectrl__ongetitemicon">\</a>  CMFCShellTreeCtrl::OnGetItemIcon  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcshelltreectrl__ongetitemtext">\</a>  CMFCShellTreeCtrl::OnGetItemText  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcshelltreectrl__refresh">\</a>  CMFCShellTreeCtrl::Refresh  
 Refreshes and repaints the [CMFCShellTreeCtrl](../vs140/cmfcshelltreectrl-class.md).  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Remarks  
 Call this method to refresh the hierarchy of the items displayed in the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcshelltreectrl__selectpath">\</a>  CMFCShellTreeCtrl::SelectPath  
 Selects an item in the [CMFCShellTreeCtrl Class](../vs140/cmfcshelltreectrl-class.md) based on the supplied path.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 A string that specifies the path of an item.  
  
 [in] <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>  
 A PIDL that specifies the item  
  
### Return Value  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcshelltreectrl__setflags">\</a>  CMFCShellTreeCtrl::SetFlags  
 Sets flags to filter the tree context.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 The flags to set.  
  
 [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A Boolean that specifies whether the [CMFCShellTreeCtrl Class](../vs140/cmfcshelltreectrl-class.md) should be refreshed immediately.  
  
### Remarks  
 The <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> passes all set flags to                         [IShellFolder::EnumObjects](http://msdn.microsoft.com/library/windows/desktop/bb775066). For more information about the values of different flags, see                         [IShellFolder::EnumObjects](http://msdn.microsoft.com/library/windows/desktop/bb775066).  
  
##  \<a name="cmfcshelltreectrl__setrelatedlist">\</a>  CMFCShellTreeCtrl::SetRelatedList  
 Associates a [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object with a [CMFCShellTreeCtrl](../vs140/cmfcshelltreectrl-class.md) object.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> object.  
  
### Remarks  
 This method associates a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> with a <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>. These objects may be displayed as an Explorer-like window: if the user selects an object in the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>, the associated items in the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> will be automatically updated.  
  
 Use the method [CMFCShellTreeCtrl::GetRelatedList](#cmfcshelltreectrl__getrelatedlist) to retrieve the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> associated with a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CTreeCtrl Class](../vs140/ctreectrl-class.md)   
 [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md)