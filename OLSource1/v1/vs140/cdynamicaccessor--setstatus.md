---
title: "CDynamicAccessor::SetStatus"
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
  - "CDynamicAccessor::SetStatus"
  - "ATL::CDynamicAccessor::SetStatus"
  - "CDynamicAccessor.SetStatus"
  - "ATL.CDynamicAccessor.SetStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetStatus method"
ms.assetid: 6db82694-e87d-4bf8-a7e3-5765cf6abff9
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicAccessor::SetStatus
Sets the status of the specified column.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The column number. Column numbers start with 1. A value of 0 refers to the bookmark column, if any.  
  
 *status*  
 [in] The column status. See [DBSTATUS](https://msdn.microsoft.com/en-us/library/ms722617.aspx) in the *OLE DB Programmer's Reference* for more information.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A pointer to a character string containing the column name.  
  
## Return Value  
 Returns **true** if the specified column status is set successfully. Otherwise, this function returns **false**.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)   
 [CDynamicAccessor::GetStatus](../vs140/cdynamicaccessor--getstatus.md)