---
title: "CFile::CFile"
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
  - "CFile.CFile"
  - "CFile::CFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFile class, constructor"
  - "CFile class, construction/destruction"
ms.assetid: 4cb0e6a5-52c9-427d-9d5c-3f6b54c2b3ca
caps.latest.revision: 28
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::CFile
Constructs and initializes a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Handle of a file to attach to the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Relative or full path of a file to attach to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Bitwise combination (OR) of file access options for the specified file. See the Remarks section for possible options.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object  
  
## Remarks  
 The following five tables list the possible options for the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter.  
  
 Choose only one of the following file access mode options. The default file access mode is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, which is read only.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Requests read access only.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Requests write access only.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Requests read and write access.|  
  
 Choose one of the following character mode options.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Sets binary mode (used in derived classes only).|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Sets text mode with special processing for carriage return–linefeed pairs (used in derived classes only).|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Sets Unicode mode (used in derived classes only). Text is written to the file in Unicode format when the application is built in a Unicode configuration. No BOM is written to the file.|  
  
 Choose only one of the following file share mode options. The default file share mode is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, which is exclusive.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|No sharing restrictions.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Denies read access to all others.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Denies write access to all others.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Denies read and write access to all others.|  
  
 Choose the first, or both, of the following file creation mode options. The default creation mode is <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, which is open existing.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Creates a new file if no file exists.; If the file already exists, [CFileException](../vs140/cfileexception-class.md) is raised.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Creates a new file if no file exists; otherwise, if the file already exists, it is attached to the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> object.|  
  
 Choose the following file caching options as described. By default, the system uses a general purpose caching scheme that is not available as an option.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|The system does not use an intermediate cache for the file. This option cancels the following 2 options.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|The file cache is optimized for random access. Do not use this option and the sequential scan option.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|The file cache is optimized for sequential access. Do not use this option and the random access option.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Write operations are performed without delay.|  
  
 Choose the following security option to prevent the file handle from being inherited. By default, any new child processes can use the file handle.  
  
|Value|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Prevents any child processes from using the file handle.|  
  
 The default constructor initializes members but does not attach a file to the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> object. After using this constructor, use the [Open](../vs140/cfile--open.md) method to open a file and attach it to the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> object.  
  
 The constructor with one parameter initializes members and attaches an existing file to the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> object.  
  
 The constructor with two parameters initializes members and tries to open the specified file. If this constructor successfully opens the specified file, the file is attached to the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> object; otherwise, this constructor throws a pointer to a <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> object. For more information about how to handle exceptions, see [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
 If a <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> object successfully opens a specified file, it will close this file automatically when the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> object is destroyed; otherwise, you must explicitly close the file after it is no longer attached to the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> object.  
  
## Example  
 The following code shows how to use a <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>.  
  
 [!code[NVC_MFCFiles#4](../vs140/codesnippet/CPP/cfile--cfile_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)