---
title: "&lt;string&gt; typedefs"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: fdca01e9-f2f1-4b59-abda-0093d760b3cc
caps.latest.revision: 14
---
# &lt;string&gt; typedefs
||||  
|-|-|-|  
|[string](#string)|[u16string](#u16string)|[u32string](#u32string)|  
|[wstring](#wstring)|  
  
##  \<a name="string">\</a>  string  
 A type that describes a specialization of the template class [basic_string](../vs140/basic_string-class.md) with elements of type <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 Other typedefs that specialize <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> include [wstring](../vs140/-string--typedefs.md#wstring), [u16string](../vs140/-string--typedefs.md#u16string), and [u32string](../vs140/-string--typedefs.md#u32string).  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Remarks  
 The following are equivalent declarations:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For a list of string constructors, see [basic_string::basic_string](../vs140/basic_string-class.md#basic_string__basic_string).  
  
##  \<a name="u16string">\</a>  u16string  
 A type that describes a specialization of the template class [basic_string](../vs140/basic_string-class.md) with elements of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 Other typedefs that specialize <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> include [wstring](../vs140/-string--typedefs.md#wstring), [string](../vs140/-string--typedefs.md#string), and [u32string](../vs140/-string--typedefs.md#u32string).  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Remarks  
 For a list of string constructors, see [basic_string::basic_string](../vs140/basic_string-class.md#basic_string__basic_string).  
  
##  \<a name="u32string">\</a>  u32string  
 A type that describes a specialization of the template class [basic_string](../vs140/basic_string-class.md) with elements of type <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 Other typedefs that specialize <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> include [string](../vs140/-string--typedefs.md#string), [u16string](../vs140/-string--typedefs.md#u16string), and [wstring](../vs140/-string--typedefs.md#wstring).  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
### Remarks  
 For a list of string constructors, see [basic_string::basic_string](../vs140/basic_string-class.md#basic_string__basic_string).  
  
##  \<a name="wstring">\</a>  wstring  
 A type that describes a specialization of the template class [basic_string](../vs140/basic_string-class.md) with elements of type <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 Other typedefs that specialize <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> include [string](../vs140/-string--typedefs.md#string), [u16string](../vs140/-string--typedefs.md#u16string), and [u32string](../vs140/-string--typedefs.md#u32string).  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Remarks  
 The following are equivalent declarations:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 For a list of string constructors, see [basic_string::basic_string](../vs140/basic_string-class.md#basic_string__basic_string).  
  
> [!NOTE]
>  The size of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is implementation-defined. If your code depends on <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to be a certain size, check your platform's implementation (for example, with <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>). If you need a string character type with a width that is guaranteed to remain the same on all platforms, use [string](../vs140/-string--typedefs.md#string), [u16string](../vs140/-string--typedefs.md#u16string), or [u32string](../vs140/-string--typedefs.md#u32string).  
  
## See Also  
 [&lt;string&gt;](../vs140/-string-.md)