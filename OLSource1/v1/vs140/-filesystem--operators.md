---
title: "&lt;filesystem&gt; operators"
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
  - "FILESYSTEM/std::experimental::filesystem::v1::operator=="
  - "std::experimental::filesystem::v1::operator=="
  - "FILESYSTEM/std::experimental::filesystem::v1::operator!="
  - "std::experimental::filesystem::v1::operator!="
  - "FILESYSTEM/std::experimental::filesystem::v1::operator<"
  - "std::experimental::filesystem::v1::operator<"
  - "FILESYSTEM/std::experimental::filesystem::v1::operator<="
  - "std::experimental::filesystem::v1::operator<="
  - "FILESYSTEM/std::experimental::filesystem::v1::operator>"
  - "std::experimental::filesystem::v1::operator>"
  - "FILESYSTEM/std::experimental::filesystem::v1::operator>="
  - "std::experimental::filesystem::v1::operator>="
  - "FILESYSTEM/std::experimental::filesystem::v1::operator/"
  - "std::experimental::filesystem::v1::operator/"
  - "FILESYSTEM/std::experimental::filesystem::v1::operator<<"
  - "std::experimental::filesystem::v1::operator<<"
  - "FILESYSTEM/std::experimental::filesystem::v1::operator>>"
  - "std::experimental::filesystem::v1::operator>>"
dev_langs: 
  - "C++"
ms.assetid: 102c4833-aa3b-41a8-8998-f5003c546bfd
caps.latest.revision: 15
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# &lt;filesystem&gt; operators
The operators perform a lexical comparison of two paths as strings. Use the **equivalent** function to determine whether two paths (for example a relative path and an absolute path) refer to the same file or directory on disk.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 For more information, see [File System Navigation](../vs140/file-system-navigation.md).  
  
## operator==  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The function returns left.native() == right.native().  
  
## operator!=  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The function returns !(left == right).  
  
## operator<  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The function returns left.native() < right.native().  
  
## operator<=  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The function returns !(right \< left).  
  
## operator>  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The function returns right \< left.  
  
## operator>=  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The function returns !(left < right).  
  
## operator/  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The function executes:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## operator<<  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The function returns os << pval.string\<Elem, Traits>().  
  
## operator>>  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 The function executes:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
## See Also  
 [path Class (C++ Standard Template Library)](../vs140/path-class--c---standard-template-library-.md)   
 [File System Navigation](../vs140/file-system-navigation.md)   
 [\<filesystem> (v3)](../vs140/-filesystem-.md)