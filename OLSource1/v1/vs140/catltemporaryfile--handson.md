---
title: "CAtlTemporaryFile::HandsOn"
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
  - "HandsOn"
  - "CAtlTemporaryFile::HandsOn"
  - "ATL.CAtlTemporaryFile.HandsOn"
  - "ATL::CAtlTemporaryFile::HandsOn"
  - "CAtlTemporaryFile.HandsOn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HandsOn method"
ms.assetid: 7e64502d-b65b-48fb-8cc3-330d0eade67c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTemporaryFile::HandsOn
Call this method to open an existing temporary file and position the pointer at the end of the file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 [CAtlTemporaryFile::HandsOff](../vs140/catltemporaryfile--handsoff.md) and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are used to disassociate the file from the object, and reattach it if needed.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlTemporaryFile Class](../vs140/catltemporaryfile-class.md)   
 [CAtlTemporaryFile::HandsOff](../vs140/catltemporaryfile--handsoff.md)