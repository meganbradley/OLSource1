---
title: "CFile::Close"
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
  - "CFile::Close"
  - "CFile.Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Close method"
  - "CFile class, construction/destruction"
ms.assetid: ba12bcef-bf23-49ae-8871-4f4fb0ea98c1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::Close
Closes the file associated with this object and makes the file unavailable for reading or writing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If you have not closed the file before destroying the object, the destructor closes it for you.  
  
 If you used **new** to allocate the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object on the heap, then you must delete it after closing the file. **Close** sets <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Example  
 See the example for [CFile::CFile](../vs140/cfile--cfile.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::Open](../vs140/cfile--open.md)