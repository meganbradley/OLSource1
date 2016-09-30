---
title: "&lt;ios&gt; typedefs"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 0b962632-3439-44de-bf26-20c67a7f0ff3
caps.latest.revision: 13
---
# &lt;ios&gt; typedefs
||||  
|-|-|-|  
|[ios](#ios)|[streamoff](#streamoff)|[streampos](#streampos)|  
|[streamsize](#streamsize)|[wios](#wios)|[wstreampos](#wstreampos)|  
  
##  \<a name="ios">\</a>  ios  
 Supports the ios class from the old iostream library.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for template class [basic_ios](../vs140/basic_ios-class.md), specialized for elements of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> with default character traits.  
  
##  \<a name="streamoff">\</a>  streamoff  
 Supports internal operations.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Remarks  
 The type is a signed integer that describes an object that can store a byte offset involved in various stream positioning operations. Its representation has at least 32 value bits. It is not necessarily large enough to represent an arbitrary byte position within a stream. The value **streamoff(-1)** generally indicates an erroneous offset.  
  
##  \<a name="streampos">\</a>  streampos  
 Holds the current position of the buffer pointer or file pointer.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for [fpos](../vs140/fpos-class.md)< <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>>.  
  
### Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  **7**    
##  \<a name="streamsize">\</a>  streamsize  
 Denotes the size of the stream.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The type is a signed integer that describes an object that can store a count of the number of elements involved in various stream operations. Its representation has at least 16 bits. It is not necessarily large enough to represent an arbitrary byte position within a stream.  
  
### Example  
  After compiling and running the following program, look at the file test.txt to see the effect of setting <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="wios">\</a>  wios  
 Supports the wios class from the old iostream library.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for template class [basic_ios](../vs140/basic_ios-class.md), specialized for elements of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> with default character traits.  
  
##  \<a name="wstreampos">\</a>  wstreampos  
 Holds the current position of the buffer pointer or file pointer.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
### Remarks  
 The type is a synonym for [fpos](../vs140/fpos-class.md)< <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>>.  
  
### Example  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  **7**    
## See Also  
 [&lt;ios&gt;](../vs140/-ios-.md)