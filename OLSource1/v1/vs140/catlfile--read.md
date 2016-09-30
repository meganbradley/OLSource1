---
title: "CAtlFile::Read"
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
  - "ATL::CAtlFile::Read"
  - "CAtlFile.Read"
  - "CAtlFile::Read"
  - "ATL.CAtlFile.Read"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Read method"
ms.assetid: 1b0e02d1-a5a3-48c4-a590-19f44ba1c0f4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFile::Read
Call this method to read data from a file starting at the position indicated by the file pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the buffer that will receive the data read from the file.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The buffer size in bytes.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of bytes read.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The overlapped structure. See <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in [ReadFile](http://msdn.microsoft.com/library/windows/desktop/aa365467) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The completion routine. See *lpCompletionRoutine* in [ReadFileEx](http://msdn.microsoft.com/library/windows/desktop/aa365468) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 The first three forms call [ReadFile](http://msdn.microsoft.com/library/windows/desktop/aa365467), the last [ReadFileEx](http://msdn.microsoft.com/library/windows/desktop/aa365468) to read data from the file. Use [CAtlFile::Seek](../vs140/catlfile--seek.md) to move the file pointer.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)   
 [CAtlFile::Write](../vs140/catlfile--write.md)