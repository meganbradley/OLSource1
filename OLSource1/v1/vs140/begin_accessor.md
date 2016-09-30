---
title: "BEGIN_ACCESSOR"
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
  - "BEGIN_ACCESSOR"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "BEGIN_ACCESSOR macro, syntax"
  - "BEGIN_ACCESSOR macro"
ms.assetid: 59d0ff3e-7cfd-4ce8-9a1c-d664c0892a52
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# BEGIN_ACCESSOR
Marks the beginning of an accessor entry.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *num*  
 [in] The zero-offset number for the accessor in this accessor map.  
  
 *bAuto*  
 [in] Specifies if this accessor is an auto accessor or a manual accessor. If **true**, the accessor is auto; if **false**, the accessor is manual. An auto accessor means data is fetched for you on move operations.  
  
## Remarks  
 In the case of multiple accessors on a rowset, you need to specify <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> and use the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> macro for each individual accessor. The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> macro is completed with the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro. The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> macro is completed with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> macro.  
  
## Example  
 See [BEGIN_ACCESSOR_MAP](../vs140/begin_accessor_map.md).  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [Macros and Global Functions for OLE DB Consumer Templates](../vs140/macros-and-global-functions-for-ole-db-consumer-templates.md)   
 [BEGIN_ACCESSOR_MAP](../vs140/begin_accessor_map.md)   
 [END_ACCESSOR](../vs140/end_accessor.md)   
 [END_ACCESSOR_MAP](../vs140/end_accessor_map.md)