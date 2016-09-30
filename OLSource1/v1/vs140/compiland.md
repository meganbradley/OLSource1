---
title: "Compiland"
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
  - "compiland symbol"
  - "compilands, compiland symbol"
ms.assetid: c798eb2b-664a-41ec-ae90-5e9d292507ca
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Compiland
There is one <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> symbol for each Compiland linked to the .exe file. Compiland information is split between symbols with a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> tag, which can be retrieved without loading additional compiland symbols, and symbols with a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> tag, which may require loading additional symbols.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[IDiaSymbol::get_editAndContinueEnabled](../vs140/idiasymbol--get_editandcontinueenabled.md)|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if Edit and Continue was enabled at compilation.|  
|[IDiaSymbol::get_lexicalParent](../vs140/idiasymbol--get_lexicalparent.md)|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Symbol for the .exe file.|  
|[lexicalParentId](../vs140/idiasymbol--get_lexicalparentid.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|ID of the lexical parent symbol.|  
|[IDiaSymbol::get_libraryName](../vs140/idiasymbol--get_libraryname.md)|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Name of the library or object file where object was loaded from.|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|File name of the compiland's object file.|  
|[IDiaSymbol::get_sourceFileName](../vs140/idiasymbol--get_sourcefilename.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Name of the source file.|  
|[IDiaSymbol::get_symIndexId Method](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
  
## See Also  
 [CompilandDetails](../vs140/compilanddetails.md)   
 [CompilandEnv](../vs140/compilandenv.md)   
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)