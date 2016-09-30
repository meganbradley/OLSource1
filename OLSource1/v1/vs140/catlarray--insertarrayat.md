---
title: "CAtlArray::InsertArrayAt"
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
  - "CAtlArray.InsertArrayAt"
  - "ATL.CAtlArray.InsertArrayAt"
  - "CAtlArray::InsertArrayAt"
  - "ATL::CAtlArray::InsertArrayAt"
  - "InsertArrayAt"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InsertArrayAt method"
ms.assetid: 95e01539-80d9-4451-910a-96282ab1806c
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::InsertArrayAt
Call this method to insert one array into another.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The index at which the array is to be inserted.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The array to be inserted.  
  
## Remarks  
 Elements from the array <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> are copied into the array object, beginning at element <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The existing array elements are moved to avoid being overwritten.  
  
 In debug builds, an ATLASSERT will be raised if the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object is not valid, or if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> pointer is NULL or invalid.  
  
> [!NOTE]
>  <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> does not support arrays consisting of elements created with the [CAutoPtr](../vs140/cautoptr-class.md) class.  
  
## Example  
 [!code[NVC_ATL_Utilities#8](../vs140/codesnippet/CPP/catlarray--insertarrayat_1.cpp)]  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)   
 [CAtlArray::Append](../vs140/catlarray--append.md)