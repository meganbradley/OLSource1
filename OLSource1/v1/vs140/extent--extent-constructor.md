---
title: "extent::extent Constructor"
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
  - "amp/Concurrency::extent::extent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "extent, constructor"
ms.assetid: 4b10b446-6f7b-405f-989d-71144b0cc91d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# extent::extent Constructor
Initializes a new instance of the [extent](../vs140/extent-class--c---amp-.md) class.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An array of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> integers that is used to create the new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The length of the extent.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The length of the most significant dimension.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The length of the next-to-most-significant dimension.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The length of the least significant dimension.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 An <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object on which the new <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object is based.  
  
## Remarks  
 The parameterless constructor initializes an <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> object that has a rank of three.  
  
 If an array is used to construct an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> object, the length of the array must match the rank of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> object.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [extent Structure](../vs140/extent-class--c---amp-.md)