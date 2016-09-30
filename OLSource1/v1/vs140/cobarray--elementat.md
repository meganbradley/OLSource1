---
title: "CObArray::ElementAt"
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
  - "CObArray::ElementAt"
  - "CObArray.ElementAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ElementAt method"
  - "CObArray class, element access"
ms.assetid: 4d3b0e92-dd84-4015-8e8e-b9dec3fda412
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CObArray::ElementAt
Returns a temporary reference to the element pointer within the array.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An integer index that is greater than or equal to 0 and less than or equal to the value returned by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> pointer.  
  
## Remarks  
 It is used to implement the left-side assignment operator for arrays. Note that this is an advanced function that should be used only to implement special array operators.  
  
 The following table shows other member functions that are similar to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
|Class|Member Function|  
|-----------|---------------------|  
|[CByteArray](../vs140/cbytearray-class.md)|**BYTE& ElementAt( INT_PTR** <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> **);**|  
|[CDWordArray](../vs140/cdwordarray-class.md)|**DWORD& ElementAt( INT_PTR** <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> **);**|  
|[CPtrArray](../vs140/cptrarray-class.md)|**void\*& ElementAt( INT_PTR** <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> **);**|  
|[CStringArray](../vs140/cstringarray-class.md)|**CString& ElementAt( INT_PTR** <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> **);**|  
|[CUIntArray](../vs140/cuintarray-class.md)|**UINT& ElementAt( INT_PTR** <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> **);**|  
|[CWordArray](../vs140/cwordarray-class.md)|**WORD& ElementAt( INT_PTR** <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> **);**|  
  
## Example  
 See the example for [CObArray::GetSize](../vs140/cobarray--getsize.md).  
  
## Requirements  
 **Header:** afxcoll.h  
  
## See Also  
 [CObArray Class](../vs140/cobarray-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CObArray::operator](../vs140/cobarray--operator.md)