---
title: "IDiaSession::findLinesByLinenum"
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
  - "IDiaSession::findLinesByLinenum method"
ms.assetid: 76d5622d-9a91-4c2a-a98f-263af5d1daef
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::findLinesByLinenum
Determines the line numbers of the compiland that the specified line number in a source file lies within or near.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] An [IDiaSymbol](../vs140/idiasymbol.md) object that represents the compiland in which to search for the line numbers. This parameter cannot be <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] An [IDiaSourceFile](../vs140/idiasourcefile.md) object that represents the source file to search in. This parameter cannot be <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 [in] Specifies a one-based line number.  
  
> [!NOTE]
>  You cannot use zero to specify all lines (use the [IDiaSession::findLines](../vs140/idiasession--findlines.md) method to find all lines).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 [in] Specifies the column number. Use zero to specify all columns. A column is a byte offset into a line.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md) objta that contains a list of the line numbers retrieved.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 The following example shows how to open a source file, enumerate the compilands contributed by this file, and locate the line numbers in the source file where each compiland starts.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md)   
 [IDiaSession](../vs140/idiasession.md)   
 [IDiaSession::findLinesByAddr](../vs140/idiasession--findlinesbyaddr.md)   
 [IDiaSourceFile](../vs140/idiasourcefile.md)   
 [IDiaSymbol](../vs140/idiasymbol.md)