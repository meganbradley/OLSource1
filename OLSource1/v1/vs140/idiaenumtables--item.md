---
title: "IDiaEnumTables::Item"
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
  - "IDiaEnumTables::Item method"
ms.assetid: d65ab262-10c6-48ce-95a3-b5e4cb2c85af
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaEnumTables::Item
Retrieves a table by means of an index or name.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] Index or name of the [IDiaTable](../vs140/idiatable.md) to be retrieved. If an integer variant is used, it must be in the range 0 to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>-1, where <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is as returned by the [IDiaEnumTables::get_Count](../vs140/idiaenumtables--get_count.md) method.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] Returns an [IDiaTable](../vs140/idiatable.md) object representing the desired table.  
  
## Return Value  
 If successful, returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>; otherwise, returns an error code.  
  
## Remarks  
 If a string variant is specified, then the string names a particular table. The name should be one of the table names as defined in [Constants (Debug Interface Access SDK)](../vs140/constants--debug-interface-access-sdk-.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [IDiaEnumTables](../vs140/idiaenumtables.md)   
 [IDiaTable](../vs140/idiatable.md)   
 [IDiaEnumTables::get_Count](../vs140/idiaenumtables--get_count.md)   
 [Constants (Debug Interface Access SDK)](../vs140/constants--debug-interface-access-sdk-.md)