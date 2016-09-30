---
title: "Initializing Strings"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "character arrays, initializing"
  - "strings [C++], initializing"
  - "initializing arrays, strings"
ms.assetid: 0ab8079d-d0d3-48f9-afd1-36a7bb439b29
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Initializing Strings
You can initialize an array of characters (or wide characters) with a string literal (or wide string literal). For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 initializes <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> as a four-element array of characters. The fourth element is the null character, which terminates all string literals.  
  
 An identifier list can only be as long as the number of identifiers to be initialized. If you specify an array size that is shorter than the string, the extra characters are ignored. For example, the following declaration initializes <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> as a three-element character array:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Only the first three characters of the initializer are assigned to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The character <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and the string-terminating null character are discarded. Note that this creates an unterminated string (that is, one without a 0 value to mark its end) and generates a diagnostic message indicating this condition.  
  
 The declaration  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 is identical to  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If the string is shorter than the specified array size, the remaining elements of the array are initialized to 0.  
  
 **Microsoft Specific**  
  
 In Microsoft C, string literals can be up to 2048 bytes in length.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Initialization](../vs140/initialization.md)