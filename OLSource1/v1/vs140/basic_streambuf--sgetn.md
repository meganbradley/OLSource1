---
title: "basic_streambuf::sgetn"
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
  - "streambuf/std::basic_streambuf::sgetn"
  - "basic_streambuf.sgetn"
  - "std.basic_streambuf.sgetn"
  - "basic_streambuf::sgetn"
  - "sgetn"
  - "std::basic_streambuf::sgetn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sgetn method"
ms.assetid: 24ea6dd1-eeae-4d85-85c4-7f632a14a101
caps.latest.revision: 29
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_streambuf::sgetn
Extracts up to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> characters from the input buffer and stores them in the provided buffer <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 This method is potentially unsafe, as it relies on the caller to check that the passed values are correct.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The buffer to contain the extracted characters.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The number of elements to read.  
  
## Return Value  
 The number of elements read. See [streamsize](../vs140/streamsize.md) for more information.  
  
## Remarks  
 The member function returns [xsgetn](../vs140/basic_streambuf--xsgetn.md)(<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: basic_streambuf_sgetn.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<streambuf>  
  
 **Namespace:** std  
  
## See Also  
 [basic_streambuf Class](../vs140/basic_streambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)