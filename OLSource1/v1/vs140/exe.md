---
title: "Exe"
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
  - ".dll files"
  - "Exe symbol"
  - ".exe files"
  - "executable files, Exe symbol"
ms.assetid: a781d2cf-55fe-4373-9cf1-b732864244e0
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exe
Exe is the only symbol without either a lexical or class parent, as it represents the global scope of the .exe or .dll file. There is only one symbol with the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> tag per file. The [IDiaSession::get_globalScope](../vs140/idiasession--get_globalscope.md) method returns the symbol.  
  
## Properties  
 The following table shows the properties that are valid for this symbol type.  
  
|Property|Data type|Description|  
|--------------|---------------|-----------------|  
|[age](../vs140/idiasymbol--get_age.md)|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Age of this executable.|  
|[guid](../vs140/idiasymbol--get_guid.md)|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of this executable.|  
|[isCTypes](../vs140/idiasymbol--get_isctypes.md)|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the symbol file associated with this executable contains C types (only in DIA SDK v8.0 or later).|  
|[isStripped](../vs140/idiasymbol--get_isstripped.md)|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if private symbols have been stripped from the symbol file associated with this executable (only in DIA SDK v8.0 or later).|  
|[machineType](../vs140/idiasymbol--get_machinetype.md)|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Value indicating target CPU (one of the [CV_CPU_TYPE_e Enumeration](../vs140/cv_cpu_type_e.md) values).|  
|[IDiaSymbol::get_name](../vs140/idiasymbol--get_name.md)|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Name of the .exe file.|  
|[signature](../vs140/idiasymbol--get_signature.md)|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Signature of the executable.|  
|[IDiaSymbol::get_symbolsFileName](../vs140/idiasymbol--get_symbolsfilename.md)|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Full path for the .exe file's .pdb or .dbg file.|  
|[symIndexId](../vs140/idiasymbol--get_symindexid.md)|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Index ID of symbol.|  
|[symTag](../vs140/idiasymbol--get_symtag.md)|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Returns <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> (one of the [SymTagEnum Enumeration](../vs140/symtagenum.md) values).|  
  
## See Also  
 [IDiaSession::get_globalScope](../vs140/idiasession--get_globalscope.md)   
 [Lexical Hierarchy of Symbol Types](../vs140/lexical-hierarchy-of-symbol-types.md)