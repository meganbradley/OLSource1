---
title: "&lt;istream&gt; functions"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 0301ea0d-4ded-4841-83dd-4253b55b3188
caps.latest.revision: 11
---
# &lt;istream&gt; functions
|||  
|-|-|  
|[&lt;istream&gt; swap](#istream_swap)|[ws](#ws)|  
  
##  \<a name="istream_swap">\</a>  &lt;istream&gt; swap  
 Exchanges the elements of two stream objects.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A stream.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A stream.  
  
##  \<a name="ws">\</a>  ws  
 Skips white space in the stream.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A stream.  
  
### Return Value  
 The stream.  
  
### Remarks  
 The manipulator extracts and discards any elements <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> for which [use_facet](../vs140/basic_filebuf-class.md#basic_filebuf__open)< **ctype**\< **Elem**> >( [getloc](../vs140/ios_base-class.md#ios_base__getloc)). **is**( **ctype**\< **Elem**>:: **space**, **ch**) is true.  
  
 The function calls [setstate](../vs140/basic_ios-class.md#basic_ios__setstate)( **eofbit**) if it encounters end of file while extracting elements. It returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
### Example  
  See [operator>>](../vs140/-istream--operators.md#operator_gt__gt_) for an example of using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## See Also  
 [&lt;istream&gt;](../vs140/-istream-.md)