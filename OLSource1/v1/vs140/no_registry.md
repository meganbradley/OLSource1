---
title: "no_registry"
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
  - "no_registry"
dev_langs: 
  - "C++"
  - "C"
helpviewer_keywords: 
  - "no_registry attribute"
ms.assetid: d30de4e2-551c-428c-98fd-951330d578d3
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# no_registry
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder> tells the compiler not to search the registry for type libraries imported with <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *filename*  
 A type library.  
  
## Remarks  
 If a referenced type library is not found in the include directories, the compilation will fail even if the type library is in the registry.  <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> propagates to other type libraries implicitly imported with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 The compiler will never search the registry for type libraries that are specified by file name and passed directly to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 When <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is specified, the additional <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>s will be generated with the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> setting of the initial <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (if the initial <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> directive was <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, an <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>-generated <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is also <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>.)  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is useful if you want to import cross referenced type libraries without the risk of the compiler finding an older version of the file in the registry.  <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is also useful if the type library is not registered.  
  
## See Also  
 [#import Attributes](../vs140/sharpimport-attributes--c---.md)   
 [The #import Directive](../vs140/sharpimport-directive--c---.md)