---
title: "quoted"
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
  - "iomanip/std::quoted"
dev_langs: 
  - "C++"
ms.assetid: 4aa0a287-7dcd-4721-bf95-c84ac2249d05
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# quoted
**(New in C++14)** An iostream manipulator that enables convenient round-tripping of strings into and out of streams using the >> and << operators.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A std::string, char*, string literal or raw string literal, or a wide version of any of these (e.g. std::wstring, wchar_t\*).  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A user-specified character, or wide character, to use as the delimiter for the beginning and end of the string.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A user-specified character, or wide character, to use as the escape character for escape sequences within the string.  
  
## Property Value/Return Value  
 Produces an object that manipulates the stream.  
  
## Exceptions  
 [ios_base::failure](../vs140/ios_base--failure.md)  
  
## Remarks  
 See [Using Insertion Operators and Controlling Format](../vs140/using-insertion-operators-and-controlling-format.md).  
  
## Example  
 This example shows how to use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> with the default delimiter and escape character using narrow strings. Wide strings are equally supported.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following example shows how to provide custom a delimiter and/or escape character:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<iomanip>  
  
 **Namespace:** std  
  
## See Also  
 [\<iomanip>](../vs140/-iomanip-.md)   
 [Using Insertion Operators and Controlling Format](../vs140/using-insertion-operators-and-controlling-format.md)