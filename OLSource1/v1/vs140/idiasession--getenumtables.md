---
title: "IDiaSession::getEnumTables"
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
  - "IDiaSession::getEnumTables method"
ms.assetid: 66e0fba2-ca63-4e24-a46a-c99c7fb61dd1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSession::getEnumTables
Retrieves an enumerator for all tables contained in the symbol store.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaEnumTables](../vs140/idiaenumtables.md) object. Use this interface to enumerate the tables in the symbol store.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Example  
 This example presents a general function that uses the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method to obtain a specific enumerator object. If the enumerator is found, the function returns a pointer that can be cast to the desired interface; otherwise, the function returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaEnumTables](../vs140/idiaenumtables.md)   
 [IDiaSession](../vs140/idiasession.md)