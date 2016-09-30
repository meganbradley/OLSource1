---
title: "Path Field Limits"
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
  - "_MAX_EXT"
  - "_MAX_DIR"
  - "_MAX_PATH"
  - "_MAX_FNAME"
  - "_MAX_DRIVE"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "path field constants"
  - "MAX_FNAME constant"
  - "_MAX_DIR constant"
  - "_MAX_DRIVE constant"
  - "paths, maximum limit"
  - "_MAX_PATH constant"
  - "MAX_DRIVE constant"
  - "_MAX_FNAME constant"
  - "_MAX_EXT constant"
  - "MAX_DIR constant"
  - "MAX_EXT constant"
ms.assetid: 2b5d0e43-1347-45b4-8397-24a8a45c444e
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Path Field Limits
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 These constants define the maximum length for the path and for the individual fields within the path.  
  
|Constant|Meaning|  
|--------------|-------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Maximum length of directory component|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|Maximum length of drive component|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Maximum length of extension component|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Maximum length of filename component|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Maximum length of full path|  
  
> [!NOTE]
>  The C Runtime supports path lengths up to 32768 characters in length, but it is up to the operating system, specifically the file system, to support these longer paths. The sum of the fields should not exceed <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> for full backwards compatibility with FAT32 file systems. [!INCLUDE[win2kfamily](../vs140/includes/win2kfamily_md.md)], [!INCLUDE[WinXpFamily](../vs140/includes/winxpfamily_md.md)], [!INCLUDE[WinXPSvr](../vs140/includes/winxpsvr_md.md)], and Windows Vista NTFS file system supports paths up to 32768 characters in length, but only when using the Unicode APIs. When using long path names, prefix the path with the characters \\\\?\ and use the Unicode versions of the C Runtime functions.  
  
## See Also  
 [Global Constants](../vs140/global-constants.md)