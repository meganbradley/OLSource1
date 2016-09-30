---
title: "CAtlTemporaryFile::Write"
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
  - "ATL::CAtlTemporaryFile::Write"
  - "ATL.CAtlTemporaryFile.Write"
  - "CAtlTemporaryFile::Write"
  - "CAtlTemporaryFile.Write"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Write method"
ms.assetid: eea4d0e3-330e-4867-8007-ed454024ca5f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTemporaryFile::Write
Call this method to write data to the temporary file starting at the position indicated by the file pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The buffer containing the data to be written to the file.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of bytes to be transferred from the buffer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of bytes written.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 Calls [CAtlFile::Write](../vs140/catlfile--write.md).  
  
## Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlTemporaryFile Class](../vs140/catltemporaryfile-class.md)   
 [CAtlTemporaryFile::Read](../vs140/catltemporaryfile--read.md)