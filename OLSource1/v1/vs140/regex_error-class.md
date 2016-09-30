---
title: "regex_error Class"
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
  - "std::tr1::regex_error"
  - "regex_error"
  - "std.tr1.regex_error"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "regex_error class [TR1]"
ms.assetid: 3333a1a3-ca6f-4612-84b2-1b4c7e3db5a4
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# regex_error Class
Reports a bad basic_regex object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The class describes an exception object thrown to report an error in the construction or use of a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** \<regex>  
  
 **Namespace:** std  
  
##  \<a name="regex_error__code">\</a>  regex_error::code  
 Returns the error code.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The member function returns the value that was passed to the object's constructor.  
  
### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **regex error: unbalanced parentheses**    
##  \<a name="regex_error__regex_error">\</a>  regex_error::regex_error  
 Constructs the object.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The error code.  
  
### Remarks  
 The constructor constructs an object that holds the value <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
### Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  **regex error: unbalanced parentheses**    
## See Also  
 [\<regex>](../vs140/-regex-.md)   
 [regex_error](../vs140/regex_error-class.md)