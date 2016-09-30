---
title: "CDynamicParameterAccessor::SetParamString"
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
  - "ATL.CDynamicParameterAccessor.SetParamString"
  - "ATL::CDynamicParameterAccessor::SetParamString"
  - "SetParamString"
  - "CDynamicParameterAccessor::SetParamString"
  - "CDynamicParameterAccessor.SetParamString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetParamString method"
ms.assetid: 77a38d23-7e33-4e5a-bda6-c12c4c3fe2e4
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicParameterAccessor::SetParamString
Sets the string data of the specified parameter stored in the buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The parameter number (offset from 1). Parameter 0 is reserved for return values. The parameter number is the index of the parameter based on its order in the SQL or stored procedure call. See [SetParam](../vs140/cdynamicparameteraccessor--setparam.md) for an example.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [in] A pointer to the ANSI (**CHAR**) or Unicode (**WCHAR**) string data of the specified parameter. See <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in oledb.h.  
  
 *status*  
 [in] The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> status of the specified parameter. For information on <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> values, see [Status](https://msdn.microsoft.com/en-us/library/ms722617.aspx) in the *OLE DB Programmer's Reference*, or search for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in oledb.h.  
  
## Remarks  
 Returns **true** on success or **false** on failure.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> will fail if you try to set a string that is larger than the maximum size specified for <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 Use <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> to set string parameter data in the buffer. Use [SetParam](../vs140/cdynamicparameteraccessor--setparam.md) to set nonstring parameter data in the buffer.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicParameterAccessor Class](../vs140/cdynamicparameteraccessor-class.md)