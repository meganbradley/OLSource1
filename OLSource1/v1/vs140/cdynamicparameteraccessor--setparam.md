---
title: "CDynamicParameterAccessor::SetParam"
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
  - "ATL::CDynamicParameterAccessor::SetParam"
  - "ATL::CDynamicParameterAccessor::SetParam<ctype>"
  - "CDynamicParameterAccessor.SetParam"
  - "ATL.CDynamicParameterAccessor.SetParam"
  - "SetParam"
  - "CDynamicParameterAccessor:SetParam"
  - "CDynamicParameterAccessor::SetParam<ctype>"
  - "CDynamicParameterAccessor::SetParam"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetParam method"
ms.assetid: e2349220-545c-46ad-90da-9113ac52551a
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicParameterAccessor::SetParam
Sets the parameter buffer using the specified (non-string) data.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A templated parameter that is the data type.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] The parameter number (offset from 1). Parameter 0 is reserved for return values. The parameter number is the index of the parameter based on its order in the SQL or stored procedure call. For example:  
  
 [!code[NVC_OLEDB_Consumer#8](../vs140/codesnippet/CPP/cdynamicparameteraccessor--setparam_1.cpp)]  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [in] The parameter name.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [in] The pointer to the memory containing the data to be written to the buffer.  
  
 *status*  
 [in] The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> column status. For information on <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> values, see [Status](https://msdn.microsoft.com/en-us/library/ms722617.aspx) in the *OLE DB Programmer's Reference*, or search for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> in oledb.h.  
  
## Return Value  
 Returns **true** on success or **false** on failure.  
  
 Use <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to set nonstring parameter data in the buffer. Use [SetParamString](../vs140/cdynamicparameteraccessor--setparamstring.md) to set string parameter data in the buffer.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicParameterAccessor Class](../vs140/cdynamicparameteraccessor-class.md)