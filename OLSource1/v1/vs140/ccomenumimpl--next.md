---
title: "CComEnumImpl::Next"
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
  - "CComEnumImpl.Next"
  - "CComEnumImpl::Next"
  - "ATL.CComEnumImpl.Next"
  - "ATL::CComEnumImpl::Next"
  - "Next"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Next method"
ms.assetid: 976ddce7-a0af-468b-9770-3743a21d6fb0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComEnumImpl::Next
This method provides the implementation of the [IEnumXXXX::Next](https://msdn.microsoft.com/en-us/library/ms695273.aspx) method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The number of elements requested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] The array to be filled with the elements.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] The number of elements actually returned in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This can be less than <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if fewer than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements remained in the list.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComEnumImpl Class](../vs140/ccomenumimpl-class.md)