---
title: "CAtlTemporaryFile::Create"
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
  - "ATL::CAtlTemporaryFile::Create"
  - "CAtlTemporaryFile::Create"
  - "CAtlTemporaryFile.Create"
  - "ATL.CAtlTemporaryFile.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: bf8bce44-e482-4ee9-8088-7aa981bdf409
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTemporaryFile::Create
Call this method to create a temporary file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The path for the temporary file. If this is NULL, [GetTempPath](http://msdn.microsoft.com/library/windows/desktop/aa364992) will be called to assign a path.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The desired access. See <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in [CreateFile](http://msdn.microsoft.com/library/windows/desktop/aa363858) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> on failure.  
  
## Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlTemporaryFile Class](../vs140/catltemporaryfile-class.md)