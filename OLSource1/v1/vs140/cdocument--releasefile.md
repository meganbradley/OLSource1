---
title: "CDocument::ReleaseFile"
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
  - "ReleaseFile"
  - "CDocument.ReleaseFile"
  - "CDocument::ReleaseFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDocument class, overridables"
  - "releasing files"
  - "document files, managing"
  - "ReleaseFile method"
  - "releasing documents"
ms.assetid: e3a598e1-4027-44e5-b41d-bea2f1ae5040
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::ReleaseFile
This member function is called by the framework to release a file, making it available for use by other applications.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the CFile object to be released.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies whether the file is to be released by using either <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. **FALSE** if the file is to be released using [CFile::Close](../vs140/cfile--close.md); **TRUE** if the file is to be released using [CFile::Abort](../vs140/cfile--abort.md).  
  
## Remarks  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is **TRUE**, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and the file is released. <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> will not throw an exception.  
  
 If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is **FALSE**, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> calls <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and the file is released.  
  
 Override this member function to require an action by the user before the file is released.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDocTemplate Class](../vs140/cdoctemplate-class.md)   
 [CFile::Close](../vs140/cfile--close.md)   
 [CFile::Abort](../vs140/cfile--abort.md)