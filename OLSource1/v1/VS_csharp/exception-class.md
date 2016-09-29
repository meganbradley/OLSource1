---
title: "exception Class"
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
  - "std.exception"
  - "exception"
  - "std::exception"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exception class"
ms.assetid: 4f181f67-5888-4b50-89a6-745091ffb2fe
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# exception Class
The class serves as the base class for all exceptions thrown by certain expressions and by the Standard C++ Library.  
  
## Syntax  
  
```  
class exception {  
public:  
    exception();  
    exception(const char * const &message);  
    exception(const char * const &message, int);  
    exception(const exception &right);  
    exception& operator=(const exception &right);  
    virtual ~exception();  
    virtual const char *what() const;  
};  
```  
  
## Remarks  
 Specifically, this base class is the root of the standard exception classes defined in [<stdexcept\>](../VS_csharp/-stdexcept-.md). The C string value returned by `what` is left unspecified by the default constructor, but may be defined by the constructors for certain derived classes as an implementation-defined C string. None of the member functions throw any exceptions.  
  
 The `int` parameter allows you to specify that no memory should be allocated. The value of the `int` is ignored.  
  
> [!NOTE]
>  The constructors `exception(const char * const &message)` and `exception(const char * const &message, int)` are Microsoft extensions to the Standard C++ Library.  
  
## Example  
 For examples of the use of the standard exception classes that inherit from the `exception` class, see any of the classes defined in [<stdexcept\>](../VS_csharp/-stdexcept-.md).  
  
## Requirements  
 **Header:** <exception\>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../VS_csharp/thread-safety-in-the-c---standard-library.md)