---
title: "IDiaSession::findLinesByAddr"
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
  - "IDiaSession::findLinesByAddr method"
ms.assetid: 640403c0-14cf-403c-ad19-38b3bdc28ca8
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findLinesByAddr
Retrieves the lines in a specified compiland that contain a specified address.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Specifies the section component of the specific address.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] Specifies the offset component of the specific address.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] Specifies the number of bytes of address range to cover with this query.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md) object that contains a list of all the line numbers that cover the specified address range.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 This example shows a function that obtains all line numbers contained in a function using the function's address and length.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md)   
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSession::findLinesByVA](../vs140/idiasession--findlinesbyva.md)