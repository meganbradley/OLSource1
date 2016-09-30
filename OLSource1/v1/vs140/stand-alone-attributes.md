---
title: "Stand-Alone Attributes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "standalone attributes"
  - "attributes [C++], standalone"
ms.assetid: 0d72e84e-236c-43b3-ac9a-d9b91fcd6794
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Stand-Alone Attributes
A stand-alone attribute does not operate on a C++ keyword but is more like a line of code. Stand-alone attribute statements require a semicolon at the end of the line.  
  
|Attribute|Description|  
|---------------|-----------------|  
|[cpp_quote](../vs140/cpp_quote.md)|Emits the specified string, without the quote characters, into the generated header file.|  
|[custom](../vs140/custom--c---.md)|Lets you define your own attribute.|  
|[db_command](../vs140/db_command.md)|Creates an OLE DB command.|  
|[emitidl](../vs140/emitidl.md)|Determines whether all subsequent IDL attributes will be processed and placed in the generated .idl file.|  
|[idl_module](../vs140/idl_module.md)|Specifies an entry point in a DLL.|  
|[idl_quote](../vs140/idl_quote.md)|Allows you to use IDL constructs that are not supported in the current version of Visual C++ and have them pass through to the generated .idl file.|  
|[import](../vs140/import.md)|Specifies another .idl, .odl, or .h file containing definitions you want to reference from your main .idl file.|  
|[importidl](../vs140/importidl.md)|Inserts the specified .idl file into the generated .idl file|  
|[importlib](../vs140/importlib.md)|Makes types that have already been compiled into another type library available to the type library being created.|  
|[include](../vs140/include--c---.md)|Specifies one or more header files to be included in the generated .idl file.|  
|[includelib](../vs140/includelib--c---.md)|Causes an .idl or .h file to be included in the generated .idl file.|  
|[library_block](../vs140/library_block.md)|Places a construct inside the .idl file's library block.|  
|[module](../vs140/module--c---.md)|Defines the library block in the .idl file.|  
|[no_injected_text](../vs140/no_injected_text.md)|Prevents the compiler from injecting code as a result of attribute use.|  
|[pragma](../vs140/pragma.md)|Emits the specified string, without the quote characters, into the generated .idl file.|  
  
## See Also  
 [Attributes by Usage](../vs140/attributes-by-usage.md)