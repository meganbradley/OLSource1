---
title: "CDynamicAccessor::GetBookmark"
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
  - "CDynamicAccessor.GetBookmark"
  - "GetBookmark"
  - "CDynamicAccessor::GetBookmark"
  - "ATL.CDynamicAccessor.GetBookmark"
  - "ATL::CDynamicAccessor::GetBookmark"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBookmark method"
ms.assetid: 6d0a2970-0c62-4a34-bac7-149d8e990f81
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicAccessor::GetBookmark
Retrieves the bookmark for the current row.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [out] A pointer to the [CBookmark](../vs140/cbookmark-class.md) object.  
  
## Return Value  
 One of the standard <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> values.  
  
## Remarks  
 You need to set **DBPROP_IRowsetLocate** to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to retrieve a bookmark.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)