---
title: "basic_ios::clear"
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
  - "ios/std::basic_ios::clear"
  - "clear"
  - "basic_ios.clear"
  - "std.basic_ios.clear"
  - "basic_ios::clear"
  - "std::basic_ios::clear"
  - "Clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "clear method"
ms.assetid: dc172694-1267-45f8-8f5c-e822e16fc271
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::clear
Clears all error flags.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> (optional)  
 The flags you want to set after clearing all flags. Defaults to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (optional)  
 Specifies whether the exception should be re-raised. Defaults to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> (will not re-raise the exception).  
  
## Remarks  
 The flags are **goodbit**, **failbit**, **eofbit**, and **badbit**. Test for these flags with [good](../vs140/basic_ios--good.md), [bad](../vs140/basic_ios--bad.md), [eof](../vs140/basic_ios--eof.md), and [fail](../vs140/basic_ios--fail.md)  
  
 The member function replaces the stored stream state information with:  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>[rdbuf](../vs140/basic_ios--rdbuf.md) != 0 ? **goodbit** : **badbit**)  
  
 If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>**&**[exceptions](../vs140/basic_ios--exceptions.md) is nonzero, it then throws an object of class [failure](../vs140/ios_base--failure.md).  
  
## Example  
 See [rdstate](../vs140/basic_ios--rdstate.md) and [getline](../vs140/getline-template-function.md) for examples using **clear**.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)