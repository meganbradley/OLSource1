---
title: "Opening Files"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Open member functions"
  - "CFile class, variable"
  - "opening files, in MFC"
  - "Open calls"
  - "Open method, CFile class"
  - "examples [MFC], opening files"
  - "opening files, handling exceptions"
  - "exception handling [C++], when opening files"
  - "files [C++], opening"
  - "file objects [C++]"
  - "MFC [C++], file operations"
  - "opening files"
  - "exception handling [C++], opening files"
ms.assetid: a991b8ec-b04a-4766-b47e-7485b5dd0b01
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Opening Files
In MFC, the most common way to open a file is a two-stage process.  
  
#### To open a file  
  
1.  Create the file object without specifying a path or permission flags.  
  
     You usually create a file object by declaring a [CFile](../vs140/cfile-class.md) variable on the stack frame.  
  
2.  Call the [Open](../vs140/cfile--open.md) member function for the file object, supplying a path and permission flags.  
  
     The return value for <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> will be nonzero if the file was opened successfully or 0 if the specified file could not be opened. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> member function is prototyped as follows:  
  
     <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
     The open flags specify which permissions, such as read-only, you want for the file. The possible flag values are defined as enumerated constants within the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class, so they are qualified with "<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>" as in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Use the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> flag if you want to create the file.  
  
 The following example shows how to create a new file with read/write permission (replacing any previous file with the same path):  
  
 [!code[NVC_MFCFiles#1](../vs140/codesnippet/CPP/opening-files_1.cpp)]  
  
> [!NOTE]
>  This example creates and opens a file. If there are problems, the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> call can return a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object in its last parameter, as shown here. The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> macro prints both the file name and a code indicating the reason for failure. You can call the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> function if you require more detailed error reporting.  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [CFile::Open](../vs140/cfile--open.md)   
 [Files](../vs140/files-in-mfc.md)