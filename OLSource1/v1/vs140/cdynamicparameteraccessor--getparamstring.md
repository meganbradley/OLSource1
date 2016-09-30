---
title: "CDynamicParameterAccessor::GetParamString"
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
  - "CDynamicParameterAccessor.GetParamString"
  - "GetParamString"
  - "CDynamicParameterAccessor::GetParamString"
  - "ATL.CDynamicParameterAccessor.GetParamString"
  - "ATL::CDynamicParameterAccessor::GetParamString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParamString method"
ms.assetid: 078c2b1c-7072-47c1-a203-f47e75363f91
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDynamicParameterAccessor::GetParamString
Retrieves the string data of the specified parameter stored in the buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The parameter number (offset from 1). Parameter 0 is reserved for return values. The parameter number is the index of the parameter based on its order in the SQL or stored procedure call. See [SetParam](../vs140/cdynamicparameteraccessor--setparam.md) for an example.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] The ANSI (**CSimpleStringA**) or Unicode (**CSimpleStringW**) string data of the specified parameter. You should pass a parameter of type <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, for example:  
  
 [!code[NVC_OLEDB_Consumer#9](../vs140/codesnippet/CPP/cdynamicparameteraccessor--getparamstring_1.cpp)]  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 [out] A pointer to the ANSI (**CHAR**) or Unicode (**WCHAR**) string data of the specified parameter.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 [out] A pointer to the size of the buffer pointed to by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (in characters, including the terminating NULL).  
  
## Remarks  
 Returns **true** on success or **false** on failure.  
  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is NULL, this method will set the required buffer size in the memory pointed to by <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and return **true** without copying the data.  
  
 This method will fail if the buffer <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is not large enough to contain the whole string.  
  
 Use <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> to retrieve string parameter data from the buffer. Use [GetParam](../vs140/cdynamicparameteraccessor--getparam.md) to retrieve nonstring parameter data from the buffer.  
  
## Requirements  
 **Header:** atldbcli.h  
  
## See Also  
 [CDynamicParameterAccessor Class](../vs140/cdynamicparameteraccessor-class.md)