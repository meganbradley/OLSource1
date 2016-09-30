---
title: "SymTagEnum"
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
  - "SymTagEnum enumeration"
ms.assetid: 528a50cf-e13d-46ec-a98c-323d5d047de9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# SymTagEnum
Specifies the type of symbol.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates that the symbol has no type.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Indicates that the symbol is an .exe file. There is only one <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> symbol per symbol store. It serves as the global scope and does not have a lexical parent.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Indicates the compiland symbol for each compiland component of the symbol store. For native applications, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> symbols correspond to the object files linked into the image. For some kinds of Microsoft Intermediate Language (MSIL) images, there is one compiland per class.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Indicates that the symbol contains extended attributes of the compiland. Retrieving these properties may require loading compiland symbols.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Indicates that the symbol is an environment string defined for the compiland.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 Indicates that the symbol is a function.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 Indicates that the symbol is a nested block.  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 Indicates that the symbol is data.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 Indicates that the symbol is for a code annotation. Children of this symbol are constant data strings (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>). Most clients ignore this symbol.  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
 Indicates that the symbol is a label.  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
 Indicates that the symbol is a public symbol. For native applications, this symbol is the COFF external symbol encountered while linking the image.  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
 Indicates that the symbol is a user-defined type (structure, class, or union).  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
 Indicates that the symbol is an enumeration.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
 Indicates that the symbol is a function signature type.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
 Indicates that the symbol is a pointer type.  
  
 <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
 Indicates that the symbol is an array type.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
 Indicates that the symbol is a base type.  
  
 <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
 Indicates that the symbol is a <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, that is, an alias for another type.  
  
 <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
 Indicates that the symbol is a base class of a user-defined type.  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Indicates that the symbol is a friend of a user-defined type.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Indicates that the symbol is a function argument.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Indicates that the symbol is the end location of the function's prologue code.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 Indicates that the symbol is the beginning location of the function's epilogue code.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 Indicates that the symbol is a namespace name, active in the current scope.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>  
 Indicates that the symbol is a virtual table description.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>  
 Indicates that the symbol is a virtual table pointer.  
  
 <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
 Indicates that the symbol is a custom symbol and is not interpreted by DIA.  
  
 <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>  
 Indicates that the symbol is a thunk used for sharing data between 16 and 32 bit code.  
  
 <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>  
 Indicates that the symbol is a custom compiler symbol.  
  
 <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
 Indicates that the symbol is in metadata.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 Indicates that the symbol is a FORTRAN multi-dimensional array.  
  
 <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>  
 Indicates that the symbol represents the call site.  
  
 <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>  
 Indicates that the symbol represents the inline site.  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>  
 Indicates that the symbol is a base interface.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
 Indicates that the symbol is a vector type.  
  
 <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>  
 Indicates that the symbol is a matrix type.  
  
 <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>  
 Indicates that the symbol is a High Level Shader Language type.  
  
## Remarks  
 All symbols within a debug file have an identifying tag that specifies the symbol's type.  
  
 The values in this enumeration are returned by a call to the [IDiaSymbol::get_symTag](../vs140/idiasymbol--get_symtag.md) method.  
  
 The values in this enumeration are passed to the following methods to limit the scope of the search to a specific symbol type:  
  
-   [IDiaSession::findSymbolByAddr](../vs140/idiasession--findsymbolbyaddr.md)  
  
-   [IDiaSession::findSymbolByRVA](../vs140/idiasession--findsymbolbyrva.md)  
  
-   [IDiaSession::findSymbolByRVAEx](../vs140/idiasession--findsymbolbyrvaex.md)  
  
-   [IDiaSession::findSymbolByToken](../vs140/idiasession--findsymbolbytoken.md)  
  
-   [IDiaSession::findSymbolByVA](../vs140/idiasession--findsymbolbyva.md)  
  
-   [IDiaSession::findSymbolByVAEx](../vs140/idiasession--findsymbolbyvaex.md)  
  
-   [IDiaSession::findChildren](../vs140/idiasession--findchildren.md)  
  
-   [IDiaSymbol::findChildren](../vs140/idiasymbol--findchildren.md)  
  
## Requirements  
 Header: cvconst.h  
  
## See Also  
 [Enumerations and Structures](../vs140/enumerations-and-structures.md)   
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)   
 [IDiaSession::findSymbolByAddr](../vs140/idiasession--findsymbolbyaddr.md)   
 [IDiaSession::findSymbolByRVA](../vs140/idiasession--findsymbolbyrva.md)   
 [IDiaSession::findSymbolByRVAEx](../vs140/idiasession--findsymbolbyrvaex.md)   
 [IDiaSession::findSymbolByToken](../vs140/idiasession--findsymbolbytoken.md)   
 [IDiaSession::findSymbolByVA](../vs140/idiasession--findsymbolbyva.md)   
 [IDiaSession::findSymbolByVAEx](../vs140/idiasession--findsymbolbyvaex.md)   
 [IDiaSession::findChildren](../vs140/idiasession--findchildren.md)   
 [IDiaSymbol::findChildren](../vs140/idiasymbol--findchildren.md)