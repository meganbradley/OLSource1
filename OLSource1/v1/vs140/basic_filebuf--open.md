---
title: "basic_filebuf::open"
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
  - "std.basic_filebuf.open"
  - "basic_filebuf::open"
  - "std::basic_filebuf::open"
  - "Open"
  - "open"
  - "fstream/std::basic_filebuf::open"
  - "basic_filebuf.open"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "open method"
ms.assetid: ee330f2c-82db-439c-885f-1340db4d0222
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_filebuf::open
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
  
## Return Value  
 If the file pointer is a null pointer, the function returns a null pointer. Otherwise, it returns **this**.  
  
## Remarks  
 The member function opens the file with filename *filename*, by calling [fopen](../vs140/fopen--_wfopen.md)(*filename*, **strmode**). **strmode** is determined from **mode &**~([ate](../vs140/ios_base--openmode.md) & &#124; [binary](../vs140/ios_base--openmode.md)):  
  
-   **ios_base::in** becomes **"r"** (open existing file for reading).  
  
-   [ios_base::out](../vs140/ios_base--fmtflags.md) or **ios_base::out &#124; ios_base::trunc** becomes **"w"** (truncate existing file or create for writing).  
  
-   **ios_base::out &#124; app** becomes **"a"** (open existing file for appending all writes).  
  
-   **ios_base::in &#124; ios_base::out** becomes **"r+"** (open existing file for reading and writing).  
  
-   **ios_base::in &#124; ios_base::out &#124; ios_base::trunc** becomes **"w+"** (truncate existing file or create for reading and writing).  
  
-   **ios_base::in &#124; ios_base::out &#124; ios_base::app** becomes **"a+"** (open existing file for reading and for appending all writes).  
  
 If **mode & ios_base::binary** is nonzero, the function appends **b** to **strmode** to open a binary stream instead of a text stream. It then stores the value returned by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> in the file pointer **fp**. If **mode & ios_base::ate** is nonzero and the file pointer is not a null pointer, the function calls <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>(**fp**, 0, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>) to position the stream at end of file. If that positioning operation fails, the function calls [close](../vs140/basic_filebuf--close.md)(**fp**) and stores a null pointer in the file pointer.  
  
 If the file pointer is not a null pointer, the function determines the file conversion facet: <CodeContentPlaceHolder>8\</CodeContentPlaceHolder><<CodeContentPlaceHolder>9\</CodeContentPlaceHolder><**Elem**, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, **traits_type::**[state_type](../vs140/char_traits--state_type.md)> >([getloc](../vs140/basic_streambuf--getloc.md)), for use by [underflow](../vs140/basic_filebuf--underflow.md) and [overflow](../vs140/basic_filebuf--overflow.md).  
  
 If the file pointer is a null pointer, the function returns a null pointer. Otherwise, it returns **this**.  
  
## Example  
 See [basic_filebuf::close](../vs140/basic_filebuf--close.md) for an example that uses **open**.  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_filebuf Class](../vs140/basic_filebuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)