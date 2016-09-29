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
Constructs and initializes a `CFile` object.  
  
## Syntax  
  
```  
CFile( );  
CFile(  
   CAtlTransactionManager* pTM  
);  
CFile(  
   HANDLE hFile   
);  
CFile(  
   LPCTSTR lpszFileName,  
   UINT nOpenFlags   
);  
CFile(  
   LPCTSTR lpszFileName,  
   UINT nOpenFlags,  
   CAtlTransactionManager* pTM  
);  
```  
  
#### Parameters  
 `hFile`  
 Handle of a file to attach to the `CFile` object.  
  
 `lpszFileName`  
 Relative or full path of a file to attach to the `CFile` object.  
  
 `nOpenFlags`  
 Bitwise combination (OR) of file access options for the specified file. See the Remarks section for possible options.  
  
 `pTM`  
 Pointer to CAtlTransactionManager object  
  
## Remarks  
 The following five tables list the possible options for the `nOpenFlags` parameter.  
  
 Choose only one of the following file access mode options. The default file access mode is `CFile::modeRead`, which is read only.  
  
|Value|Description|  
|-----------|-----------------|  
|`CFile::modeRead`|Requests read access only.|  
|`CFile::modeWrite`|Requests write access only.|  
|`CFile::modeReadWrite`|Requests read and write access.|  
  
 Choose one of the following character mode options.  
  
|Value|Description|  
|-----------|-----------------|  
|`CFile::typeBinary`|Sets binary mode (used in derived classes only).|  
|`CFile::typeText`|Sets text mode with special processing for carriage return–linefeed pairs (used in derived classes only).|  
|`CFile::typeUnicode`|Sets Unicode mode (used in derived classes only). Text is written to the file in Unicode format when the application is built in a Unicode configuration. No BOM is written to the file.|  
  
 Choose only one of the following file share mode options. The default file share mode is `CFile::shareExclusive`, which is exclusive.  
  
|Value|Description|  
|-----------|-----------------|  
|`CFile::shareDenyNone`|No sharing restrictions.|  
|`CFile::shareDenyRead`|Denies read access to all others.|  
|`CFile::shareDenyWrite`|Denies write access to all others.|  
|`CFile::shareExclusive`|Denies read and write access to all others.|  
  
 Choose the first, or both, of the following file creation mode options. The default creation mode is `CFile::modeNoTruncate`, which is open existing.  
  
|Value|Description|  
|-----------|-----------------|  
|`CFile::modeCreate`|Creates a new file if no file exists.; If the file already exists, [CFileException](../vs140/cfileexception-class.md) is raised.|  
|`CFile::modeNoTruncate`|Creates a new file if no file exists; otherwise, if the file already exists, it is attached to the `CFile` object.|  
  
 Choose the following file caching options as described. By default, the system uses a general purpose caching scheme that is not available as an option.  
  
|Value|Description|  
|-----------|-----------------|  
|`CFile::osNoBuffer`|The system does not use an intermediate cache for the file. This option cancels the following 2 options.|  
|`CFile::osRandomAccess`|The file cache is optimized for random access. Do not use this option and the sequential scan option.|  
|`CFile::osSequentialScan`|The file cache is optimized for sequential access. Do not use this option and the random access option.|  
|`CFile::osWriteThrough`|Write operations are performed without delay.|  
  
 Choose the following security option to prevent the file handle from being inherited. By default, any new child processes can use the file handle.  
  
|Value|Description|  
|-----------|-----------------|  
|`CFile::modeNoInherit`|Prevents any child processes from using the file handle.|  
  
 The default constructor initializes members but does not attach a file to the `CFile` object. After using this constructor, use the [Open](../vs140/cfile--open.md) method to open a file and attach it to the `CFile` object.  
  
 The constructor with one parameter initializes members and attaches an existing file to the `CFile` object.  
  
 The constructor with two parameters initializes members and tries to open the specified file. If this constructor successfully opens the specified file, the file is attached to the `CFile` object; otherwise, this constructor throws a pointer to a `CInvalidArgException` object. For more information about how to handle exceptions, see [Exceptions](../vs140/exception-handling-in-mfc.md).  
  
 If a `CFile` object successfully opens a specified file, it will close this file automatically when the `CFile` object is destroyed; otherwise, you must explicitly close the file after it is no longer attached to the `CFile` object.  
  
## Example  
 The following code shows how to use a `CFile`.  
  
 [!code[NVC_MFCFiles#4](../vs140/codesnippet/CPP/cfile--cfile_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)