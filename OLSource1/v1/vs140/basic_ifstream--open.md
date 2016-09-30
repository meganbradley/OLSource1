---
title: "basic_ifstream::open"
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
  - "basic_ifstream::open"
  - "basic_ifstream.open"
  - "fstream/std::basic_ifstream::open"
  - "std::basic_ifstream::open"
  - "Open"
  - "open"
  - "std.basic_ifstream.open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "open method"
ms.assetid: 51ec9a87-ab28-44a1-9854-963d29373634
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_ifstream::open
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
 The member function calls [rdbuf](../vs140/basic_ifstream--rdbuf.md) **->** [open](../vs140/basic_filebuf--open.md)(_*Filename*, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> &#124; **ios_base::in**). If open fails, the function calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**), which may throw an ios_base::failure exception.  
  
## Example  
 See [basic_filebuf::open](../vs140/basic_filebuf--open.md) for an example that uses **open**.  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ifstream Class](../vs140/basic_ifstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)