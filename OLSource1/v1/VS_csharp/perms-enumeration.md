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
Flags for file permissions. The supported values are essentially “readonly” and all. For a readonly file, none of the *_write bits are set. Otherwise the `all` bit (0x0777) is set.  
  
## Syntax  
  
```vb  
enum class perms {    // names for permissions    none = 0,    owner_read = 0400,    // S_IRUSR    owner_write = 0200,    // S_IWUSR    owner_exec = 0100,    // S_IXUSR    owner_all = 0700,    // S_IRWXU    group_read = 040,    // S_IRGRP    group_write = 020,    // S_IWGRP    group_exec = 010,    // S_IXGRP    group_all = 070,    // S_IRWXG    others_read = 04,    // S_IROTH    others_write = 02,    // S_IWOTH    others_exec = 01,    // S_IXOTH    others_all = 07,    // S_IRWXO    all = 0777,    set_uid = 04000,    // S_ISUID    set_gid = 02000,    // S_ISGID    sticky_bit = 01000,    // S_ISVTX    mask = 07777,    unknown = 0xFFFF,    add_perms = 0x10000,    remove_perms = 0x20000,    resolve_symlinks = 0x40000    };  
```  
  
## Requirements  
 <filesystem\>  
  
## See Also  
 [File System Navigation](../VS_csharp/file-system-navigation.md)   
 [<filesystem\> (v3)](../VS_csharp/-filesystem-.md)