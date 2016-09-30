---
title: "marshal_context::marshal_as"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "marshal_context::marshal_as"
  - "marshal_context.marshal_as"
  - "msclr.interop.marshal_context.marshal_as"
  - "msclr::interop::marshal_context::marshal_as"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "marshal_context class [C++], operations"
ms.assetid: 24a1afee-51c0-497c-948c-f77fe43635c8
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# marshal_context::marshal_as
Performs the marshaling on a specific data object to convert it between a managed and a native data type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The value that you want to marshal to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> variable.  
  
## Return Value  
 A variable of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> that is the converted value of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 This function performs the marshaling on a specific data object. Use this function only with the conversions indicated by the table in [Marshaling Overview in C++](../vs140/overview-of-marshaling-in-c--.md).  
  
 If you try to marshal a pair of data types that are not supported, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> will generate an error [C4996](../vs140/compiler-warning--level-3--c4996.md) at compile time. Read the message supplied with this error for more information. The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> error can be generated for more than just deprecated functions. Two conditions that will generate this error are trying to marshal a pair of data types that are not supported and trying to use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> for a conversion that requires a context.  
  
 The marshaling library consists of several header files. Any conversion requires only one file, but you can include additional files if you need to for other conversions. The table in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> indicates which marshaling file should be included for each conversion.  
  
## Example  
 This example creates a context for marshaling from a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> variable type. The converted data will not be valid after the line that deletes the context.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header file:** \<msclr\marshal.h>, \<msclr\marshal_windows.h>, \<msclr\marshal_cppstd.h>, or \<msclr\marshal_atl.h>  
  
 **Namespace:** msclr::interop  
  
## See Also  
 [Marshaling Overview in C++](../vs140/overview-of-marshaling-in-c--.md)   
 [marshal_as](../vs140/marshal_as.md)   
 [marshal_context Class](../vs140/marshal_context-class.md)