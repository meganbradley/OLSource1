---
title: "IEnumOnSTLImpl::Next"
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
  - "IEnumOnSTLImpl.Next"
  - "ATL.IEnumOnSTLImpl.Next"
  - "ATL::IEnumOnSTLImpl::Next"
  - "IEnumOnSTLImpl::Next"
  - "Next"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Next method"
ms.assetid: 3b3c92aa-ecb5-42c7-bf87-2552e3a9c8e4
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IEnumOnSTLImpl::Next
This method provides the implementation of the [IEnumXXXX::Next](https://msdn.microsoft.com/en-us/library/ms695273.aspx) method.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 [in] The number of elements requested.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 [out] The array to be filled in with the elements.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 [out] The number of elements actually returned in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. This can be less than <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if fewer than <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements remain in the list.  
  
## Return Value  
 A standard <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> value.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [IEnumOnSTLImpl Class](../vs140/ienumonstlimpl-class.md)