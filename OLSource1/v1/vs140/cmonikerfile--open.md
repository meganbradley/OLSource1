---
title: "CMonikerFile::Open"
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
  - "CMonikerFile::Open"
  - "CMonikerFile.Open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Open method"
ms.assetid: ec3ec682-8b41-409a-b6ab-da50ccf2be77
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMonikerFile::Open
Call this member function to open a file or moniker object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A URL or filename of the file to be opened.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to a file exception. In the event of an error, it will be set to the cause.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A pointer to the moniker interface <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to be used to obtain a stream.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter cannot be used on a Macintosh. Only the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> form of **Open** can be used on a Macintosh.  
  
 You can use a URL or a filename for the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter. For example:  
  
 [!code[NVC_MFCWinInet#6](../vs140/codesnippet/CPP/cmonikerfile--open_1.cpp)]  
  
 – or –  
  
 [!code[NVC_MFCWinInet#7](../vs140/codesnippet/CPP/cmonikerfile--open_2.cpp)]  
  
## Requirements  
 **Header:** afxole.h  
  
## See Also  
 [CMonikerFile Class](../vs140/cmonikerfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMonikerFile::CMonikerFile](../vs140/cmonikerfile--cmonikerfile.md)   
 [CAsyncMonikerFile::Open](../vs140/casyncmonikerfile--open.md)