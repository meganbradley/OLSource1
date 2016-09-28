---
title: "CFile::Seek"
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
  - "CFile.Seek"
  - "CFile::Seek"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFile class, position"
  - "Seek method"
ms.assetid: bc84d84b-1a5d-4143-aa0f-fdc8b089745e
caps.latest.revision: 17
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::Seek
Repositions the file pointer in an open file.  
  
## Syntax  
  
```  
virtual ULONGLONG Seek(  
   LONGLONG lOff,  
   UINT nFrom   
);  
```  
  
#### Parameters  
 `lOff`  
 Number of bytes to move the file pointer. Positive values move the file pointer towards the end of the file; negative values move the file pointer towards the start of the file.  
  
 `nFrom`  
 Position to seek from. See the Remarks section for possible values.  
  
## Return Value  
 The position of the file pointer if the method was successful; otherwise, the return value is undefined and a pointer to a `CFileException` exception is thrown.  
  
## Remarks  
 The following table lists possible values for the `nFrom` parameter.  
  
|Value|Description|  
|-----------|-----------------|  
|`CFile::begin`|Seek from the start of the file.|  
|`CFile::current`|Seek from the current location of the file pointer.|  
|`CFile::end`|Seek from the end of the file.|  
  
 When a file is opened, the file pointer is positioned at 0, the start of the file.  
  
 You can set the file pointer to a position beyond the end of a file. If you do this, the size of the file does not increase until you write to the file.  
  
 The exception handler for this method must delete the exception object after the exception is processed.  
  
## Example  
 [!code[NVC_MFCFiles#9](../vs140/codesnippet/CPP/cfile--seek_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)