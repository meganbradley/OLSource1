---
title: "directory_entry Class"
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
  - "filesystem/std::tr2::sys::directory_entry"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::operator const std::experimental::filesystem::v1::path &"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::directory_entry"
  - "std::experimental::filesystem::v1::directory_entry::directory_entry"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::operator="
  - "std::experimental::filesystem::v1::directory_entry::operator="
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::assign"
  - "std::experimental::filesystem::v1::directory_entry::assign"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::replace_filename"
  - "std::experimental::filesystem::v1::directory_entry::replace_filename"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::path"
  - "std::experimental::filesystem::v1::directory_entry::path"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::status"
  - "std::experimental::filesystem::v1::directory_entry::status"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::symlink_status"
  - "std::experimental::filesystem::v1::directory_entry::symlink_status"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::operator<"
  - "std::experimental::filesystem::v1::directory_entry::operator<"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::operator=="
  - "std::experimental::filesystem::v1::directory_entry::operator=="
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::operator!="
  - "std::experimental::filesystem::v1::directory_entry::operator!="
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::operator<="
  - "std::experimental::filesystem::v1::directory_entry::operator<="
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::operator>"
  - "std::experimental::filesystem::v1::directory_entry::operator>"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_entry::operator>="
  - "std::experimental::filesystem::v1::directory_entry::operator>="
dev_langs: 
  - "C++"
ms.assetid: 1827c67b-4137-4548-adb0-f955f7acaf08
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# directory_entry Class
Describes an object that is returned by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, where *X* is a [directory_iterator](../vs140/directory_iterator-class.md) or a [recursive_directory_iterator](../vs140/recursive_directory_iterator-class.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The class stores an object of type [path](../vs140/path-class--c---standard-template-library-.md). The stored <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> can be an instance of the [path Class](../vs140/path-class--c---standard-template-library-.md) or of a type that is derived from <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. It also stores two [file_type](../vs140/file_type-enumeration.md) values; one that represents what is known about the status of the stored file name, and another that represents what is known about the symbolic link status of the file name.  
  
 For more information and code examples, see [File System Navigation](../vs140/file-system-navigation.md).  
  
## assign  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The member function assigns pval to mypath, stat to mystat, and symstat to mysymstat.  
  
## directory_entry  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The defaulted constructors behave as expected. The fourth constructor initializes mypath to pval, mystat to stat_arg, and mysymstat to symstat_arg.  
  
## operator!=  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The member function returns !(*this == right).  
  
## operator=  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The defaulted member assignment operators behave as expected.  
  
## operator==  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The member function returns mypath == right.mypath.  
  
## operator<  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The member function returns mypath < right.mypath.  
  
## operator<=  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The member function returns !(right \< *this).  
  
## operator>  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The member function returns right \< *this.  
  
## operator>=  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The member function returns !(*this < right).  
  
## operator const path_type&  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The member operator returns mypath.  
  
## path  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The member function returns mypath.  
  
## replace_filename  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The member function replaces mypath with mypath.parent_path() / pval, mystat with stat_arg, and mysymstat with symstat_arg  
  
## status  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 Both member functions return mystat possibly first altered as follows:  
  
1.  If status_known(mystat) then do nothing.  
  
2.  Otherwise, if !status_known(mysymstat) && !is_symlink(mysymstat) then mystat = mysymstat.  
  
## symlink_status  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
 Both member functions return mysymstat possibly first altered as follows:If status_known(mysymstat) then do nothing. Otherwise, mysymstat = symlink_status(mypval).  
  
## Requirements  
 **Header:** \<experimental/filesystem>  
  
 **Namespace:** std::experimental::filesystem::v1  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<filesystem>](../vs140/-filesystem-.md)