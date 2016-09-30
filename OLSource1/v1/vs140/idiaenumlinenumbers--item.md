---
title: "IDiaEnumLineNumbers::Item"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaEnumLineNumbers::Item method"
ms.assetid: 08efbeaf-22f7-49e9-96a8-bb906dfe4fd8
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumLineNumbers::Item
Retrieves a line number by means of an index.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 index  
 [in] Index of the [IDiaLineNumber](../vs140/idialinenumber.md) object to be retrieved. The index is in the range 0 to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>-1, where <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is returned by the [IDiaEnumLineNumbers::get_Count](../vs140/idiaenumlinenumbers--get_count.md) method.  
  
 lineNumber  
 [out] Returns an [IDiaLineNumber](../vs140/idialinenumber.md) object representing the desired line number.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md)   
 [IDiaLineNumber](../vs140/idialinenumber.md)