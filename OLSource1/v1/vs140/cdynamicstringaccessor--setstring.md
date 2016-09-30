---
title: "CDynamicStringAccessor::SetString"
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
  - "CDynamicStringAccessor::SetString"
  - "CDynamicStringAccessor.SetString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetString method"
ms.assetid: 94846d8b-4c1b-47fe-acdc-1752981cee25
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicStringAccessor::SetString
Sets the specified column data as a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The column number. Column numbers start with 1. The special value of 0 refers to the bookmark column, if any.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A pointer to a character string that contains the column name.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A pointer to the string data to be written to the specified column.  
  
## Return Value  
 A pointer to the string value to which to set the specified column. The value is of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, which will be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> depending on whether <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is defined or not.  
  
## Remarks  
 The second override form takes the column name as an ANSI string and the third override form takes the column name as a Unicode string.  
  
 If <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is defined to have a nonzero value, a runtime assertion failure will be generated if the input <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> string is longer than the maximum allowable length of the referenced data column. Otherwise, the input string will be truncated if it is longer than the maximum allowable length.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicStringAccessor Class](../vs140/cdynamicstringaccessor-class.md)