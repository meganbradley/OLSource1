---
title: "operator== (&lt;sample container&gt;)"
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
  - "std.=="
  - "std::=="
  - "operator=="
  - "std.operator=="
  - "std::operator=="
  - "=="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator ==, containers"
  - "operator==, containers"
  - "== operator, with specific standard C++ objects"
ms.assetid: d3d8754e-5157-4b8b-bf9c-da41856f5eed
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator== (&lt;sample container&gt;)
> [!NOTE]
>  This topic is in the Visual C++ documentation as a nonfunctional example of containers used in the Standard C++ Library. For more information, see [STL Containers](../VS_csharp/stl-containers.md).  
  
 Overloads `operator==` to compare two objects of template class [Container](../VS_csharp/sample-container-class.md).  
  
## Syntax  
  
```  
  
   template<class Ty>  
bool operator==(  
   const Container <Ty>& _Left,  
   const Container <Ty>& _Right  
);  
```  
  
## Return Value  
 Returns `_Left`**.**[size](../VS_csharp/container-class--size.md) **==** `_Right`**.size && equal**(_*Left***.**[begin](../VS_csharp/container-class--begin.md), `_Left`. [end](../VS_csharp/container-class--end.md)*, _Right***.begin**).  
  
## See Also  
 [<sample container\>](../VS_csharp/-sample-container-.md)