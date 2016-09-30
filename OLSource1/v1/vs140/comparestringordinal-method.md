---
title: "CompareStringOrdinal Method"
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
  - "corewrappers/Microsoft::WRL::Wrappers::Details::CompareStringOrdinal"
dev_langs: 
  - "C++"
ms.assetid: ffa997fd-8cd7-40a5-b9e7-f55d40b072f4
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CompareStringOrdinal Method
Supports the WRL infrastructure and is not intended to be used directly from your code.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The first HSTRING to compare.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second HSTRING to compare.  
  
## Return Value  
  
|Value|Condition|  
|-----------|---------------|  
|-1|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is less than <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|0|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> equals <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.|  
|1|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is greater than <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
  
## Remarks  
 Compares two specified HSTRING objects and returns an integer that indicates their relative position in a sort order.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers::Details  
  
## See Also  
 [Microsoft::WRL::Wrappers::Details Namespace](../vs140/microsoft--wrl--wrappers--details-namespace.md)