---
title: "basic_ios::narrow"
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
  - "basic_ios.narrow"
  - "narrow"
  - "std.basic_ios.narrow"
  - "Narrow"
  - "ios/std::basic_ios::narrow"
  - "std::basic_ios::narrow"
  - "basic_ios::narrow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "narrow method"
ms.assetid: 1978033a-a27c-43af-b9f0-21b57b1fd673
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::narrow
Finds the equivalent char to a given <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to convert.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that you want returned if no equivalent is found.  
  
## Return Value  
 The equivalent <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> to a given <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Remarks  
 The member function returns [use_facet](../vs140/basic_filebuf--open.md)**< ctype**\<**E**> >( [getloc](../vs140/ios_base--getloc.md)( ) ). <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)