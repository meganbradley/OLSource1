---
title: "Constants (Debug Interface Access SDK)"
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
  - "constants, DIA SDK"
  - "DIA SDK, constants"
ms.assetid: aca4ec77-bc08-4cdd-a6ce-8d4a28ea5ea3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Constants (Debug Interface Access SDK)
These string constants can be used to identify various sections of a program debug database (PDB) file through the DIA SDK.  
  
## Constants  
 The following are declared as C/C++ macros.  
  
|Macro|Value|  
|-----------|-----------|  
|`DiaTable_Symbols`|L"Symbols"|  
|`DiaTable_Sections`|L"Sections"|  
|`DiaTable_SrcFiles`|L"SourceFiles"|  
|`DiaTable_LineNums`|L"LineNumbers"|  
|`DiaTable_SegMap`|L"SegmentMap"|  
|`DiaTable_Dbg`|L"Dbg"|  
|`DiaTable_InjSrc`|L"InjectedSource"|  
|`DiaTable_FrameData`|L"FrameData"|  
  
## Example  
 Here is an example using one of these symbols:  
  
```cpp#  
HRESULT GetSymbolTable(IDiaEnumTables *pEnumTables, IDiaTable **pTable)  
{  
    HRESULT hr;  
    VARIANT var;  
    var.vt      = VT_BSTR;  
    var.bstrVal = SysAllocString( DiaTable_Symbols );  
    hr = pEnumTables->Item( var, pTable );  
    return(hr);  
}  
```  
  
## Requirements  
 Header: dia2.h  
  
## See Also  
 [API Reference (Debug Interface Access SDK)](../VS_csharp/debug-interface-access-sdk-reference.md)   
 [Enumerations and Structures](../VS_csharp/enumerations-and-structures.md)   
 [Interfaces (Debug Interface Access SDK)](../VS_csharp/interfaces--debug-interface-access-sdk-.md)   
 [IDiaEnumTables::Item Method](../VS_csharp/idiaenumtables--item.md)