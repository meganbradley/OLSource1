---
title: "file_status Class"
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
  - "filesystem/std::tr2::sys::file_status"
  - "filesystem/std::tr2::sys::file_status::perms"
  - "filesystem/std::tr2::sys::file_status::type"
dev_langs: 
  - "C++"
ms.assetid: 9781840e-ad22-44dd-ad79-0fabaa94bac4
caps.latest.revision: 18
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# file_status Class
Wraps a [file_type](../vs140/file_type-enumeration.md).  
  
## Syntax  
  
```  
class file_status;  
```  
  
## file_status::file_status  
  
```  
explicit file_status(file_type ftype = file_type::none,    perms mask = perms::unknown) noexcept;file_status(const file_status&) noexcept = default;file_status(file_status&&) noexcept = default;  
```  
  
## file_status::operator=  
  
```  
file_status& operator=(const file_status&) noexcept = default;  
file_status& operator=(file_status&&) nexcept = default;  
```  
  
 The defaulted member assignment operators behave as expected.  
  
## type  
  
```  
file_type type() const noexcept  
void type(file_type _Ftype) noexcept  
```  
  
 Gets or sets the file_type.  
  
## permissions  
  
```  
perms permissions() const noexcept  
void permissions(perms_Prms) noexcept   
```  
  
 Gets or sets the file permissions.  
  
 Use the setter to make a file readonly or remove the readonly attribute.  
  
## Requirements  
 **Header:** filesystem  
  
 **Namespace:** std::tr2::sys  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [path Class (C++ Standard Template Library)](../vs140/path-class--c---standard-template-library-.md)   
 [\<filesystem>](../vs140/-filesystem-.md)