---
title: "wstring"
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
  - "std::wstring"
  - "wstring"
  - "std.wstring"
  - "xstring/std::wstring"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "wstring typedef"
ms.assetid: 77953dd7-ee2f-4f6c-90e7-27da549ca631
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# wstring
A type that describes a specialization of the template class [basic_string](../vs140/basic_string-class.md) with elements of type `wchar_t`.  
  
 Other typedefs that specialize `basic_string` include [string](../vs140/string--c---stl--string--.md), [u16string](../vs140/u16string.md), and [u32string](../vs140/u32string.md).  
  
## Syntax  
  
```cpp  
typedef basic_string<wchar_t, char_traits<wchar_t>, allocator<wchar_t>> wstring;  
```  
  
## Remarks  
 The following are equivalent declarations:  
  
```cpp  
wstring wstr(L"");  
  
basic_string<wchar_t> wstr(L"");  
```  
  
 For a list of string constructors, see [basic_string::basic_string](../vs140/basic_string--basic_string.md).  
  
> [!NOTE]
>  The size of `wchar_t` is implementation-defined. If your code depends on `wchar_t` to be a certain size, check your platform's implementation (for example, with `sizeof(wchar_t)`). If you need a string character type with a width that is guaranteed to remain the same on all platforms, use [string](../vs140/string--c---stl--string--.md), [u16string](../vs140/u16string.md), or [u32string](../vs140/u32string.md).  
  
## Requirements  
 **Header:** \<string>  
  
 **Namespace:** std  
  
## See Also  
 [\<string>](../vs140/-string-.md)   
 [basic_string Class](../vs140/basic_string-class.md)