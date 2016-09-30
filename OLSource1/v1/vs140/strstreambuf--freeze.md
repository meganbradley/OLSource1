---
title: "strstreambuf::freeze"
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
  - "Freeze"
  - "strstreambuf::freeze"
  - "std.strstreambuf.freeze"
  - "strstreambuf.freeze"
  - "std::strstreambuf::freeze"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "freeze method"
ms.assetid: 8497fe86-f52d-4c01-a26b-aa8ea33c6aea
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# strstreambuf::freeze
Causes a stream buffer to be unavailable through stream buffer operations.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> indicating whether you want the stream to be frozen.  
  
## Remarks  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is true, the function alters the stored <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> mode to make the controlled sequence frozen. Otherwise, it makes the controlled sequence not frozen.  
  
 [str](../vs140/strstreambuf--str.md) implies <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
> [!NOTE]
>  A frozen buffer will not be freed during <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> destruction. You must unfreeze the buffer before it is freed to avoid a memory leak.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **before freeze: stream good**  
**test1**  
**after freeze: stream good**  
**after write to frozen stream: stream bad**  
**after unfreezing stream: stream bad**  
**after clearing stream: stream good**  
**test1test3**   
## Requirements  
 **Header:** \<strstream>  
  
 **Namespace:** std  
  
## See Also  
 [strstreambuf Class](../vs140/strstreambuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)