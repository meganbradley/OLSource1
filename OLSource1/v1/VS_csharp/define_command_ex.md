---
title: "DEFINE_COMMAND_EX"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "DEFINE_COMMAND_EX"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DEFINE_COMMAND_EX macro"
ms.assetid: d3e2ef20-1455-46d2-8499-8ab84bbb90a4
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DEFINE_COMMAND_EX
Specifies the command that will be used to create the rowset when using the [CCommand](../VS_csharp/ccommand-class.md) class. Supports Unicode and ANSI applications.  
  
## Syntax  
  
```  
  
DEFINE_COMMAND_EX(  
x  
,   
wszCommand  
 )  
  
```  
  
#### Parameters  
 *x*  
 [in] The name of the user record (command) class.  
  
 `wszCommand`  
 [in] The command string that will be used to create the rowset when using [CCommand](../VS_csharp/ccommand-class.md).  
  
## Remarks  
 The command string that you specify will be used as the default if you do not specify command text in the [CCommand::Open](../VS_csharp/ccommand--open.md) method.  
  
 This macro accepts Unicode strings, regardless of the application type. This macro is preferred over [DEFINE_COMMAND](../VS_csharp/define_command.md) because it supports Unicode as well as ANSI applications.  
  
## Example  
 See [BOOKMARK_ENTRY](../VS_csharp/bookmark_entry.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../VS_csharp/macros-and-global-functions-for-ole-db-consumer-templates.md)