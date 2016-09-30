---
title: "CShellManager Class"
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
  - "CShellManager"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CShellManager class"
ms.assetid: f15c4c1a-6fae-487d-9913-9b7369b33da0
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CShellManager Class
Implements several methods that enable you to work with pointers to identifier lists (PIDLs).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CShellManager::CShellManager](#cshellmanager__cshellmanager)|Constructs a <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CShellManager::BrowseForFolder](#cshellmanager__browseforfolder)|Displays a dialog box that enables the user to select a shell folder.|  
|[CShellManager::ConcatenateItem](#cshellmanager__concatenateitem)|Concatenates two PIDLs.|  
|[CShellManager::CopyItem](#cshellmanager__copyitem)|Creates a new PIDL and copies the supplied PIDL to it.|  
|[CShellManager::CreateItem](#cshellmanager__createitem)|Creates a new PIDL of the specified size.|  
|[CShellManager::FreeItem](#cshellmanager__freeitem)|Deletes the supplied PIDL.|  
|[CShellManager::GetItemCount](#cshellmanager__getitemcount)|Returns the number of items in the supplied PIDL.|  
|[CShellManager::GetItemSize](#cshellmanager__getitemsize)|Returns the size of the supplied PIDL.|  
|[CShellManager::GetNextItem](#cshellmanager__getnextitem)|Returns the next item from the PIDL.|  
|[CShellManager::GetParentItem](#cshellmanager__getparentitem)|Retrieves the parent item of the supplied item.|  
|[CShellManager::ItemFromPath](#cshellmanager__itemfrompath)|Retrieves the PIDL for the item identified by the supplied path.|  
  
## Remarks  
 The methods of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> class all deal with PIDLs. A PIDL is a unique identifier for a shell object.  
  
 You should not create a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object manually. It will be created automatically by the framework of your application. However, you should call [CWinAppEx::InitShellManager](../vs140/cwinappex-class.md#cwinappex__initshellmanager) during the initialization process of your application. To get a pointer to the shell manager for your application, call [CWinAppEx::GetShellManager](../vs140/cwinappex-class.md#cwinappex__getshellmanager).  
  
## Inheritance Hierarchy  
 [CObject](../vs140/cobject-class.md)  
  
 [CShellManager](../vs140/cshellmanager-class.md)  
  
## Requirements  
 **Header:** afxshellmanager.h  
  
##  \<a name="cshellmanager__browseforfolder">\</a>  CShellManager::BrowseForFolder  
 Displays a dialog box that enables the user to select a shell folder.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 [out] <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 The string used by the method to store the path of the selected folder.  
  
 [in] <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 A pointer to the parent window.  
  
 [in] <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 A string that contains the folder that is selected by default when the dialog box is displayed.  
  
 [in] <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 The title for the dialog box.  
  
 [in] <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Flags specifying options for the dialog box. See                                 [BROWSEINFO](http://msdn.microsoft.com/library/windows/desktop/bb773205) for the detailed description.  
  
 [out] <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 A pointer to the integer value where the method writes the image index of the selected folder.  
  
### Return Value  
 Nonzero if the user selects a folder from the dialog box; otherwise 0.  
  
### Remarks  
 When you call this method, the application creates and shows a dialog box that enables the user to select a folder. The method will write the path of the folder into the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> parameter.  
  
### Example  
 The following example demonstrates how to retrieve a reference to a <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object by using the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> method and how to use the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method. This code snippet is part of the [Explorer sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_Explorer#6](../vs140/codesnippet/CPP/cshellmanager-class_1.cpp)]  
  
##  \<a name="cshellmanager__concatenateitem">\</a>  CShellManager::ConcatenateItem  
 Creates a new list containing two PIDLs.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 The first item.  
  
 [in] <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The second item.  
  
### Return Value  
 A pointer to the new item list if the function succeeds, otherwise <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
### Remarks  
 This method creates a new                         [ITEMIDLIST](http://msdn.microsoft.com/library/windows/desktop/bb773321) large enough to contain both <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. It then copies <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> to the new list.  
  
##  \<a name="cshellmanager__copyitem">\</a>  CShellManager::CopyItem  
 Copies an item list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 The original item list.  
  
### Return Value  
 A pointer to the newly created item list if successful; otherwise <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
### Remarks  
 The newly created item list has the same size as the source item list.  
  
##  \<a name="cshellmanager__createitem">\</a>  CShellManager::CreateItem  
 Creates a new PIDL.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 The size of the item list.  
  
### Return Value  
 A pointer to the created item list if successful; otherwise <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>.  
  
##  \<a name="cshellmanager__cshellmanager">\</a>  CShellManager::CShellManager  
 Constructs a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Remarks  
 In most cases, you do not have to create a <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> directly. By default, the framework creates one for you. To get a pointer to the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, call [CWinAppEx::GetShellManager](../vs140/cwinappex-class.md#cwinappex__getshellmanager). If you do create a <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> manually, you must initialize it with the method [CWinAppEx::InitShellManager](../vs140/cwinappex-class.md#cwinappex__initshellmanager).  
  
##  \<a name="cshellmanager__freeitem">\</a>  CShellManager::FreeItem  
 Deletes an item list.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 An item list to delete.  
  
##  \<a name="cshellmanager__getitemcount">\</a>  CShellManager::GetItemCount  
 Returns the number of items in an item list.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A pointer to an item list.  
  
### Return Value  
 The number of items in the item list.  
  
##  \<a name="cshellmanager__getitemsize">\</a>  CShellManager::GetItemSize  
 Returns the size of an item list.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 A pointer to an item list.  
  
### Return Value  
 The size of the item list.  
  
##  \<a name="cshellmanager__getnextitem">\</a>  CShellManager::GetNextItem  
 Retrieves the next item from a pointer to an item identifier list (PIDL).  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 The list of items to iterate.  
  
### Return Value  
 A pointer to the next item in the list.  
  
### Remarks  
 If there are no more items in the list, this method returns <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
##  \<a name="cshellmanager__getparentitem">\</a>  CShellManager::GetParentItem  
 Retrieves the parent of a pointer to an item identifier list (PIDL).  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>  
 A PIDL whose parent will be retrieved.  
  
 [out] <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
 A reference to a PIDL where the method will store the result.  
  
### Return Value  
 The level of the parent PIDL.  
  
### Remarks  
 The level of a PIDL is relative to the desktop. The desktop PIDL is considered to have a level of 0.  
  
##  \<a name="cshellmanager__itemfrompath">\</a>  CShellManager::ItemFromPath  
 Retrieves the pointer to an item identifier list (PIDL) from the item identified by a string path.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
### Parameters  
 [in] <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>  
 A string that specifies the path for the item.  
  
 [out] <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>  
 A reference to a PIDL. The method uses this PIDL to store the pointer to its return value.  
  
### Return Value  
 Returns <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> if successful; an OLE-defined error value.  
  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [Classes](../vs140/mfc-classes.md)