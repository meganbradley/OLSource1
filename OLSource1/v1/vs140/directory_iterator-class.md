---
title: "directory_iterator Class"
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
  - "filesystem/std::tr2::sys::directory_iterator"
  - "directory_iterator"
  - "filesystem/std::experimental::filesystem::v1::_Directory_iterator::_Directory_iterator"
  - "filesystem/std::experimental::filesystem::v1::directory_iterator"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_iterator::directory_iterator"
  - "std::experimental::filesystem::v1::directory_iterator::directory_iterator"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_iterator::increment"
  - "std::experimental::filesystem::v1::directory_iterator::increment"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_iterator::operator="
  - "std::experimental::filesystem::v1::directory_iterator::operator="
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_iterator::operator=="
  - "std::experimental::filesystem::v1::directory_iterator::operator=="
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_iterator::operator!="
  - "std::experimental::filesystem::v1::directory_iterator::operator!="
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_iterator::operator*"
  - "std::experimental::filesystem::v1::directory_iterator::operator*"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_iterator::operator->"
  - "std::experimental::filesystem::v1::directory_iterator::operator->"
  - "FILESYSTEM/std::experimental::filesystem::v1::directory_iterator::operator++"
  - "std::experimental::filesystem::v1::directory_iterator::operator++"
dev_langs: 
  - "C++"
ms.assetid: dca2ecf8-3e69-4644-a83d-705061e10cc8
caps.latest.revision: 22
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# directory_iterator Class
Describes an input iterator that sequences through the filenames in a directory. For an iterator X, the expression *X evaluates to an object of class directory_entry that wraps the filename and anything known about its status.  
  
 The class stores an object of type path, called mydir here for the purposes of exposition, which represents the name of the directory to be sequenced, and an object of type directory_entry called myentry here, which represents the current filename in the directory sequence. A default constructed object of type directory_entry has an empty mydir pathname and represents the end-of-sequence iterator.  
  
 For example, given the directory abc with entries def and ghi, the code:  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 will call visit with the arguments path("abc/def") and path("abc/ghi").  
  
 For more information and code examples, see [File System Navigation](../vs140/file-system-navigation.md).  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## directory_iterator::directory_iterator  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first constructor produces an end-of-sequence iterator. The second and third constructors store pval in mydir, then attempt to open and read mydir as a directory. If successful, they store the first filename in the directory in myentry; otherwise they produce an end-of-sequence iterator.  
  
 The defaulted construtors behave as expected.  
  
## directory_iterator::increment  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The function attempts to advance to the next filename in the directory. If successful, it stores that filename in myentry; otherwise it produces an end-of-sequence iterator.  
  
## directory_iterator::operator!=  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The member operator returns !(*this == right).  
  
## directory_iterator::operator=  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The defaulted member assignment operators behave as expected.  
  
## directory_iterator::operator==  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The member operator returns true only if both *this and right are end-of-sequence iterators or both are not end-of-sequence-iterators.  
  
## directory_iterator::operator*  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The member operator returns myentry.  
  
## directory_iterator::operator->  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The member function returns &**this.  
  
## directory_iterator::operator++  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The first member function calls increment(), then returns *this. The second member function makes a copy of the object, calls increment(), then returns the copy.  
  
## Requirements  
 **Header:** \<experimental/filesystem>  
  
 **Namespace:** std::experimental::filesystem::v1  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [\<filesystem>](../vs140/-filesystem-.md)   
 [File System Navigation](../vs140/file-system-navigation.md)