---
title: "operator&gt;="
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
  - "operator>="
  - "std::>="
  - "std.operator>="
  - ">="
  - "std.>="
  - "std::operator>="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - ">= operator, comparing specific objects"
  - "operator >="
  - "operator>="
ms.assetid: 14fbebf5-8b75-4afa-a51b-3112d31c07cf
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;=
> [!NOTE]
>  This topic is in the Visual C++ documentation as a nonfunctional example of containers used in the Standard C++ Library. For more information, see [STL Containers](../vs140/stl-containers.md).  
  
 Overloads **operator>=** to compare two objects of template class [Container](../vs140/sample-container-class.md).  
  
## Syntax  
  
```  
  
   template<class Ty>  
bool operator>=(  
   const Container <Ty>& _Left,  
   const Container <Ty>& _Right  
);  
```  
  
## Return Value  
 Returns **!**(_*Left* < \_*Right*).  
  
## See Also  
 [<sample container\>](../vs140/-sample-container-.md)