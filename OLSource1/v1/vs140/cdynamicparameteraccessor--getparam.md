---
title: "CDynamicParameterAccessor::GetParam"
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
  - "CDynamicParameterAccessor::GetParam"
  - "ATL.CDynamicParameterAccessor.GetParam"
  - "CDynamicParameterAccessor::GetParam<ctype>"
  - "CDynamicParameterAccessor.GetParam"
  - "GetParam"
  - "ATL::CDynamicParameterAccessor::GetParam<ctype>"
  - "ATL::CDynamicParameterAccessor::GetParam"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParam method"
ms.assetid: 893a6bf8-7b55-4f6d-8a10-a43b13be7f56
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicParameterAccessor::GetParam
Retrieves the nonstring data for a specified parameter from the parameter buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A templated parameter that is the data type.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The parameter number (offset from 1). Parameter 0 is reserved for return values. The parameter number is the index of the parameter based on its order in the SQL or stored procedure call. See [SetParam](../vs140/cdynamicparameteraccessor--setparam.md) for an example.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The parameter name.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] The pointer to the memory containing the data retrieved from the buffer.  
  
## Return Value  
 For nontemplated versions, points to the memory containing the data retrieved from the buffer. For templated versions, returns **true** on success or **false** on failure.  
  
 Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to retrieve nonstring parameter data from the buffer. Use [GetParamString](../vs140/cdynamicparameteraccessor--getparamstring.md) to retrieve string parameter data from the buffer.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicParameterAccessor Class](../vs140/cdynamicparameteraccessor-class.md)