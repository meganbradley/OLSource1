---
title: "CFile::Abort"
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
  - "CFile::Abort"
  - "CFile.Abort"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFile class, construction/destruction"
  - "Abort method"
ms.assetid: 76f54d52-5b12-40c7-adad-a5c18d4919cf
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::Abort
Closes the file associated with this object and makes the file unavailable for reading or writing.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If you have not closed the file before destroying the object, the destructor closes it for you.  
  
 When handling exceptions, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> differs from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> in two important ways. First, the **Abort** function will not throw an exception on failures because failures are ignored by **Abort**. Second, **Abort** will not **ASSERT** if the file has not been opened or was closed previously.  
  
 If you used **new** to allocate the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object on the heap, then you must delete it after closing the file. **Abort** sets <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFCFiles#5](../vs140/codesnippet/CPP/cfile--abort_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::Close](../vs140/cfile--close.md)   
 [CFile::Open](../vs140/cfile--open.md)