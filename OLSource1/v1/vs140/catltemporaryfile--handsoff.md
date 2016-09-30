---
title: "CAtlTemporaryFile::HandsOff"
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
  - "ATL::CAtlTemporaryFile::HandsOff"
  - "HandsOff"
  - "CAtlTemporaryFile.HandsOff"
  - "CAtlTemporaryFile::HandsOff"
  - "ATL.CAtlTemporaryFile.HandsOff"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HandsOff method"
ms.assetid: 12254237-40e7-4910-bce4-968bea32d157
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTemporaryFile::HandsOff
Call this method to disassociate the file from the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and [CAtlTemporaryFile::HandsOn](../vs140/catltemporaryfile--handson.md) are used to disassociate the file from the object, and reattach it if needed. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> will force any data remaining in the file buffer to be written to the temporary file, and then close the file. If you want to close and delete the file permanently, or if you want to close and retain the contents of the file with a given name, use [CAtlTemporaryFile::Close](../vs140/catltemporaryfile--close.md).  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlTemporaryFile Class](../vs140/catltemporaryfile-class.md)   
 [CAtlTemporaryFile::HandsOn](../vs140/catltemporaryfile--handson.md)