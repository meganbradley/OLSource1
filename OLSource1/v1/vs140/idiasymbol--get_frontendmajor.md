---
title: "IDiaSymbol::get_frontEndMajor"
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
  - "IDiaSymbol::get_frontEndMajor method"
ms.assetid: f8a067c5-3306-4fc5-bc20-8910a47ed504
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSymbol::get_frontEndMajor
Retrieves the front end major version number.  
  
## Syntax  
  
```cpp#  
HRESULT get_frontEndMajor (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the front end major version number. See Remarks.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns `S_FALSE` or an error code.  
  
> [!NOTE]
>  A return value of `S_FALSE` means that the property is not available for the symbol.  
  
## Remarks  
 A compiler is typically composed of two primary elements: the front end (the parser), which handles parsing the source code into an intermediate form, and a back end (code generator), which converts the intermediate form into assembly. It is not uncommon for the front end to have a different version than the back end.  
  
 A front end or back end version number is composed of three parts: <major\>.<minor\>.<build\>, where <major\> is the major version number, <minor\> is the minor version number, and <build\> is the build number. For example, 13.10.3077.  
  
## Requirements  
  
|Requirement|Description|  
|-----------------|-----------------|  
|Header:|dia2.h|  
|Version:|DIA SDK v7.0|  
  
## See Also  
 [IDiaSymbol](../vs140/idiasymbol.md)