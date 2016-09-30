---
title: "copy_option Enumeration &lt;filesystem&gt;"
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
  - "filesystem/std::tr2::sys::copy_option"
  - "FILESYSTEM/std::experimental::filesystem::v1::copy_options"
  - "std::experimental::filesystem::v1::copy_options"
  - "FILESYSTEM/none"
  - "FILESYSTEM/skip_existing"
  - "skip_existing"
  - "FILESYSTEM/overwrite_existing"
  - "overwrite_existing"
  - "FILESYSTEM/update_existing"
  - "update_existing"
  - "FILESYSTEM/recursive"
  - "FILESYSTEM/copy_symlinks"
  - "copy_symlinks"
  - "FILESYSTEM/skip_symlinks"
  - "skip_symlinks"
  - "FILESYSTEM/create_symlinks"
  - "create_symlinks"
  - "FILESYSTEM/directories_only"
  - "directories_only"
  - "FILESYSTEM/create_hard_links"
  - "create_hard_links"
  - "FILESYSTEM/_Unspecified_recursion_prevention_tag"
  - "_Unspecified_recursion_prevention_tag"
dev_langs: 
  - "C++"
ms.assetid: 351bcdc5-a013-440a-a1d2-d34dfbd92540
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# copy_option Enumeration &lt;filesystem&gt;
An enumeration of bitmask values that is used with [copy](assetId:///4af7a9b0-8861-45ed-b84e-0307f0669d60) and [copy_file](assetId:///4af7a9b0-8861-45ed-b84e-0307f0669d60) functions to specify behavior.  
  
## Syntax  
  
```  
enum class copy_options {      
    none = 0,  
    skip_existing = 1,  
    overwrite_existing = 2,  
    update_existing = 4,  
    recursive = 8,  
    copy_symlinks = 16,  
    skip_symlinks = 32,  
    directories_only = 64,  
    create_symlinks = 128,  
    create_hard_links = 256  
    };  
```  
  
## Members  
  
### Values  
  
|`Name`|Description|  
|------------|-----------------|  
|`none`|Perform the default behavior for the operation.|  
|`skip_existing`|Do not copy if the file already exists, do not report an error.|  
|`overwrite_existing`|Overwrite the file if it already exists.|  
|`update_existing`|Overwrite the file if it already exists and is older than the replacement.|  
|`recursive`|Recursively copy subdirectories and their contents.|  
|`copy_symlinks`|Copy symbolic links as symbolic links, instead of copying the files they point to.|  
|`skip_symlinks`|Ignore symbolic links.|  
|`directories_only`|Only iterate over directories, ignore files.|  
|`create_symlinks`|Make symbolic links instead of copying files. An absolute path must be used as the source path unless the destination is the current directory.|  
|`create_hard_links`|Make hard links instead of copying files.|  
  
## Requirements  
 **Header:** \<experimental/filesystem>  
  
 **Namespace:** std::experimental::filesystem::copy_option  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<filesystem>](../vs140/-filesystem-.md)