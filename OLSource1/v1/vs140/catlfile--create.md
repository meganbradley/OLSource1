---
title: "CAtlFile::Create"
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
  - "ATL.CAtlFile.Create"
  - "ATL::CAtlFile::Create"
  - "CAtlFile::Create"
  - "CAtlFile.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: d2bc9cc1-206f-45ca-824a-18b12122d6e4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFile::Create
Call this method to create or open a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *szFilename*  
 The file name.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The desired access. See <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in [CreateFile](http://msdn.microsoft.com/library/windows/desktop/aa363858) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The share mode. See <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> in **CreateFile**.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The creation disposition. See <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in **CreateFile**.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The flags and attributes. See <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in **CreateFile**.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The security attributes. See *lpSecurityAttributes* in **CreateFile**.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The template file. See <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in **CreateFile**.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 Calls [CreateFile](http://msdn.microsoft.com/library/windows/desktop/aa363858) to create or open the file.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)