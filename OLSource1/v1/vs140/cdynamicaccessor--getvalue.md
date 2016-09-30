---
title: "CDynamicAccessor::GetValue"
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
  - "GetValue"
  - "CDynamicAccessor::GetValue<ctype>"
  - "ATL.CDynamicAccessor.GetValue<ctype>"
  - "CDynamicAccessor.GetValue"
  - "CDynamicAccessor::GetValue"
  - "ATL.CDynamicAccessor.GetValue"
  - "ATL::CDynamicAccessor::GetValue"
  - "ATL::CDynamicAccessor::GetValue<ctype>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetValue method"
ms.assetid: 553f44af-68bc-4cb6-8774-e0940003fa90
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicAccessor::GetValue
Retrieves the data for a specified column.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] A templated parameter that handles any data type except string types (**CHAR\***, **WCHAR\***), which require special handling. <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> uses the appropriate data type based on what you specify here.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The column number. Column numbers start with 1. A value of 0 refers to the bookmark column, if any.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The column name.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] The pointer to the contents of the specified column.  
  
## Return Value  
 If you want to pass string data, use the nontemplated versions of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The nontemplated versions of this method return **void\***, which points to the part of the buffer that contains the specified column data. Returns **NULL** if the column is not found.  
  
 For all other data types, it is simpler to use the templated versions of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The templated versions return **true** on success or **false** on failure.  
  
## Remarks  
 Use the nontemplated versions to return columns that contain strings and the templated versions for columns that contain other data types.  
  
 In debug mode, you will get an assertion if the size of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is unequal to the size of the column to which it points.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicAccessor Class](../vs140/cdynamicaccessor-class.md)