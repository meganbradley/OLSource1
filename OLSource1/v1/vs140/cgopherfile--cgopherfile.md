---
title: "CGopherFile::CGopherFile"
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
  - "CGopherFile"
  - "CGopherFile::CGopherFile"
  - "CGopherFile.CGopherFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CGopherFile class, constructor"
ms.assetid: 2035c041-3ebd-4ed3-aba6-96a6534e76d6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGopherFile::CGopherFile
This member function is called to construct a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A handle to an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> file.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A reference to a [CGopherLocator](../vs140/cgopherlocator-class.md) object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to a [CGopherConnection](../vs140/cgopherconnection-class.md) object.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A handle to the current Internet session.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 A pointer to a string used to locate the gopher server. See [Gopher Sessions](_inet_Gopher_Sessions) for more information about gopher locators.  
  
 *dwLocLen*  
 A DWORD containing the number of bytes in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 A pointer to the context identifier of the file being opened.  
  
## Remarks  
 You need a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object to read from a file during a gopher Internet session.  
  
 You never create a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object directly. Instead, call [CGopherConnection::OpenFile](../vs140/cgopherconnection--openfile.md) to open a file on a gopher server.  
  
## Requirements  
 **Header:** afxinet.h  
  
## See Also  
 [CGopherFile Class](../vs140/cgopherfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CInternetFile Class](../vs140/cinternetfile-class.md)   
 [CGopherLocator Class](../vs140/cgopherlocator-class.md)   
 [CGopherFileFind Class](../vs140/cgopherfilefind-class.md)   
 [CGopherConnection Class](../vs140/cgopherconnection-class.md)