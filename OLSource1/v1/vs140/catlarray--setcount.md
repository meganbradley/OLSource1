---
title: "CAtlArray::SetCount"
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
  - "CAtlArray::SetCount"
  - "ATL::CAtlArray::SetCount"
  - "ATL.CAtlArray.SetCount"
  - "CAtlArray.SetCount"
  - "SetCount"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCount method"
ms.assetid: 1212bd03-5ec1-4980-a2c9-15a80ed256a4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlArray::SetCount
Call this method to set the size of the array object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The required size of the array.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value used to determine how large to make the buffer. A value of -1 causes an internally calculated value to be used.  
  
## Return Value  
 Returns true if the array is successfully resized, false otherwise.  
  
## Remarks  
 The array can be increased or decreased in size. If increased, extra empty elements are added to the array. If decreased, the elements with the largest indices will be deleted and memory freed.  
  
 Use this method to set the size of the array before using it. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is not used, the process of adding elements — and the subsequent memory allocation performed — will reduce performance and fragment memory.  
  
## Example  
 See the example for [CAtlArray::GetData](../vs140/catlarray--getdata.md).  
  
## Requirements  
 **Header:** atlcoll.h  
  
## See Also  
 [CAtlArray Class](../vs140/catlarray-class.md)