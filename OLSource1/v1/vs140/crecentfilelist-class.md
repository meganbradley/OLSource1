---
title: "CRecentFileList Class"
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
  - "CRecentFileList"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "files [C++], most recently used"
  - "MRU files"
  - "CRecentFileList class"
ms.assetid: a77f0524-7584-4582-849a-7e97b76d186e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRecentFileList Class
Supports control of the most recently used (MRU) file list.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[CRecentFileList::CRecentFileList](#crecentfilelist__crecentfilelist)|Constructs a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[CRecentFileList::Add](#crecentfilelist__add)|Adds a file to the MRU file list.|  
|[CRecentFileList::GetDisplayName](#crecentfilelist__getdisplayname)|Provides a display name for menu display of an MRU filename.|  
|[CRecentFileList::GetSize](#crecentfilelist__getsize)|Retrieves the number of files in the MRU file list.|  
|[CRecentFileList::ReadList](#crecentfilelist__readlist)|Reads the MRU file list from the registry or .INI file.|  
|[CRecentFileList::Remove](#crecentfilelist__remove)|Removes a file from the MRU file list.|  
|[CRecentFileList::UpdateMenu](#crecentfilelist__updatemenu)|Updates the menu display of the MRU file list.|  
|[CRecentFileList::WriteList](#crecentfilelist__writelist)|Writes the MRU file list from the registry or .INI file.|  
  
### Public Operators  
  
|Name|Description|  
|----------|-----------------|  
|[CRecentFileList::operator &#91;&#93;](#crecentfilelist__operator_at)|Returns a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object at a given position.|  
  
## Remarks  
 Files can be added to or deleted from the MRU file list, the file list can be read from or written to the registry or an .INI file, and the menu displaying the MRU file list can be updated.  
  
 For more information about MRU menu items, see  
  
-   Knowledge Base article Q243751 : HOWTO: Add Command Handlers for MRU Menu Items in MFC Application  
  
## Inheritance Hierarchy  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
## Requirements  
 **Header:** afxadv.h  
  
##  \<a name="crecentfilelist__add">\</a>  CRecentFileList::Add  
 Adds a file to the most recently used (MRU) file list.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Specifies pathname to be added to the list.  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Specifies Application User Model ID for the application.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Specifies a pointer to Shell Item to be added to the list.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Specifies a pointer to Shell Link to be added to the list.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Specifies the IDLIST for the shell item that should be added to the recent docs folder.  
  
### Remarks  
 The file name will be added to the top of the MRU list. If the file name already exists in the MRU list, it will be moved to the top.  
  
##  \<a name="crecentfilelist__crecentfilelist">\</a>  CRecentFileList::CRecentFileList  
 Constructs a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Offset for the numbering in the menu display of the MRU (most recently used) file list.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Points to the name of the section of the registry or the application's .INI file where the MRU file list is read and/or written.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Points to a format string to be used for the names of the entries stored in the registry or the application's .INI file.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Maximum number of files in the MRU file list.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Maximum length, in characters, available for the menu display of a filename in the MRU file list.  
  
### Remarks  
 The format string pointed to by <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> should contain "%d", which will be used for substituting the index of each MRU item. For example, if the format string is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> then the entries will be named <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, and so on.  
  
##  \<a name="crecentfilelist__getdisplayname">\</a>  CRecentFileList::GetDisplayName  
 Obtains a display name for a file in the MRU file list, for use in the menu display of the MRU list.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Full path of the file whose name is to be displayed in the menu list of MRU files.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Zero-based index of the file in the MRU file list.  
  
 *lpszCurDir*  
 String holding the current directory.  
  
 *nCurDir*  
 Length of the current directory string.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 If nonzero, indicates that the base name of the file should be returned, even if it exceeds the maximum display length (passed as the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> parameter to the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> constructor).  
  
### Return Value  
 **FALSE** if there is no filename at the specified index in the most recently used (MRU) file list.  
  
### Remarks  
 If the file is in the current directory, the function leaves the directory off the display. If the filename is too long, the directory and extension are stripped. If the filename is still too long, the display name is set to an empty string unless <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> is nonzero.  
  
##  \<a name="crecentfilelist__getsize">\</a>  CRecentFileList::GetSize  
 Retrieves the number of files in the MRU file list.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Return Value  
 The number of files in the current most recently used (MRU) file list.  
  
##  \<a name="crecentfilelist__operator_at">\</a>  CRecentFileList::operator [ ]  
 The overloaded subscript ( <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>) operator returns a single <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> specified by the zero-based index in <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Zero-based index of a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> in a set of <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>s.  
  
##  \<a name="crecentfilelist__readlist">\</a>  CRecentFileList::ReadList  
 Reads the most recently used (MRU) file list from the registry or the application's .INI file.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
##  \<a name="crecentfilelist__remove">\</a>  CRecentFileList::Remove  
 Removes a file from the MRU file list.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Zero-based index of the file to be removed from the most recently used (MRU) file list.  
  
##  \<a name="crecentfilelist__updatemenu">\</a>  CRecentFileList::UpdateMenu  
 Updates the menu display of the MRU file list.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 A pointer to the [CCmdUI](../vs140/ccmdui-class.md) object for the most recently used (MRU) file list menu.  
  
##  \<a name="crecentfilelist__writelist">\</a>  CRecentFileList::WriteList  
 Writes the most recently used (MRU) file list into the registry or the application's .INI file.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
## See Also  
 [Hierarchy Chart](../vs140/hierarchy-chart.md)