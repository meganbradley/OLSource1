---
title: "&lt;filesystem&gt; functions"
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
  - "FILESYSTEM/std::experimental::filesystem::v1::absolute"
  - "std::experimental::filesystem::v1::absolute"
  - "FILESYSTEM/std::experimental::filesystem::v1::canonical"
  - "std::experimental::filesystem::v1::canonical"
  - "FILESYSTEM/std::experimental::filesystem::v1::copy"
  - "std::experimental::filesystem::v1::copy"
  - "FILESYSTEM/std::experimental::filesystem::v1::copy_file"
  - "std::experimental::filesystem::v1::copy_file"
  - "FILESYSTEM/std::experimental::filesystem::v1::copy_symlink"
  - "std::experimental::filesystem::v1::copy_symlink"
  - "FILESYSTEM/std::experimental::filesystem::v1::create_directories"
  - "std::experimental::filesystem::v1::create_directories"
  - "FILESYSTEM/std::experimental::filesystem::v1::create_directory"
  - "std::experimental::filesystem::v1::create_directory"
  - "FILESYSTEM/std::experimental::filesystem::v1::create_directory_symlink"
  - "std::experimental::filesystem::v1::create_directory_symlink"
  - "FILESYSTEM/std::experimental::filesystem::v1::create_hard_link"
  - "std::experimental::filesystem::v1::create_hard_link"
  - "FILESYSTEM/std::experimental::filesystem::v1::create_symlink"
  - "std::experimental::filesystem::v1::create_symlink"
  - "FILESYSTEM/std::experimental::filesystem::v1::current_path"
  - "std::experimental::filesystem::v1::current_path"
  - "FILESYSTEM/std::experimental::filesystem::v1::equivalent"
  - "std::experimental::filesystem::v1::equivalent"
  - "FILESYSTEM/std::experimental::filesystem::v1::exists"
  - "std::experimental::filesystem::v1::exists"
  - "FILESYSTEM/std::experimental::filesystem::v1::file_size"
  - "std::experimental::filesystem::v1::file_size"
  - "FILESYSTEM/std::experimental::filesystem::v1::hard_link_count"
  - "std::experimental::filesystem::v1::hard_link_count"
  - "FILESYSTEM/std::experimental::filesystem::v1::hash_value"
  - "std::experimental::filesystem::v1::hash_value"
  - "FILESYSTEM/std::experimental::filesystem::v1::is_block_file"
  - "std::experimental::filesystem::v1::is_block_file"
  - "FILESYSTEM/std::experimental::filesystem::v1::is_character_file"
  - "std::experimental::filesystem::v1::is_character_file"
  - "FILESYSTEM/std::experimental::filesystem::v1::is_directory"
  - "std::experimental::filesystem::v1::is_directory"
  - "FILESYSTEM/std::experimental::filesystem::v1::is_empty"
  - "std::experimental::filesystem::v1::is_empty"
  - "FILESYSTEM/std::experimental::filesystem::v1::is_fifo"
  - "std::experimental::filesystem::v1::is_fifo"
  - "FILESYSTEM/std::experimental::filesystem::v1::is_other"
  - "std::experimental::filesystem::v1::is_other"
  - "FILESYSTEM/std::experimental::filesystem::v1::is_regular_file"
  - "std::experimental::filesystem::v1::is_regular_file"
  - "FILESYSTEM/std::experimental::filesystem::v1::is_socket"
  - "std::experimental::filesystem::v1::is_socket"
  - "FILESYSTEM/std::experimental::filesystem::v1::is_symlink"
  - "std::experimental::filesystem::v1::is_symlink"
  - "FILESYSTEM/std::experimental::filesystem::v1::last_write_time"
  - "std::experimental::filesystem::v1::last_write_time"
  - "FILESYSTEM/std::experimental::filesystem::v1::permissions"
  - "std::experimental::filesystem::v1::permissions"
  - "FILESYSTEM/std::experimental::filesystem::v1::read_symlink"
  - "std::experimental::filesystem::v1::read_symlink"
  - "FILESYSTEM/std::experimental::filesystem::v1::remove"
  - "std::experimental::filesystem::v1::remove"
  - "FILESYSTEM/std::experimental::filesystem::v1::remove_all"
  - "std::experimental::filesystem::v1::remove_all"
  - "FILESYSTEM/std::experimental::filesystem::v1::rename"
  - "std::experimental::filesystem::v1::rename"
  - "FILESYSTEM/std::experimental::filesystem::v1::resize_file"
  - "std::experimental::filesystem::v1::resize_file"
  - "FILESYSTEM/std::experimental::filesystem::v1::space"
  - "std::experimental::filesystem::v1::space"
  - "FILESYSTEM/std::experimental::filesystem::v1::status"
  - "std::experimental::filesystem::v1::status"
  - "FILESYSTEM/std::experimental::filesystem::v1::status_known"
  - "std::experimental::filesystem::v1::status_known"
  - "FILESYSTEM/std::experimental::filesystem::v1::swap"
  - "std::experimental::filesystem::v1::swap"
  - "FILESYSTEM/std::experimental::filesystem::v1::symlink_status"
  - "std::experimental::filesystem::v1::symlink_status"
  - "FILESYSTEM/std::experimental::filesystem::v1::system_complete"
  - "std::experimental::filesystem::v1::system_complete"
  - "FILESYSTEM/std::experimental::filesystem::v1::temp_directory_path"
  - "std::experimental::filesystem::v1::temp_directory_path"
  - "FILESYSTEM/std::experimental::filesystem::v1::u8path"
  - "std::experimental::filesystem::v1::u8path"
dev_langs: 
  - "C++"
ms.assetid: be3cb821-4728-4d47-ab78-858fa8aa5045
caps.latest.revision: 16
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# &lt;filesystem&gt; functions
These free functions in the [\<filesystem> (v3)](../vs140/-filesystem-.md) header perform modifying and query operations on paths, files, symlinks, directories and volumes. For more information and code examples, see [File System Navigation](../vs140/file-system-navigation.md).  
  
## absolute  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The function returns the absolute pathname corresponding to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> relative to the pathname <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>:  
  
1.  If pval.has_root_name() && pval.has_root_directory() the function returns pval.  
  
2.  If pval.has_root_name() && !pval.has_root_directory() the function returns pval.root_name() / absolute(base).root_directory() / absolute(base).relative_path() / pval.relative_path().  
  
3.  If !pval.has_root_name() && pval.has_root_directory() the function returns absolute(base).root_name() / pval.  
  
4.  If !pval.has_root_name() && !pval.has_root_directory() the function returns absolute(base) / pval.  
  
## begin  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Both functions return <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>.  
  
## canonical  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The functions all form an absolute pathname pabs = absolute(pval, base) (or pabs = absolute(pval) for the overload with no base parameter), then reduce it to a canonical form in the following sequence of steps:  
  
1.  Every path component X for which is_symlink(X) is true is replaced by read_symlink(X).  
  
2.  Every path component . (dot is the current directory established by previous path components) is removed.  
  
3.  Every pair of path components X/.. (dot-dot is the parent directory established by previous path components) is removed.  
  
 The function then returns pabs.  
  
## copy  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The functions all possibly copy or link one or more files at <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> under control of <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, which is taken as copy_options::none for the overloads with no <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> parameter. <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> shall contain at most one of:  
  
-   skip_existing, overwrite_existing, or update_existing  
  
-   copy_symlinks or skip_symlinks  
  
-   directories_only, create_symlinks, or create_hard_links  
  
 The functions first determine the file_status values f for <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and t for <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>:  
  
-   if opts & (copy_options::create_symlinks &#124; copy_options::skip_symlinks), by calling symlink_status  
  
-   otherwise, by calling status  
  
-   Otherwise report an error.  
  
 If !exists(f) &#124;&#124; equivalent(f, t) &#124;&#124; is_other(f) &#124;&#124; is_other(t) &#124;&#124; is_directory(f)&& is_regular_file(t), they then report an error (and do nothing else).  
  
 Otherwise, if is_symlink(f) then:  
  
-   If options & copy_options::skip_symlinks then do nothing.  
  
-   Otherwise, if !exists(t)&& options & copy_options::copy_symlinks then copy_symlink(from, to, opts).  
  
-   Otherwise report an error.  
  
 Otherwise, if is_regular_file(f) then:  
  
-   If opts & copy_options::directories_only then do nothing.  
  
-   Otherwise, if opts & copy_options::create_symlinks then create_symlink(to, from).  
  
-   Otherwise, if opts & copy_options::create_hard_links then create_hard_link(to, from).  
  
-   Otherwise, if is_directory(f) then copy_file(from, to / from.filename(), opts).  
  
-   Otherwise, copy_file(from, to, opts).  
  
 Otherwise, if is_directory(f) && (opts & copy_options::recursive &#124;&#124; !opts) then:  
  
-   <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>  
  
 The first function behaves the same as path(source) and the second function behaves the same as path(first, last) except that the designated source in each case is taken as a sequence of char elements encoded as UTF-8, regardless of the filesystem.