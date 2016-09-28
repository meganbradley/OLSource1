---
title: "NameSearchOptions"
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
  - "NameSearchOptions enumeration"
ms.assetid: 67dfbede-2678-47df-b664-5c49841d0b9b
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NameSearchOptions
Specifies the search options for symbol and file names.  
  
## Syntax  
  
```cpp#  
enum NameSearchOptions {   
   nsNone,  
   nsfCaseSensitive     = 0x1,  
   nsfCaseInsensitive   = 0x2,  
   nsfFNameExt          = 0x4,  
   nsfRegularExpression = 0x8,  
   nsfUndecoratedName   = 0x10,  
  
// For backward compatibility:  
   nsCaseSensitive           = nsfCaseSensitive,  
   nsCaseInsensitive         = nsfCaseInsensitive,  
   nsFNameExt                = nsfCaseInsensitive | nsfFNameExt,  
   nsRegularExpression       = nsfRegularExpression | nsfCaseSensitive,  
   nsCaseInRegularExpression = nsfRegularExpression | nsfCaseInsensitive  
};  
```  
  
## Elements  
 `nsNone`  
 No options are specified.  
  
 `nsfCaseSensitive`  
 Applies a case-sensitive name match.  
  
 `nsfCaseInsensitive`  
 Applies a case-insensitive name match.  
  
 `nsfFNameExt`  
 Treats names as paths and applies a filename.ext name match.  
  
 `nsfRegularExpression`  
 Applies a case-sensitive name match using asterisks (*) and question marks (?) as wildcards.  
  
 `nsfUndecoratedName`  
 Applies only to symbols that have both undecorated and decorated names.  
  
## Remarks  
 The values from this enumeration are passed to the following methods:  
  
-   [IDiaSession::findChildren](../vs140/idiasession--findchildren.md)  
  
-   [IDiaSession::findFile](../vs140/idiasession--findfile.md)  
  
-   [IDiaSymbol::findChildren](../vs140/idiasymbol--findchildren.md)  
  
## Requirements  
 Header: dia2.h  
  
## See Also  
 [Enumerations and Structures](../vs140/enumerations-and-structures.md)   
 [IDiaSession::findChildren](../vs140/idiasession--findchildren.md)   
 [IDiaSession::findFile](../vs140/idiasession--findfile.md)   
 [IDiaSymbol::findChildren](../vs140/idiasymbol--findchildren.md)