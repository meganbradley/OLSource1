---
title: "perms Enumeration"
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
  - "filesystem/std::tr2::sys::permissions"
dev_langs: 
  - "C++"
ms.assetid: 94d4d669-db45-432d-9576-489a138896ec
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# perms Enumeration
Flags for file permissions. The supported values are essentially “readonly” and all. For a readonly file, none of the *_write bits are set. Otherwise the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> bit (0x0777) is set.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Requirements  
 \<filesystem>  
  
## See Also  
 [File System Navigation](../vs140/file-system-navigation.md)   
 [\<filesystem> (v3)](../vs140/-filesystem-.md)