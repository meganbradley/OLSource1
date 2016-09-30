---
title: "IDiaLineNumber"
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
  - "IDiaLineNumber interface"
ms.assetid: 1071f7d0-1f8c-4384-933f-c49c7eb930bd
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaLineNumber
Accesses information that describes the process of mapping from a block of bytes of image text to a source file line number.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Methods in Vtable Order  
 The following table shows the methods of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaLineNumber::get_compiland](../vs140/idialinenumber--get_compiland.md)|Retrieves a reference to the symbol for the compiland that contributed the bytes of image text.|  
|[IDiaLineNumber::get_sourceFile](../vs140/idialinenumber--get_sourcefile.md)|Retrieves a reference to the source file object.|  
|[IDiaLineNumber::get_lineNumber](../vs140/idialinenumber--get_linenumber.md)|Retrieves the line number in the source file.|  
|[IDiaLineNumber::get_lineNumberEnd](../vs140/idialinenumber--get_linenumberend.md)|Retrieves the one-based source line number where the statement or expression ends.|  
|[IDiaLineNumber::get_columnNumber](../vs140/idialinenumber--get_columnnumber.md)|Retrieves the column number where the expression or statement begins.|  
|[IDiaLineNumber::get_columnNumberEnd](../vs140/idialinenumber--get_columnnumberend.md)|Retrieves the column number where the expression or statement ends.|  
|[IDiaLineNumber::get_addressSection](../vs140/idialinenumber--get_addresssection.md)|Retrieves the section part of the memory address where a block begins.|  
|[IDiaLineNumber::get_addressOffset](../vs140/idialinenumber--get_addressoffset.md)|Retrieves the offset part of the memory address where a block begins.|  
|[IDiaLineNumber::get_relativeVirtualAddress](../vs140/idialinenumber--get_relativevirtualaddress.md)|Retrieves the image relative virtual address (RVA) of a block.|  
|[IDiaLineNumber::get_virtualAddress](../vs140/idialinenumber--get_virtualaddress.md)|Retrieves the virtual address (VA) of a block.|  
|[IDiaLineNumber::get_length](../vs140/idialinenumber--get_length.md)|Retrieves the number of bytes in a block.|  
|[IDiaLineNumber::get_sourceFileId](../vs140/idialinenumber--get_sourcefileid.md)|Retrieves a unique source file identifier for the source file that contributed this line.|  
|[IDiaLineNumber::get_statement](../vs140/idialinenumber--get_statement.md)|Retrieves a flag indicating that this line information describes the beginning of a statement in the program source.|  
|[IDiaLineNumber::get_compilandId](../vs140/idialinenumber--get_compilandid.md)|Retrieves the unique identifier for the compiland that contributed this line.|  
  
## Remarks  
  
## Notes for Callers  
 Obtain this interface by calling the [IDiaEnumLineNumbers::Item](../vs140/idiaenumlinenumbers--item.md) or [IDiaEnumLineNumbers::Next](../vs140/idiaenumlinenumbers--next.md) methods.  
  
## Example  
 The following function displays line numbers used in a function (represented by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../vs140/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumLineNumbers](../vs140/idiaenumlinenumbers.md)   
 [IDiaEnumLineNumbers::Item](../vs140/idiaenumlinenumbers--item.md)   
 [IDiaEnumLineNumbers::Next](../vs140/idiaenumlinenumbers--next.md)