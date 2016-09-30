---
title: "ComPtr::ComPtr Constructor"
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
  - "client/Microsoft::WRL::ComPtr::ComPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ComPtr, constructor"
ms.assetid: eaf70907-beac-458f-a503-2e5e27b0c196
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ComPtr::ComPtr Constructor
Intializes a new instance of the ComPtr class. Overloads provide default, copy, move, and conversion constructors.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The type of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
  
## Remarks  
 The first constructor is the default constructor, which implictly creates an empty object. The second constructor specifies [__nullptr](../vs140/nullptr---c---component-extensions-.md), which explicitly creates an empty object.  
  
 The third constructor creates an object from the object specified by a pointer.  
  
 The fourth and fifth constructors are copy constructors. The fifth constructor copies an object if it is convertible to the current type.  
  
 The sixth and seventh constructors are move constructors. The seventh constructor moves an object if it is convertible to the current type.  
  
## Requirements  
 **Header:** client.h  
  
 **Namespace:** Microsoft::WRL  
  
## See Also  
 [ComPtr Class](../vs140/comptr-class.md)