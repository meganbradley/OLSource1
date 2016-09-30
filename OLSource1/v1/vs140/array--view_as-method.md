---
title: "array::view_as Method"
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
  - "amp/Concurrency::array::view_as"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "view_as method"
ms.assetid: a13aa5fb-7836-436a-8311-270d459b7e74
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# array::view_as Method
Reinterprets this array as an [array_view](../vs140/array_view-class.md) of a different rank.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The rank of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object passed as a parameter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The extent that is used to construct the new [array_view](../vs140/array_view-class.md) object.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The data type of the elements in both the original [array](../vs140/array-class.md) object and the returned <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Return Value  
 The [array_view](../vs140/array_view-class.md) object that is constructed.  
  
## Requirements  
 **Header:** amp.h  
  
 **Namespace:** Concurrency  
  
## See Also  
 [array Class](../vs140/array-class.md)