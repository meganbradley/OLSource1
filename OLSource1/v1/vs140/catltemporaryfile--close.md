---
title: "CAtlTemporaryFile::Close"
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
  - "CAtlTemporaryFile::Close"
  - "ATL::CAtlTemporaryFile::Close"
  - "ATL.CAtlTemporaryFile.Close"
  - "CAtlTemporaryFile.Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Close method"
ms.assetid: dec76396-da76-4be0-8cb8-ed8ad4a17ff8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTemporaryFile::Close
Call this method to close a temporary file and either delete its contents or store them under the specified file name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *szNewName*  
 The name for the new file to store the contents of the temporary file in. If this argument is NULL, the contents of the temporary file are deleted.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on failure.  
  
## Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlTemporaryFile Class](../vs140/catltemporaryfile-class.md)   
 [CAtlTemporaryFile::HandsOff](../vs140/catltemporaryfile--handsoff.md)   
 [CAtlTemporaryFile::Create](../vs140/catltemporaryfile--create.md)