---
title: "noboolalpha"
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
  - "ios/std::noboolalpha"
  - "std::noboolalpha"
  - "std.noboolalpha"
  - "noboolalpha"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "noboolalpha"
  - "noboolalpha function"
ms.assetid: b36f6a55-49ec-4398-af3d-b0dc9c8bd5e5
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# noboolalpha
Specifies that variables of type [bool](../vs140/bool--c---.md) appear as 1 or 0 in the stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A reference to an object of type [ios_base](../vs140/ios_base-class.md), or to a type that inherits from <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Return Value  
 A reference to the object from which _*Str* is derived.  
  
## Remarks  
 By default, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is in effect.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> effectively calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>[unsetf](../vs140/ios_base--unsetf.md)(<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>), and then returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 [boolalpha](../vs140/boolalpha.md) reverses the effect of <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
 See [boolalpha](../vs140/boolalpha.md) for an example of using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)