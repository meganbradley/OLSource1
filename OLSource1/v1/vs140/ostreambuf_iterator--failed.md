---
title: "ostreambuf_iterator::failed"
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
  - "std::ostreambuf_iterator::failed"
  - "failed"
  - "ostreambuf_iterator::failed"
  - "ostreambuf_iterator.failed"
  - "streambuf/std::ostreambuf_iterator::failed"
  - "std.ostreambuf_iterator.failed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "failed method"
ms.assetid: 3e316ed5-1a04-491a-8f08-ef67dc09dc50
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ostreambuf_iterator::failed
Tests for failure of an insertion into the output stream buffer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 **true** if no insertion into the output stream buffer has failed earlier; otherwise **false**.  
  
## Remarks  
 The member function returns **true** if, in any prior use of member <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, the call to **subf**_-><CodeContentPlaceHolder>3\</CodeContentPlaceHolder> returned **eof**.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **abc are characters output individually.**  
**No insertions failed.**   
## Requirements  
 **Header:** \<iterator>  
  
 **Namespace:** std  
  
## See Also  
 [ostreambuf_iterator Class](../vs140/ostreambuf_iterator-class.md)   
 [Standard Template Library](../vs140/standard-template-library.md)