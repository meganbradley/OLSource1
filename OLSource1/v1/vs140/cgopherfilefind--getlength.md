---
title: "CGopherFileFind::GetLength"
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
  - "CGopherFileFind::GetLength"
  - "CGopherFileFind.GetLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CGopherFileFind class, attributes"
  - "GetLength method"
ms.assetid: 35fc7bf8-1285-44b4-9799-d811dfea2646
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherFileFind::GetLength
Call this member function to get the length, in bytes, of the found file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The length, in bytes, of the found file.  
  
## Remarks  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> uses the Win32 structure [WIN32_FIND_DATA](http://msdn.microsoft.com/library/windows/desktop/aa365740) to get the value of the file size in bytes.  
  
> [!NOTE]
>  As of MFC 7.0, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> supports 64-bit integer types. Previously-existing code built with this newer version of the library may result in truncation warnings.  
  
## Example  
 See the example for [CFile::GetLength](../vs140/cfile--getlength.md) (the base class implementation).  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFileFind Class](../vs140/cfilefind-class.md)