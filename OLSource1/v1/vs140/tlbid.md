---
title: "tlbid"
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
  - "tlbid"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "tlbid attribute"
ms.assetid: 54b06785-191b-4e77-a9a5-485f2b4acb09
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# tlbid
**C++ Specific**  
  
 Allows for loading libraries other than the primary type library.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The number of the type library in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 If multiple type libraries are built into a single DLL, it possible to load libraries other than the primary type library by using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 For example:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 is equivalent to:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **END C++ Specific**  
  
## See Also  
 [#import Attributes](../vs140/sharpimport-attributes--c---.md)   
 [The #import Directive](../vs140/sharpimport-directive--c---.md)