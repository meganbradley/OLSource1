---
title: "CAtlFile::GetOverlappedResult"
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
  - "ATL::CAtlFile::GetOverlappedResult"
  - "CAtlFile::GetOverlappedResult"
  - "ATL.CAtlFile.GetOverlappedResult"
  - "CAtlFile.GetOverlappedResult"
  - "GetOverlappedResult"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetOverlappedResult method"
ms.assetid: 87f978a8-7cea-4793-899a-77c82388fb39
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFile::GetOverlappedResult
Call this method to get the results of an overlapped operation on the file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The overlapped structure. See <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in [GetOverlappedResult](http://msdn.microsoft.com/library/windows/desktop/ms683209) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 *dwBytesTransferred*  
 The bytes transferred. See *lpNumberOfBytesTransferred* in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The wait option. See <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 Calls [GetOverlappedResult](http://msdn.microsoft.com/library/windows/desktop/ms683209) to get the results of an overlapped operation on the file.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)