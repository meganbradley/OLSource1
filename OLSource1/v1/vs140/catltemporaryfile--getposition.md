---
title: "CAtlTemporaryFile::GetPosition"
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
  - "ATL.CAtlTemporaryFile.GetPosition"
  - "CAtlTemporaryFile.GetPosition"
  - "ATL::CAtlTemporaryFile::GetPosition"
  - "CAtlTemporaryFile::GetPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPosition method"
ms.assetid: 8ee6f550-0380-4a43-86e0-e187e3e7eaeb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTemporaryFile::GetPosition
Call this method to get the current file pointer position.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The position in bytes.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 To change the file pointer position, use [CAtlTemporaryFile::Seek](../vs140/catltemporaryfile--seek.md).  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlTemporaryFile Class](../vs140/catltemporaryfile-class.md)   
 [CAtlFile::GetPosition](../vs140/catlfile--getposition.md)