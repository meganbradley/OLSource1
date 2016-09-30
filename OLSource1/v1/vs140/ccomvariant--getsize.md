---
title: "CComVariant::GetSize"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL::CComVariant::GetSize"
  - "CComVariant::GetSize"
  - "CComVariant.GetSize"
  - "ATL.CComVariant.GetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetSize method"
ms.assetid: 242d7b30-109f-479a-a32a-77a1db52eb08
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComVariant::GetSize
For simple-fixed size <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>s, this method returns the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> the underlying data type plus <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The size in bytes of the current contents of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Remarks  
 If the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> contains an interface pointer, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> queries for <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If successful, the return value is the low-order 32 bits of the value returned by <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> plus the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If the interface pointer is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> returns the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> plus <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. If the total size is larger than <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> which indicates an error.  
  
 In all other cases, a temporary <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is coerced from the current <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. The length of this <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is calculated as the size of the length of the string plus the length of the string itself plus the size of the null character plus <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>. If the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> cannot be coerced to a <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> of type <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>.  
  
 The size returned by this method matches the number of bytes used by [CComVariant::WriteToStream](../vs140/ccomvariant--writetostream.md) under successful conditions.  
  
## Requirements  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>: atlcomcli.h  
  
## See Also  
 [CComVariant Class](../vs140/ccomvariant-class.md)