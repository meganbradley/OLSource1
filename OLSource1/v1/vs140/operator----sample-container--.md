---
title: "operator&lt; (&lt;sample container&gt;)"
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
  - "std::operator<"
  - "operator<"
  - "std.<"
  - "<"
  - "std.operator<"
  - "std::<"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "< operator, comparing specific objects"
  - "operator<, valarrays"
  - "< operator"
  - "operator <, valarrays"
ms.assetid: 31027dd6-53be-428b-b950-1dcb25393597
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&lt; (&lt;sample container&gt;)
> [!NOTE]
>  This topic is in the Visual C++ documentation as a nonfunctional example of containers used in the Standard C++ Library. For more information, see [STL Containers](../vs140/stl-containers.md).  
  
 Overloads **operator<** to compare two objects of template class [Container](../vs140/sample-container-class.md).  
  
## Syntax  
  
```  
  
   template<class Ty>  
bool operator<(  
   const Container <Ty>& _Left,  
   const Container <Ty>& _Right  
);  
```  
  
## Return Value  
 Returns `lexicographical_compare`(_*Left*. [begin](../vs140/container-class--begin.md), \_*Left*. [end](../vs140/container-class--end.md), \_*Right***.begin**, \_*Right*.**end**).  
  
## See Also  
 [<sample container\>](../vs140/-sample-container-.md)