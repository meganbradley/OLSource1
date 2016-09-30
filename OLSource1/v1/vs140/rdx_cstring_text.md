---
title: "RDX_CSTRING_TEXT"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::RDX_CSTRING_TEXT"
  - "RDX_CSTRING_TEXT"
  - "ATL.RDX_CSTRING_TEXT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RDX_CSTRING_TEXT macro"
ms.assetid: 897ac6dc-2700-4818-8327-3a779aa7bc6c
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RDX_CSTRING_TEXT
Associates the specified registry entry with a specified member variable of type CString.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The registry key root.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The registry subkey.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The registry key.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The member variable to associate with the specified registry entry.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The size, in bytes, of the member variable.  
  
## Remarks  
 This macro is used in conjunction with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> macros to associate a member variable with a given registry entry. The global function [RegistryDataExchange](../vs140/registrydataexchange.md), or the member function of the same name created by the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> macros, should be used to perform exchange of data between the system registry and the member variables in the RDX map.  
  
## Requirements  
 **Header:** atlplus.h  
  
## See Also  
 [Registry Data Exchange Macros](../vs140/registry-data-exchange-macros.md)