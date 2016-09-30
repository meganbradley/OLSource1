---
title: "basic_fstream::open"
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
  - "fstream/std::basic_fstream::open"
  - "std.basic_fstream.open"
  - "basic_fstream.open"
  - "basic_fstream::open"
  - "Open"
  - "open"
  - "std::basic_fstream::open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "open method"
ms.assetid: 464af71a-0a9b-4ae7-aa9e-4db57b7e1a04
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_fstream::open
Opens a file.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The name of the file to open.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The default file opening protection, equivalent to the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
## Remarks  
 The member function calls [rdbuf](../vs140/basic_fstream--rdbuf.md) **->** [open](../vs140/basic_filebuf--open.md)(_*Filename*, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>). If that function returns a null pointer, the function calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**).  
  
## Example  
 See [basic_filebuf::open](../vs140/basic_filebuf--open.md) for an example of how to use **open**.  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_fstream Class](../vs140/basic_fstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)