---
title: "CAtlFile::GetSize"
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
  - "CAtlFile.GetSize"
  - "CAtlFile::GetSize"
  - "ATL::CAtlFile::GetSize"
  - "ATL.CAtlFile.GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSize method"
ms.assetid: 8334a5e5-7cd8-4857-90db-77893c726439
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFile::GetSize
Call this method to get the size in bytes of the file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The number of bytes in the file.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 Calls [GetFileSize](http://msdn.microsoft.com/library/windows/desktop/aa364955) to get the size in bytes of the file.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)   
 [CAtlFile::GetPosition](../vs140/catlfile--getposition.md)   
 [CAtlFile::SetSize](../vs140/catlfile--setsize.md)