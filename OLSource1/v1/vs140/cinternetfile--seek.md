---
title: "CInternetFile::Seek"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CInternetFile.Seek
  - CInternetFile::Seek
dev_langs: 
  - C++
helpviewer_keywords: 
  - CInternetFile class, operations
  - Seek method
ms.assetid: f8a59653-374a-4064-b385-f124aaaaa63c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CInternetFile::Seek
Call this member function to reposition the pointer in a previously opened file.  
  
## Syntax  
  
```  
  
      virtual ULONGLONG Seek(   
   LONGLONG lOffset,   
   UINT nFrom    
);  
```  
  
#### Parameters  
 `lOffset`  
 Offset in bytes to move the read/write pointer in the file.  
  
 `nFrom`  
 Relative reference for the offset. Must be one of the following values:  
  
-   **CFile::begin** Move the file pointer `lOff` bytes forward from the beginning of the file.  
  
-   **CFile::current** Move the file pointer `lOff` bytes from the current position in the file.  
  
-   **CFile::end** Move the file pointer `lOff` bytes from the end of the file. `lOff` must be negative to seek into the existing file; positive values will seek past the end of the file.  
  
## Return Value  
 The new byte offset from the beginning of the file if the requested position is legal; otherwise, the value is undefined and a [CInternetException](../vs140/cinternetexception-class.md) object is thrown.  
  
## Remarks  
 The `Seek` function permits random access to a file's contents by moving the pointer a specified amount, absolutely or relatively. No data is actually read during the seek.  
  
 At this time, a call to this member function is only supported for data associated with `CHttpFile` objects. It is not supported for FTP or gopher requests. If you call `Seek` for one of these unsupported services, it will pass back you to the Win32 error code **ERROR_INTERNET_INVALID_OPERATION**.  
  
 When a file is opened, the file pointer is at offset 0, the beginning of the file.  
  
> [!NOTE]
>  Using `Seek` may cause an implicit call to [Flush](../vs140/cinternetfile--flush.md).  
  
## Exceptions  
 This method can throw exceptions of type `CInternetException*`.  
  
## Example  
 See the example for the base class implementation ([CFile::Seek](../vs140/cfile--seek.md)).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CInternetFile Class](../vs140/cinternetfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)