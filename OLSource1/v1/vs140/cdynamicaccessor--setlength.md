---
title: "CDynamicAccessor::SetLength"
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
  - "ATL::CDynamicAccessor::SetLength"
  - "CDynamicAccessor.SetLength"
  - "CDynamicAccessor::SetLength"
  - "ATL.CDynamicAccessor.SetLength"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetLength method"
ms.assetid: 8109ae73-04ec-4a47-be97-ba1e60080384
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicAccessor::SetLength
Sets the length of the specified column.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The column number. Column numbers start with 1. A value of 0 refers to the bookmark column, if any.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The length of the column in bytes.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] A pointer to a character string containing the column name.  
  
## Return Value  
 Returns **true** if the specified column length is set successfully. Otherwise, this function returns **false**.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)   
 [CDynamicAccessor::GetLength](../vs140/cdynamicaccessor--getlength.md)