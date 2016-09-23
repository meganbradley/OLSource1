---
title: "operator&lt;&lt; (&lt;ostream&gt;)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - std.operator<<
  - std.<<
  - ostream/std::operator<<
  - <<
  - std::<<
  - std::operator<<
  - operator<<
dev_langs: 
  - C++
helpviewer_keywords: 
  - << operator
  - << operator, with specific objects
  - operator<<, streams
  - operator <<, streams
ms.assetid: 7d3fecab-2158-4759-8dbf-5587aaf076f0
caps.latest.revision: 23
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# operator&lt;&lt; (&lt;ostream&gt;)
Writes various types to the stream.  
  
## Syntax  
  
```  
template<class _Elem, class _Tr>  
   basic_ostream<_Elem, _Tr>& operator<<(  
      basic_ostream<_Elem, _Tr>& _Ostr,  
      const Elem *_Str  
   );  
template<class _Elem, class _Tr>  
   basic_ostream<_Elem, _Tr>& operator<<(  
      basic_ostream<_Elem, _Tr>& _Ostr,  
      Elem _Ch  
   );  
template<class _Elem, class _Tr>  
   basic_ostream<_Elem, _Tr>& operator<<(  
      basic_ostream<_Elem, _Tr>& _Ostr,  
      const char *_Str  
   );  
template<class _Elem, class _Tr>  
   basic_ostream<_Elem, _Tr>& operator<< (  
      basic_ostream<_Elem, _Tr>& _Ostr,  
      char _Ch  
   );  
template<class _Tr>  
   basic_ostream<char, _Tr>& operator<< (  
      basic_ostream<char, _Tr>& _Ostr,  
      const char *_Str  
   );  
template<class _Tr>  
   basic_ostream<char, _Tr>& operator<< (  
      basic_ostream<char, _Tr>& _ostr,  
      char _Ch  
   );  
template<class _Tr>  
   basic_ostream<char, _Tr>& operator<<(  
      basic_ostream<char, _Tr>& _Ostr,  
      const signed char *_Str  
   );  
template<class _Tr>  
   basic_ostream<char, _Tr>& operator<<(  
      basic_ostream<char, _Tr>& _Ostr,  
      signed char _Ch  
   );  
template<class _Tr>  
   basic_ostream<char, _Tr>& operator<<(  
      basic_ostream<char, _Tr>& _Ostr,  
      const unsigned char *_Str  
   );  
template<class _Tr>  
   basic_ostream<char, _Tr>& operator<<(  
      basic_ostream<char, _Tr>& _Ostr,  
      unsigned char _Ch  
   );  
template<class _Elem, class _Tr, class _Ty>  
    basic_ostream<_Elem, _Tr>& operator<<(  
        basic_ostream<_Elem, _Tr>&& _Ostr,  
        Ty _Val  
    );  
  
```  
  
#### Parameters  
 `_Ch`  
 A character.  
  
 `_Elem`  
 The element type.  
  
 `_Ostr`  
 A `basic_ostream` object.  
  
 `_Str`  
 A character string.  
  
 `_Tr`  
 Character traits.  
  
 `_Val`  
 The type  
  
## Return Value  
 The stream.  
  
## Remarks  
 The `basic_ostream` class also defines several insertion operators. For more information, see [basic_ostream::operator<<](../vs140/basic_ostream--operator--.md).  
  
 The template function  
  
```  
template<class _Elem, class _Tr>  
   basic_ostream<Elem, _Tr>& operator<<(  
      basic_ostream<Elem, _Tr>& _ostr,  
      const Elem *_Str);  
```  
  
 determines the length N = `traits_type::`[length](../vs140/char_traits--length.md)(`_Str`) of the sequence beginning at `_Str`, and inserts the sequence. If N < `_Ostr.`[width](../vs140/ios_base--width.md), then the function also inserts a repetition of `_Ostr.``width` - N fill characters. The repetition precedes the sequence if (`_Ostr`.[flags](../vs140/ios_base--flags.md) & `adjustfield` != [left](../vs140/left.md). Otherwise, the repetition follows the sequence. The function returns `_Ostr`.  
  
 The template function  
  
```  
template<class _Elem, class _Tr>  
   basic_ostream<Elem, _Tr>& operator<<(  
      basic_ostream<Elem, _Tr>& _Ostr,  
      Elem _Ch);  
```  
  
 inserts the element `_Ch`. If 1 < `_Ostr.width`, then the function also inserts a repetition of `_Ostr.width` - 1 fill characters. The repetition precedes the sequence if `_Ostr.flags & adjustfield != left`. Otherwise, the repetition follows the sequence. It returns `_Ostr`.  
  
 The template function  
  
```  
template<class _Elem, class _Tr>  
   basic_ostream<Elem, _Tr>& operator<<(  
      basic_ostream<Elem, _Tr>& _Ostr,  
      const char *_Str);  
```  
  
 behaves the same as  
  
```  
template<class _Elem, class _Tr>  
   basic_ostream<Elem, _Tr>& operator<<(  
      basic_ostream<Elem, _Tr>& _Ostr,  
      const Elem *_Str);  
```  
  
 except that each element `_Ch` of the sequence beginning at `_Str` is converted to an object of type `Elem` by calling `_Ostr.`[put](../vs140/basic_ostream--put.md)(`_Ostr.`[widen](../vs140/basic_ios--widen.md)(`_Ch`)).  
  
 The template function  
  
```  
template<class _Elem, class _Tr>  
   basic_ostream<Elem, _Tr>& operator<<(  
      basic_ostream<Elem, _Tr>& _Ostr,  
      char _Ch);  
```  
  
 behaves the same as  
  
```  
template<class _Elem, class _Tr>  
   basic_ostream<Elem, _Tr>& operator<<(  
      basic_ostream<Elem, _Tr>& _Ostr,  
      Elem _Ch);  
```  
  
 except that `_Ch` is converted to an object of type `Elem` by calling `_Ostr.put`(`_Ostr.widen`(`_Ch`)).  
  
 The template function  
  
```  
template<class _Tr>  
   basic_ostream<char, _Tr>& operator<<(  
      basic_ostream<char, _Tr>& _Ostr,  
      const char *_Str);  
```  
  
 behaves the same as  
  
```  
template<class _Elem, class _Tr>  
   basic_ostream<Elem, _Tr>& operator<<(  
      basic_ostream<Elem, _Tr>& _Ostr,  
      const Elem *_Str);  
```  
  
 (It does not have to widen the elements before inserting them.)  
  
 The template function  
  
```  
template<class _Tr>  
   basic_ostream<char, Tr>& operator<<(  
      basic_ostream<char, _Tr>& _Ostr,  
      char _Ch);  
```  
  
 behaves the same as  
  
```  
template<class _Elem, class _Tr>  
   basic_ostream<Elem, _Tr>& operator<<(  
      basic_ostream<Elem, _Tr>& _Ostr,  
      Elem _Ch);  
```  
  
 (It does not have to widen `_Ch` before inserting it.)  
  
 The template function  
  
```  
template<class _Tr>  
   basic_ostream<char, _Tr>& operator<<(  
      basic_ostream<char, _Tr>& _Ostr,  
      const signed char *_Str);  
```  
  
 returns `_Ostr` << (`const char *`)`_Str`.  
  
 The template function  
  
```  
template<class _Tr>  
   basic_ostream<char, _Tr>& operator<<(  
      basic_ostream<char, _Tr>& _Ostr,  
      signed char _Ch);  
```  
  
 returns `_Ostr` << (`char`)`_Ch`.  
  
 The template function:  
  
```  
template<class _Tr>  
   basic_ostream<char, _Tr>& operator<<(  
      basic_ostream<char, _Tr>& _Ostr,  
      const unsigned char *_Str);  
```  
  
 returns `_Ostr` << (`const char *`)`_Str`.  
  
 The template function:  
  
```  
template<class _Tr>  
   basic_ostream<char, _Tr>& operator<<(  
      basic_ostream<char, _Tr>& _Ostr,  
      unsigned char _Ch);  
```  
  
 returns `_Ostr` << (`char`)`_Ch`.  
  
 The template function:  
  
```  
template<class _Elem, class _Tr, class _Ty>  
    basic_ostream<_Elem, _Tr>& operator<<(  
        basic_ostream<char, _Tr>&& _Ostr,  
        _Ty _Val  
    );  
```  
  
 returns `_Ostr` `<<` `_Val` (and converts a [RValue Reference](../vs140/rvalue-reference-declarator----.md) to `_Ostr` to an lvalue in the process).  
  
## Example  
 See [flush](../vs140/flush--standard-c---library-.md) for an example using `operator<<`.  
  
## Requirements  
 **Header:** <ostream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ostream::operator<<](../vs140/basic_ostream--operator--.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)