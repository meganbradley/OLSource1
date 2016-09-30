---
title: "typeof Goes to T::typeid"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "typeid operator"
  - "__typeof keyword"
  - "typeid keyword [C++]"
ms.assetid: 6a0d35a7-7a1a-4070-b187-cff37cfdc205
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# typeof Goes to T::typeid
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> operator used in Managed Extensions for C++ has been supplanted by the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> keyword in [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 In Managed Extensions, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> operator returns the associated <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object when passed the name of a managed type. For example:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the new syntax, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> has been replaced by an additional form of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> that returns a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> when a managed type is specified.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [General Language Changes](../vs140/general-language-changes--c---cli-.md)   
 [typeid](../vs140/typeid---c---component-extensions-.md)