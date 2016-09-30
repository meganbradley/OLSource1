---
title: "How to: Iterate Over Arrays with for each"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "arrays [C++], iterating with for each"
ms.assetid: ddc88ce2-69e1-44fc-af84-5b6f62fcb9e3
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Iterate Over Arrays with for each
This topic shows how to use the [for each, in](../vs140/for-each--in.md) keyword on different types of arrays.  
  
## Example  
 This sample shows how to use <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on array of reference types.  Note that if any dimension of a multi dimensional array is zero, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> loop will not iterate over the array.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **0 = in MyClass**  
**1 = in MyClass**  
**0 = in MyClass2**  
**1 = in MyClass2**  
**2 = in MyClass2**  
**3 = in MyClass2**   
## Example  
 This sample shows for each iterating over a \<xref:System.Collections.ArrayList*>, which implements \<xref:System.Collections.IEnumerable*>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **60**   
## Example  
 This sample shows how to iterate over an array of arrays.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **IntArray[0] = 10**  
**IntArray[0] = 10**  
**IntArray[1] = 11**  
**IntArray[1] = 11**  
**10**  
**10**  
**11**  
**11**   
## See Also  
 [for each, in](../vs140/for-each--in.md)