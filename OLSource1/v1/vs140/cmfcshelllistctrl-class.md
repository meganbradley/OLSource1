---
title: "CMFCShellListCtrl Class"
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
  - "CMFCShellListCtrl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCShellListCtrl class"
ms.assetid: ad472958-5586-4c50-aadf-1844c30bf6e7
caps.latest.revision: 29
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCShellListCtrl Class
The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class provides Windows list control functionality and expands it by including the ability to display a list of shell items.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CMFCShellListCtrl::DisplayFolder](#cmfcshelllistctrl__displayfolder)|Displays a list of items that are contained in a provided folder.|  
|[CMFCShellListCtrl::DisplayParentFolder](#cmfcshelllistctrl__displayparentfolder)|Displays a list of items that are contained in the folder that is the parent of the currently displayed folder.|  
|[CMFCShellListCtrl::EnableShellContextMenu](#cmfcshelllistctrl__enableshellcontextmenu)|Enables or disables the shortcut menu.|  
|[CMFCShellListCtrl::GetCurrentFolder](#cmfcshelllistctrl__getcurrentfolder)|Retrieves the path of the current folder.|  
|[CMFCShellListCtrl::GetCurrentFolderName](#cmfcshelllistctrl__getcurrentfoldername)|Retrieves the name of the current folder.|  
|[CMFCShellListCtrl::GetCurrentItemIdList](#cmfcshelllistctrl__getcurrentitemidlist)|Returns the PIDL of the current list control item.|  
|[CMFCShellListCtrl::GetCurrentShellFolder](#cmfcshelllistctrl__getcurrentshellfolder)|Returns a pointer to the current Shell folder.|  
|[CMFCShellListCtrl::GetItemPath](#cmfcshelllistctrl__getitempath)|Returns the textual path of an item.|  
|[CMFCShellListCtrl::GetItemTypes](#cmfcshelllistctrl__getitemtypes)|Returns Shell item types that are displayed by the list control.|  
|[CMFCShellListCtrl::IsDesktop](#cmfcshelllistctrl__isdesktop)|Checks if the currently selected folder is the desktop folder.|  
|[CMFCShellListCtrl::OnCompareItems](#cmfcshelllistctrl__oncompareitems)|The framework calls this method when it compares two items. (Overrides [CMFCListCtrl::OnCompareItems](../vs140/cmfclistctrl-class.md#cmfclistctrl__oncompareitems).)|  
|[CMFCShellListCtrl::OnFormatFileDate](#cmfcshelllistctrl__onformatfiledate)|Called when the framework retrieves the file date displayed by the list control.|  
|[CMFCShellListCtrl::OnFormatFileSize](#cmfcshelllistctrl__onformatfilesize)|Called when the framework converts the file size of a list control.|  
|[CMFCShellListCtrl::OnGetItemIcon](#cmfcshelllistctrl__ongetitemicon)|Called when the framework retrieves the icon of a list control item.|  
|[CMFCShellListCtrl::OnGetItemText](#cmfcshelllistctrl__ongetitemtext)|Called when the framework converts the text of a list control item.|  
|[CMFCShellListCtrl::OnSetColumns](#cmfcshelllistctrl__onsetcolumns)|Called by the framework when it sets the names of the columns.|  
|[CMFCShellListCtrl::Refresh](#cmfcshelllistctrl__refresh)|Refreshes and repaints the list control.|  
|[CMFCShellListCtrl::SetItemTypes](#cmfcshelllistctrl__setitemtypes)|Sets the type of items displayed by the list control.|  
  
## Remarks  
 The <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class extends the functionality of the [CMFCListCtrl Class](../vs140/cmfclistctrl-class.md) by enabling your program to list Windows shell items. The display format that is used is like that of a list view for an Explorer window.  
  
 A [CMFCShellTreeCtrl](../vs140/cmfcshelltreectrl-class.md) object can be associated with a <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> object to create a complete Explorer window. Then, selecting an item in the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> will cause the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object to list the contents of the selected item.  
  
## Example  
 The following example demonstrates how to create an object of the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> class and how to display the parent folder of the currently displayed folder. This code snippet is part of the [Explorer sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_Explorer#1](../vs140/codesnippet/CPP/cmfcshelllistctrl-class_1.h)]  
[!code[NVC_MFC_Explorer#2](../vs140/codesnippet/CPP/cmfcshelllistctrl-class_2.cpp)]  
[!code[NVC_MFC_Explorer#3](../vs140/codesnippet/CPP/cmfcshelllistctrl-class_3.cpp)]  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CCmdTarget](../vs140/ccmdtarget-class.md)  
  
 [CWnd](../vs140/cwnd-class.md)  
  
 [CListCtrl](../vs140/clistctrl-class.md)  
  
 [CMFCListCtrl](../vs140/cmfclistctrl-class.md)  
  
 [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md)  
  
## Requirements  
 **Header:** afxshelllistCtrl.h  
  
##  \<a name="cmfcshelllistctrl__displayfolder">\</a>  CMFCShellListCtrl::DisplayFolder  
 Displays a list of items that are contained in the provided folder.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 A string that contains the path of a folder.  
  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 A pointer to a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> structure that describes a folder to display.  
  
### Return Value  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcshelllistctrl__displayparentfolder">\</a>  CMFCShellListCtrl::DisplayParentFolder  
 Updates the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object to display the parent folder of the currently displayed folder.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcshelllistctrl__enableshellcontextmenu">\</a>  CMFCShellListCtrl::EnableShellContextMenu  
 Enables the shortcut menu.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 A Boolean that specifies whether the framework enables the shortcut menu.  
  
##  \<a name="cmfcshelllistctrl__getcurrentfolder">\</a>  CMFCShellListCtrl::GetCurrentFolder  
 Retrieves the path of the currently selected folder in the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 A reference to a string parameter where the method writes the path.  
  
### Return Value  
 Nonzero if successful; 0 otherwise.  
  
### Remarks  
 This method fails if there is no folder selected in the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcshelllistctrl__getcurrentfoldername">\</a>  CMFCShellListCtrl::GetCurrentFolderName  
 Retrieves the name of the currently selected folder in the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 A reference to a string parameter where the method writes the name.  
  
### Return Value  
 Nonzero if successful; 0 otherwise.  
  
### Remarks  
 This method fails if there is no folder selected in the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
##  \<a name="cmfcshelllistctrl__getcurrentitemidlist">\</a>  CMFCShellListCtrl::GetCurrentItemIdList  
 Returns the PIDL of the currently selected item.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Return Value  
 The PIDL of the current item.  
  
##  \<a name="cmfcshelllistctrl__getcurrentshellfolder">\</a>  CMFCShellListCtrl::GetCurrentShellFolder  
 Gets a pointer to the currently selected item in the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Return Value  
 A pointer to the                         [IShellFolder Interface](http://msdn.microsoft.com/library/windows/desktop/bb775075) for the selected object.  
  
### Remarks  
 This method returns <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> if no object is currently selected.  
  
##  \<a name="cmfcshelllistctrl__getitempath">\</a>  CMFCShellListCtrl::GetItemPath  
 Retrieves the path for an item.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 A reference to a string that receives the path.  
  
 [in] <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 The index of the list item.  
  
### Return Value  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> if successful; <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> otherwise.  
  
### Remarks  
 The index supplied by <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> is based on the items currently displayed by the [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md) object.  
  
##  \<a name="cmfcshelllistctrl__getitemtypes">\</a>  CMFCShellListCtrl::GetItemTypes  
 Returns the type of items displayed by the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Return Value  
 A                         [SHCONTF](http://msdn.microsoft.com/library/windows/desktop/bb762539) value that contains the type of items listed in the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
### Remarks  
 To set the type of items listed in a <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, call [CMFCShellListCtrl::SetItemTypes](#cmfcshelllistctrl__setitemtypes).  
  
##  \<a name="cmfcshelllistctrl__isdesktop">\</a>  CMFCShellListCtrl::IsDesktop  
 Determines if the folder that is displayed in the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object is the desktop folder.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> if the displayed folder is the desktop folder; <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> otherwise.  
  
##  \<a name="cmfcshelllistctrl__oncompareitems">\</a>  CMFCShellListCtrl::OnCompareItems  
 [!INCLUDE[cpp_fp_under_construction](../vs140/includes/cpp_fp_under_construction_md.md)]  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
  [in] <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>  
  
### Return Value  
  
### Remarks  
  
##  \<a name="cmfcshelllistctrl__onformatfiledate">\</a>  CMFCShellListCtrl::OnFormatFileDate  
 The framework calls this method when it must convert the date associated with an object into a string.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>  
 The date associated with a file.  
  
 [out] <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>  
 A string that contains the formatted file date.  
  
### Remarks  
 When a [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md) object displays the date associated with a file, it must convert that date to a string format. The <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> uses this method to make that conversion. By default, this method uses the current locale to format the date into a string.  
  
##  \<a name="cmfcshelllistctrl__onformatfilesize">\</a>  CMFCShellListCtrl::OnFormatFileSize  
 The framework calls this method when it converts the size of an object to a string.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>  
 The size of the file that the framework will display.  
  
 [out] <CodeContentPlaceHolder>54\</CodeContentPlaceHolder>  
 A string that contains the formatted file size.  
  
### Remarks  
 When a [CMFCShellListCtrl Class](../vs140/cmfcshelllistctrl-class.md) object needs to display the size of a file, it needs to convert the file size into a string format. The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> uses this method to make that conversion. By default, this method converts the file size from bytes to kilobytes and then uses the current locale to format the size into string.  
  
##  \<a name="cmfcshelllistctrl__ongetitemicon">\</a>  CMFCShellListCtrl::OnGetItemIcon  
 The framework calls this method to retrieve the icon associated with a shell list item.  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>  
 The item index.  
  
 [in] <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> parameter that describes the item.  
  
### Return Value  
 The index of the icon image if successful; -1 if the function fails.  
  
### Remarks  
 The icon image index is based on the system image list.  
  
 By default, this method relies on the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> parameter. The value of <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> is not used in the default implementation. You can use <CodeContentPlaceHolder>61\</CodeContentPlaceHolder> to implement custom behavior.  
  
##  \<a name="cmfcshelllistctrl__ongetitemtext">\</a>  CMFCShellListCtrl::OnGetItemText  
 The framework calls this method when it must retrieve the text of a shell item.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>  
 The item index.  
  
 [in] <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>  
 The column of interest.  
  
 [in] <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> parameter that describes the item.  
  
### Return Value  
 A <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> that contains the text associated with the item.  
  
### Remarks  
 Each item in the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object may have text in one or more columns. When the framework calls this method, it specifies the column that it is interested in. If you call this function manually, you must also specify the column that you are interested in.  
  
 By default, this method relies on the <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> parameter to determine which item to process. The value of <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is not used in the default implementation.  
  
##  \<a name="cmfcshelllistctrl__onsetcolumns">\</a>  CMFCShellListCtrl::OnSetColumns  
 The framework calls this method when it sets the names of the columns.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
### Remarks  
 By default, the framework creates four columns in a [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object. The names of these columns are <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>. You can override this method to customize the number of columns and their names.  
  
##  \<a name="cmfcshelllistctrl__refresh">\</a>  CMFCShellListCtrl::Refresh  
 Refreshes and repaints the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
### Return Value  
 <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> if successful; otherwise an error value.  
  
### Remarks  
 Call this method to refresh the list of items displayed by the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> object.  
  
##  \<a name="cmfcshelllistctrl__setitemtypes">\</a>  CMFCShellListCtrl::SetItemTypes  
 Sets the type of items that are listed in the [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) object.  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>  
 A list of item types that the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> object supports.  
  
### Remarks  
 For more information about the list of item types, see                         [SHCONTF](http://msdn.microsoft.com/library/windows/desktop/bb762539).  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)   
 [CMFCListCtrl Class](../vs140/cmfclistctrl-class.md)   
 [CMFCShellTreeCtrl Class](../vs140/cmfcshelltreectrl-class.md)