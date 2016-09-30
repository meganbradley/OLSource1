---
title: "CAtlFile::SetSize"
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
  - "ATL.CAtlFile.SetSize"
  - "CAtlFile.SetSize"
  - "CAtlFile::SetSize"
  - "ATL::CAtlFile::SetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSize method"
ms.assetid: 1b2c1a48-a1de-432d-9406-3a70ef0bac1a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFile::SetSize
Call this method to set the size of the file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The new length of the file in bytes.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 Calls [SetFilePointer](http://msdn.microsoft.com/library/windows/desktop/aa365541) and [SetEndOfFile](http://msdn.microsoft.com/library/windows/desktop/aa365531) to set the size of the file. On return, the file pointer is positioned at the end of the file.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)   
 [CAtlFile::GetSize](../vs140/catlfile--getsize.md)