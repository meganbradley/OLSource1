---
title: "CAtlFile::Write"
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
  - "CAtlFile.Write"
  - "ATL::CAtlFile::Write"
  - "CAtlFile::Write"
  - "ATL.CAtlFile.Write"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Write method"
ms.assetid: 135cebb6-a01f-41e0-8fae-44aeaee8e4fb
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFile::Write
Call this method to write data to the file starting at the position indicated by the file pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The buffer containing the data to be written to the file.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The number of bytes to be transferred from the buffer.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The overlapped structure. See <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in [WriteFile](http://msdn.microsoft.com/library/windows/desktop/aa365747) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The completion routine. See *lpCompletionRoutine* in [WriteFileEx](http://msdn.microsoft.com/library/windows/desktop/aa365748) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The bytes written.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 The first three forms call [WriteFile](http://msdn.microsoft.com/library/windows/desktop/aa365747), the last calls [WriteFileEx](http://msdn.microsoft.com/library/windows/desktop/aa365748) to write data to the file. Use [CAtlFile::Seek](../vs140/catlfile--seek.md) to move the file pointer.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)   
 [CAtlFile::Read](../vs140/catlfile--read.md)