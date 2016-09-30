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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Specifically, this base class is the root of the standard exception classes defined in [\<stdexcept>](../vs140/-stdexcept-.md). The C string value returned by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is left unspecified by the default constructor, but may be defined by the constructors for certain derived classes as an implementation-defined C string. None of the member functions throw any exceptions.  
  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter allows you to specify that no memory should be allocated. The value of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is ignored.  
  
> [!NOTE]
>  The constructors <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> are Microsoft extensions to the Standard C++ Library.  
  
## Example  
 For examples of the use of the standard exception classes that inherit from the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class, see any of the classes defined in [\<stdexcept>](../vs140/-stdexcept-.md).  
  
## Requirements  
 **Header:** \<exception>  
  
 **Namespace:** std  
  
## See Also  
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)