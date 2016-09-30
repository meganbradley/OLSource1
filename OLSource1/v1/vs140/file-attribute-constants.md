---
title: "File Attribute Constants"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "A_HIDDEN"
  - "_A_NORMAL"
  - "_A_SUBDIR"
  - "_A_RDONLY"
  - "A_NORMAL"
  - "A_SUBDIR"
  - "_A_SYSTEM"
  - "c.constants.file"
  - "_A_HIDDEN"
  - "A_RDONLY"
  - "_A_ARCH"
  - "A_ARCH"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "constants [C++], file attributes"
  - "file attribute constants [C++]"
  - "_A_SYSTEM constant"
  - "files [C++], file attribute constants"
  - "_A_SUBDIR constant"
  - "_A_ARCH constant"
  - "_A_NORMAL constant"
  - "_A_HIDDEN constant"
  - "_A_RDONLY constant"
ms.assetid: 8dc8ccb9-99f5-446b-876c-7ebecc2f764f
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# File Attribute Constants
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 These constants specify the current attributes of the file or directory specified by the function.  
  
 The attributes are represented by the following manifest constants:  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Archive. Set whenever the file is changed, and cleared by the BACKUP command. Value: 0x20  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Hidden file. Not normally seen with the DIR command, unless the /AH option is used. Returns information about normal files as well as files with this attribute. Value: 0x02  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Normal. File can be read or written to without restriction. Value: 0x00  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Read-only. File cannot be opened for writing, and a file with the same name cannot be created. Value: 0x01  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Subdirectory. Value: 0x10  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 System file. Not normally seen with the DIR command, unless the /AS option is used. Value: 0x04  
  
 Multiple constants can be combined with the OR operator (&#124;).  
  
## See Also  
 [Filename Search Functions](../vs140/filename-search-functions.md)   
 [Global Constants](../vs140/global-constants.md)