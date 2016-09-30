---
title: "CAtlTemporaryFile::Read"
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
  - "CAtlTemporaryFile.Read"
  - "CAtlTemporaryFile::Read"
  - "ATL.CAtlTemporaryFile.Read"
  - "ATL::CAtlTemporaryFile::Read"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Read method"
ms.assetid: 96d1c3dd-d84a-4cb5-bf15-cc55005b12bb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTemporaryFile::Read
Call this method to read data from the temporary file starting at the position indicated by the file pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the buffer that will receive the data read from the file.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The buffer size in bytes.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of bytes read.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 Calls [CAtlFile::Read](../vs140/catlfile--read.md). To change the position of the file pointer, call [CAtlTemporaryFile::Seek](../vs140/catltemporaryfile--seek.md).  
  
## Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlTemporaryFile Class](../vs140/catltemporaryfile-class.md)   
 [CAtlTemporaryFile::Write](../vs140/catltemporaryfile--write.md)